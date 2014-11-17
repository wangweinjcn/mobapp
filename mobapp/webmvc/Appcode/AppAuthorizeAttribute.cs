using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mobapp.webmvc.code
{
    public class AppAuthorizeAttribute : AuthorizeAttribute

    {
        private Boolean IsAllowed(string user, string controller, string action)
        {
            return true;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            string controller = filterContext.RouteData.Values["controller"].ToString().ToLower();
            string action = filterContext.RouteData.Values["action"].ToString().ToLower();
            if ((controller == "account") && (action == "login") &&(filterContext.HttpContext.Request.HttpMethod=="GET"))
                return;
            if ((controller == "admin") && (action == "login") && (filterContext.HttpContext.Request.HttpMethod == "GET"))
                return;
            object user = filterContext.HttpContext.Session["CURR_USER"];
            if (filterContext.RequestContext.HttpContext.Request.IsAuthenticated)
            {
                HttpCookie authCookie = filterContext.RequestContext.HttpContext.Request.Cookies[FormsAuthentication.FormsCookieName];
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);

            //    string cookiePath = ticket.CookiePath;
           //     DateTime expiration = ticket.Expiration;
           //     bool expired = ticket.Expired;
           //     bool isPersistent = ticket.IsPersistent;
          //      DateTime issueDate = ticket.IssueDate;
                string cookieusername = ticket.Name;
                HttpCookie cookie = filterContext.RequestContext.HttpContext.Request.Cookies.Get("clogintype");
                string strlogintype=null;
                if (cookie!=null)
                    strlogintype = cookie.Values["logintype"];
                if (controller == "admin" && strlogintype != "adminlogin")
                {
                    FormsAuthentication.SignOut();
                    filterContext.RequestContext.HttpContext.Session["CURR_USER"] = "";
                    HttpCookie lcookie = filterContext.RequestContext.HttpContext.Response.Cookies[FormsAuthentication.FormsCookieName];
                    lcookie.Expires = DateTime.Now.AddDays(-2);
                    filterContext.Result =
                          new RedirectResult("/Admin/Login");
                    return;
                }
                if (controller != "admin" && strlogintype == "adminlogin")
                {
                    FormsAuthentication.SignOut();
                    filterContext.RequestContext.HttpContext.Session["CURR_USER"] = "";
                    HttpCookie lcookie = filterContext.RequestContext.HttpContext.Response.Cookies[FormsAuthentication.FormsCookieName];
                    lcookie.Expires = DateTime.Now.AddDays(-2);
                    filterContext.Result =
                          new RedirectResult("/Account/Login?returnUrl=" + filterContext.HttpContext.Request.Url);
                    return;
                }
           //     string userData = ticket.UserData;

                if (user == null || user.ToString() == "")
                {

                    filterContext.HttpContext.Session["CURR_USER"] = cookieusername;
                    user = cookieusername;
                  
                }
               /*      
                var returnUrl = filterContext.RequestContext.HttpContext.Request["returnUrl"];
                if (returnUrl != null)
                    filterContext.HttpContext.Response.Redirect(returnUrl.ToString(), true);
                */
            }

            if (user == null || user.ToString() == "")
            {
                if ((controller == "account") && (action == "login"))
                    return;
               
                if ((controller == "admin"))
                {
                  if (filterContext.HttpContext.Request.HttpMethod=="GET")
                    filterContext.Result =
                           new RedirectResult("/Admin/Login");
                 
                }
                else
                filterContext.Result =
                    new RedirectResult("/Account/Login?returnUrl=" + filterContext.HttpContext.Request.Url);
                return;
            }
            string userid = user.ToString();

            Boolean isAllowed = this.IsAllowed(userid, controller, action);

            if (!isAllowed)
            {
                filterContext.RequestContext.HttpContext.Response.Write("无权访问");
                filterContext.HttpContext.Response.StatusCode = 403;
                filterContext.RequestContext.HttpContext.Response.End();
            }
            else
            {
                
            }
        }
    }

    public class UserAuthorizeAttribute : ActionFilterAttribute
    {
        private Boolean IsAllowed(string user, string controller, string action)
        {
            return true;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string user = filterContext.HttpContext.Session["CurrentUser"].ToString();

            if (user == null)
            {
                filterContext.Result = new RedirectResult("/Account/login");
                return;
            }

            string controller = filterContext.RouteData.Values["controller"].ToString().ToLower();
            string action = filterContext.RouteData.Values["action"].ToString().ToLower();
            Boolean isAllowed = this.IsAllowed(user, controller, action);

            if (!isAllowed)
            {
                // filterContext.RequestContext.HttpContext.Response.Write("无权访问");
                filterContext.HttpContext.Response.StatusCode = 403;
                filterContext.RequestContext.HttpContext.Response.End();
            }
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }
    }
}