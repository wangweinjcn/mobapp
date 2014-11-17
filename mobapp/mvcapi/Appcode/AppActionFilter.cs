using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;
namespace Mobapp.mvcapi
{
public class SessionUserParameterAttribute : ActionFilterAttribute
{
       public override void OnActionExecuting(ActionExecutingContext filterContext)
       {

            base.OnActionExecuting(filterContext);
       }
}
public class actionlogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ILog infolog = LogManager.GetLogger("applog");

            infolog.Info("[ controller:]" + filterContext.RouteData.Values["controller"].ToString() + "[action:]" + filterContext.RouteData.Values["action"].ToString());
        
        }
    }
}