using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using System.Web.Http.Controllers;
namespace Mobapp.mvcapi
{
    public class AppAuthorizeAttribute : AuthorizeAttribute

    {
        private Boolean IsAllowed(string str_token, string controller, string action)
        {
            if (str_token == null || str_token == "")
                return false;
            else

                return true;
        }
        private Boolean Isvalidtoken(string str_token)
        {
            //check iP,time
            return true;
        }
        protected override void HandleUnauthorizedRequest(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            var challengeMessage = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            
            challengeMessage.Headers.Add("WWW-Authenticate", "Basic");
           // throw new System.Web.Http.HttpResponseException(challengeMessage);
            
        }
        private string tolower(object obj)
        {
            if (obj != null)
                return obj.ToString().ToLower();
            else
                return null;
        }
        public override void OnAuthorization(HttpActionContext actionContext)
        {


            string controller = tolower(actionContext.ControllerContext.RouteData.Values["controller"]);
            string action =tolower( actionContext.ControllerContext.RouteData.Values["action"]);
            if ((controller == "account") && (action == "login") && (actionContext.Request.Method.Method.ToUpper() == "GET"))
                return;
            string token=null;
            token = (from kvp in actionContext.Request.GetQueryNameValuePairs()
                                  where kvp.Key == "token"
                                  select kvp.Value).FirstOrDefault();
            if (token!=null)
                token = tolower(token);


           
        
            Boolean isAllowed = this.IsAllowed(token, controller, action);

            if (!isAllowed)
            {
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
               // HandleUnauthorizedRequest(actionContext);
            }
            else
            {
                
            }
        }
    }

 }