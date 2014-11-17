namespace Mobapp.localEcoSpace
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Handles;
    using Eco.Services;
    using Eco.Persistence;
    using Eco.Wcf.Server;
    using System.Configuration;

    public partial class l_PMP : Eco.Persistence.PersistenceMapperProvider
    {

        private string getconnstring()
        {

            return ConfigurationSettings.AppSettings["mysqlconn"].ToString(); ;
        }
        private void setpmpconncetion()
        {
            this.persistenceMapperMySql1.ConnectionString = getconnstring();
        }
        public l_PMP()
            : base()
        {
            this.InitializeComponent();
            setpmpconncetion();
        }

        /// <summary>
        /// Gets the singleton instance of the PersistenceMapperProvider.
        /// </summary>
        public static l_PMP Instance
        {
            get
            {
                return GetInstance<l_PMP>();
            }
        }

        /// <summary>
        /// Regenerates the database schema, no questions asked.
        /// </summary>
        public static void GenerateDB()
        {
            Instance.DoGenerateDB();
        }
        #region Eco Managed Code
        private void DoGenerateDB()
        {
            if (PersistenceMapper is PersistenceMapperDb)
            {
                (PersistenceMapper as PersistenceMapperDb).CreateDatabaseSchema(GetTypeSystemService(true), new DefaultCleanPsConfig(true));
            }
            else
            {
                throw new InvalidOperationException("The PersistenceMapper is not a PersistenceMapperDb");
            }
        }
        #endregion
    }

}
