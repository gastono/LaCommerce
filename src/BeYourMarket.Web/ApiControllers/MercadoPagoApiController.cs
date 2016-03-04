using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BeYourMarket.Web.ApiControllers
{
    public class MercadoPagoApiController : ApiController
    {
        // GET api/mercadopagoapi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/mercadopagoapi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/mercadopagoapi
        [HttpPost]
        public void UserCredential([FromBody]string value)
        {
            string a = "a";

        }

        // PUT api/mercadopagoapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/mercadopagoapi/5
        public void Delete(int id)
        {
        }
    }
}
