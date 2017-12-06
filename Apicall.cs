﻿using Frontend.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp;

namespace Frontend
{
    public class Apicaller
    {
        
        static RestClient client = new RestClient();
        
        //TODO finish generic api caller
        public async Task<List<T>> CallAPI<T>(String Url)
        {
            List<T> result = null;
            HttpResponseMessage response = await client.ExecuteAsyncGet(Url);
            {

                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsJsonAsync<List<T>>();
                }
                return result;

            }
        }
        public async Task<string> addtoBasket<T>(string Url, Basket payload )
        {

            client.BaseUrl = new Uri(Url);
           // IRestResponse response;
            var request = new RestRequest("/api/Basket/add/", Method.POST);
            request.AddObject(payload);
            request.AddHeader("Bearer", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ik5rVXlOa001UlRsRlJVRTNOemxGUlVZM01UQTRNelE0TVVFeE5UUXhOa1l3TURJMFJESTJPQSJ9.eyJpc3MiOiJodHRwczovL3RoYW1jby5ldS5hdXRoMC5jb20vIiwic3ViIjoiNWtYV3RxbERBMk02QVBtZjlkaXF1NjdHSjBGdzJRU0lAY2xpZW50cyIsImF1ZCI6IkJhc2tldCIsImlhdCI6MTUxMjQ4NDc2NiwiZXhwIjoxNTEyNTcxMTY2LCJzY29wZSI6ImNyZWF0ZTpiYXNrZXQgcmVhZDpiYXNrZXQiLCJndHkiOiJjbGllbnQtY3JlZGVudGlhbHMifQ.XiTFA3m4ukx6VTgP5khWuuDQcRiF0KmMZ4f7obF_mgdYHlRZsXz9ElILVyjIz-gyklVLG0W0uI3IoT7aT3Y4rR9u1kHgn9ZonpJf5YeWT6N_oiTYRVEvNB9jQdi1XxQ1tAj8AiYnm7q2KKiTtAZtgo3kzPPxh7bxvkSPo15EiHQrqHb1_cKq1S47kZt_-0sn4SIVOvHxDMpX_s-yLRCmc3D6rkZWnIOc4EpDEmRImPGWL6v8so7uOXoQhM7pVlFqEZgtFSI-tcMjZHjCulJJMHk2D19u4Mfw__iOTdoYwOytlDr-LVZUu_qPmHZDQ5BttgGjHOAcl8yI_XliAWC68g");
            //request.AddQueryParameter("userId",payload.userId);
            //request.AddQueryParameter("productId", payload.productId.ToString());
            //request.AddQueryParameter("quantity", payload.Quantity.ToString());

            client.ExecuteAsyncPost(request, response => { });

            return response;
           
        }
    }
}
