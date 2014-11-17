using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mobapp.mvcapi.Controllers
{
    public class AccountController : ApiController
    {
        //
        // GET: /Account/

        public string Login( )
        {

            string token = null;
            string username = this.Request.Properties["username"] != null ? Request.Properties["username"].ToString():null;
            string password = this.Request.Properties["password"] != null ? Request.Properties["password"].ToString() : null;
            token = "testtoken";
            return token;
        }

    }
}
