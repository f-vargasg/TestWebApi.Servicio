using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWebApi.BE;

namespace TestWebApi.Servicio.Controllers
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
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        // GET api/values/TestGet
        [Route("api/values/GetTestFunc")]
        public GeneralResponseBE<string> GetTestFunc(string pValor)
        {

            GeneralResponseBE<string> generalResponseBE = new GeneralResponseBE<string>();
            try
            {
                generalResponseBE.Data = "El Valor es: " + pValor;
            }
            catch (Exception)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(System.Net.HttpStatusCode.ExpectationFailed, "No hay datos de respuesta."));
            }


            return generalResponseBE;
        }
    }
}
