using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;
namespace Mobapp.webmvc.code
{
public class SessionUserParameterAttribute : ActionFilterAttribute
{
       public override void OnActionExecuting(ActionExecutingContext filterContext)
       {

             const string key = "sessionUser";

           if (filterContext.ActionParameters.ContainsKey(key))
           {
               filterContext.ActionParameters[key] = filterContext.HttpContext.Session["CURR_USER"];//为Action设置参数
           }

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