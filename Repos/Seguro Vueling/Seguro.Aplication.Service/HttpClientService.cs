using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using AutoMapper;

using System.Threading.Tasks;
using System.Net.Http;

namespace Seguro.Aplication.Service
{
    public class HttpClientService
    {
        static HttpClient client;
        static HttpClientService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings  .Get("Api")
                                           + ConfigurationManager.AppSettings.Get("Client"));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static object ConfigurationManager { get; }

        public static async Task<List<HttpClient>> GetClient()
        {
            IEnumerable<ClientService> ListaAlumnos = new List<ClientService>();
            try
            {
                HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;
                if (response.IsSuccessStatusCode)
                {
                    var alumnoJsonString = await response.Content.ReadAsStringAsync();
                    var deserialized = JsonConvert.DeserializeObject<IEnumerable<ClientService>>(alumnoJsonString);
                    ListaAlumnos = deserialized;
                }

            }
            catch (VuelingException ex)
            {
                throw ex;
            }
            return ListaAlumnos.ToList();
        }
    }

}

