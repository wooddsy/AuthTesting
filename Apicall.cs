using Frontend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace Frontend
{
    public class Apicaller
    {
        string url = ;
        static HttpClient client = new HttpClient();
        //TODO finish generic api caller
        public async Task<List<T>> CallAPI<T>(String Url)
        {
            List<T> result = null;
            HttpResponseMessage response = await client.GetAsync(Url);
            {

                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsJsonAsync<List<T>>();
                }
                return result;

            }
        }
        public async Task<object> addtoBasket(string Url, int Id)
        {
            List<>
           
           
           
        }
    }
}
