using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Frontend.Model;
using RestSharp;

namespace Frontend.Controllers
{
    public class BasketController : Controller
    {
        
        Basket basket;
        Apicaller api;
        static RestClient client = new RestClient();
        string apiaddress = "http://localhost:51130/";
        // GET: Basket
        public ActionResult Index()
        {

            return View();
        }

        // GET: Basket/Details/5
        public ActionResult Details()
        {

            return View();
        }

        // GET: Basket/Create
        public ActionResult Create()
        {
            
            basket = new Basket { userId = "TestId", productId = 1, Quantity = 1 };
            api = new Apicaller();



            client.BaseUrl = new Uri(apiaddress);
            // IRestResponse response;
            var request = new RestRequest("/api/Basket/add/", Method.POST);
            request.AddObject(basket);
            request.AddHeader("Bearer", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ik5rVXlOa001UlRsRlJVRTNOemxGUlVZM01UQTRNelE0TVVFeE5UUXhOa1l3TURJMFJESTJPQSJ9.eyJpc3MiOiJodHRwczovL3RoYW1jby5ldS5hdXRoMC5jb20vIiwic3ViIjoiNWtYV3RxbERBMk02QVBtZjlkaXF1NjdHSjBGdzJRU0lAY2xpZW50cyIsImF1ZCI6IkJhc2tldCIsImlhdCI6MTUxMjQ4NDc2NiwiZXhwIjoxNTEyNTcxMTY2LCJzY29wZSI6ImNyZWF0ZTpiYXNrZXQgcmVhZDpiYXNrZXQiLCJndHkiOiJjbGllbnQtY3JlZGVudGlhbHMifQ.XiTFA3m4ukx6VTgP5khWuuDQcRiF0KmMZ4f7obF_mgdYHlRZsXz9ElILVyjIz-gyklVLG0W0uI3IoT7aT3Y4rR9u1kHgn9ZonpJf5YeWT6N_oiTYRVEvNB9jQdi1XxQ1tAj8AiYnm7q2KKiTtAZtgo3kzPPxh7bxvkSPo15EiHQrqHb1_cKq1S47kZt_-0sn4SIVOvHxDMpX_s-yLRCmc3D6rkZWnIOc4EpDEmRImPGWL6v8so7uOXoQhM7pVlFqEZgtFSI-tcMjZHjCulJJMHk2D19u4Mfw__iOTdoYwOytlDr-LVZUu_qPmHZDQ5BttgGjHOAcl8yI_XliAWC68g");
            //request.AddQueryParameter("userId",payload.userId);
            //request.AddQueryParameter("productId", payload.productId.ToString());
            //request.AddQueryParameter("quantity", payload.Quantity.ToString());

            var response =  client.Execute(request);

            

            return View(response);
        }

        // POST: Basket/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Basket/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Basket/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Basket/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Basket/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}