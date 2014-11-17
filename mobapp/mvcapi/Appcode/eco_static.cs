using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eco.Handles;
using Eco.Web;
using Eco.ObjectRepresentation;
using Eco.Services;
using System.Reflection;

namespace Mobapp.mvcapi
{
    public class ecospace_inst
    {
        private EcoSpaceStrategyHandler ecoSpaceStrategyHandler;
        private EcoSpace ecoSpace;
        private void EnsureEcoSpace()
        {
            if (ecoSpace == null)
            {
                if (ecoSpaceStrategyHandler == null)
                    ecoSpaceStrategyHandler = new EcoSpaceStrategyHandler(SessionStateMode, EcoSpaceType, SessionStateKey, UsePool);
                ecoSpace = ecoSpaceStrategyHandler.GetEcoSpace();
                RegisterServices(ecoSpace);
            }
        }

        private Type ecoSpaceType ;
        public Type EcoSpaceType
        {
            get { return ecoSpaceType; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("EcoSpaceType");
                if (value.IsSubclassOf(typeof(EcoSpace)))
                    throw new ArgumentException("Must be a subclass of EcoSpace", "EcoSpaceType");
                if (ecoSpaceStrategyHandler != null)
                    throw new InvalidOperationException("Can't set the EcoSpaceType when the EcoSpaceProvider has already been created");
                ecoSpaceType = value;
            }
        }
        protected EcoSpaceStrategyHandler.SessionStateMode SessionStateMode { get; set; }
        protected string SessionStateKey { get; set; }
        protected bool UsePool { get; set; }

        public ecospace_inst(Type estype)
            : base()
        {
            this.ecoSpaceType = estype;
        }

        public ecospace_inst(string dllfile,string estypename)
            : base()
        {
            string strpath;
             if (System.Environment.CurrentDirectory == AppDomain.CurrentDomain.BaseDirectory) 
                 //Windows应用程序则相等   ...
             {   strpath = AppDomain.CurrentDomain.BaseDirectory;   }   
             else
             {
                 strpath = AppDomain.CurrentDomain.BaseDirectory + "Bin" + System.IO.Path.DirectorySeparatorChar;   
             } ;
            Assembly asmb = Assembly.LoadFrom(strpath+dllfile);
            this.ecoSpaceType = asmb.GetType(estypename);
        }
        public ecospace_inst(IEcoServiceProvider testServiceProvider)
            : base()
        {
            if (testServiceProvider == null)
                throw new ArgumentNullException("TestServiceProvider"); //Do not localize
            this.serviceProvider =testServiceProvider ;
            
        }
        protected void RegisterServices(EcoSpace ecoSpace)
        {
        }
        public  void OnResultExecuted(ResultExecutedContext filterContext)
        {
            if ( ecoSpace != null)
                ecoSpaceStrategyHandler.ReturnEcoSpace(ecoSpace);
        }
        private IEcoServiceProvider serviceProvider;
        public IEcoServiceProvider ServiceProvider
        {
            get
            {
                if (serviceProvider == null)
                {
                    EnsureEcoSpace();
                    serviceProvider = ecoSpace;
                }
                return serviceProvider;
            }
        }



        public virtual void UpdateDatabase()
        {
            IDirtyListService dirtyListService = ServiceProvider.GetEcoService<IDirtyListService>();
            ServiceProvider.GetEcoService<IPersistenceService>().UpdateDatabaseWithList(dirtyListService.AllDirtyObjects());
        }

    }
}