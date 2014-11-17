using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  System.Web.Mvc;
using log4net;
using System.Net;
using System.Web.Routing;
using System.Runtime.Serialization;
namespace Mobapp.webmvc.code
{
    public class AppHandleErrorAttribute : HandleErrorAttribute

    {

        /// <summary>
        /// 此异常是后端和前端交互使用，后端可以抛出异常，包含异常的信息，前端捕获WebException,并将错误信息显示给用户
        /// 未捕获的异常可以在Global中处理（记日志）
        /// </summary>
        [Serializable]
        public class WebException : ApplicationException
        {
            public WebException() { }

            public WebException(string message)
                : base(message)
            {

            }

            public WebException(string message, Exception innerException)
                : base(message, innerException)
            {

            }
            protected WebException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }

        public override void OnException(ExceptionContext filterContext)
        {
            // 记日志
            ILog log = LogManager.GetLogger("errlog");
            Exception ex = filterContext.Exception;
            if (ex is WebException)
            {
                log.Error("自定义异常（WebException）：", ex);
                // 表示异常已处理，直接跳到500显示错误消息
                filterContext.ExceptionHandled = true;
                filterContext.Result = new RedirectToRouteResult("500", new RouteValueDictionary(new
                { message = ex.Message
                }));
            }
            else
            {
               log.Error("系统异常：", ex);
            }
        }
    }


}