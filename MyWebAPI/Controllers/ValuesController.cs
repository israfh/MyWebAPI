using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return string.Format("Valor {0}", id) ;
        }
        
        public string GetTwoStrings(string a, string b)
        {
            return string.Format("{0}{1}", a, b); //rama 20171101
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
