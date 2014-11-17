using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Mobapp.localEcoSpace;
using Mobapp.Model;
using System.Reflection;
using Eco.ViewModel.Runtime;
using Mobapp.webmvc.code;
namespace Mobapp.webmvc
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AppAuthorizeAttribute());
            filters.Add(new SessionUserParameterAttribute());
            filters.Add(new actionlogAttribute());

        }
        public static void Registercache()
        { 
        
        }
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            log4net.Config.XmlConfigurator.Configure();
            ViewModelDefinitionsInApplication.InitViewModelsForEcoSpaceTypeByReadingViewModelsFromAssemblies(typeof(l_EcoSpace), new Assembly[1] { typeof(App.Model.App_ModelPackage).Assembly });
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}