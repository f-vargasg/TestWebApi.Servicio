using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestWebApi.BE;

namespace TestWebApi.BL
{
    public class TestApiBL
    {
        HttpClient httpClient;
        string uriSrvWapi;
        string msgTrace;
        public TestApiBL(string pUrlSrvBaseAddress,
                         string pUriSrvWapi)
        {
            this.httpClient = new HttpClient();
            this.httpClient.BaseAddress = new Uri( pUrlSrvBaseAddress);
            this.uriSrvWapi = pUriSrvWapi;
        }
        public GeneralResponseBE<string> TestFunc (string pValor)
        {
            GeneralResponseBE<string> res = new GeneralResponseBE<string>();
            try
            {
                string uriOper = this.uriSrvWapi + ConstantBE.zGetTestFunc + "?pvalor="+ pValor;
                // var postTask = httpClient.PostAsJsonAsync(uriOper, string.Empty);
                var postTask = httpClient.GetAsync(uriOper);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var jsonPuro = result.Content.ReadAsStringAsync();
                    jsonPuro.Wait();
                    res = JsonConvert.DeserializeObject<GeneralResponseBE<string>>(jsonPuro.Result);
                }
                else
                {
                    res.StatusResponseCode = result.StatusCode;
                    res.Mensaje = result.ReasonPhrase;
                    res.Data = null;
                }
            }
            catch (Exception ex)
            {
                res.StatusResponseCode = System.Net.HttpStatusCode.NotFound;
                res.OcurrioExcepcion = true;
                res.Mensaje = "Excepcion en [TestApiBL.TestFunc] " + ex.Message;
            }
            return res;
        }
    }
}
