using System;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
using log4net;
namespace Mobapp.mvcapi
{
    public class AppApiExceptionFilter : System.Web.Http.Filters.ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            ILog log = LogManager.GetLogger("applog");
            log.Error(context.Exception);

            var message = context.Exception.Message;
            if (context.Exception.InnerException != null)
                message = context.Exception.InnerException.Message;

            context.Response = new HttpResponseMessage() { Content = new StringContent(message) };

            base.OnException(context);
        }
    }

}