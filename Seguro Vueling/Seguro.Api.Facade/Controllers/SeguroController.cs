using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Seguro.Api.Facade.Controllers
{
    public class SeguroController : ApiController
    {
        // GET: api/Seguro
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Seguro/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Seguro
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Seguro/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Seguro/5
        public void Delete(int id)
        {
        }
    }
}
