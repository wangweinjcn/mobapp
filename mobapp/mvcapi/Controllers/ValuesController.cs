using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mobapp.mvcapi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
       [HttpGet]
        public IEnumerable<string> Getall()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet]
        public string Getvalue(int id)
        {
            return "get value--"+Convert.ToString(id);
        }
        [HttpPost]
        public string postvalue(int id)
        {
            return "post value--" + Convert.ToString(id);
        }
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}