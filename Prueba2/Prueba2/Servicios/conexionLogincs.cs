using Newtonsoft.Json;
using Prueba2.model;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace Prueba2
{
    class conexionLogincs
    {
        public async Task<T> Get<T>(string url)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }

    }
}
