using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCMovie.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MVCMovie.Controllers
{
    public class RateController : Controller
    {
        public async Task<IActionResult> Mrating()
        {
            List<Ratings> Info = new List<Ratings>();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("https://localhost:44382/api/Movieratings");
                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    Info = JsonConvert.DeserializeObject<List<Ratings>>(EmpResponse);

                }
                return View(Info);
            }
        }
        public async Task<IActionResult> Addrating(string id)
        { 
            List<Ratings> r = new List<Ratings>();
            Ratings rate = new Ratings();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44382/api/Movieratings"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    r = JsonConvert.DeserializeObject<List<Ratings>>(apiResponse);
                }
            }
            rate = r.Where(c=>c.movie==id).FirstOrDefault();
            HttpContext.Session.SetString("rate", rate.rating.ToString());
            return View(rate);
        }
        [HttpPost]
        public async Task<IActionResult> Addrating(Ratings rate)
        {
            if (rate.rating < 0)
            {
                HttpContext.Session.SetString("error", "Please enter valid rating");
                return View();
            }
            HttpContext.Session.Remove("error");
            Ratings receivedemp = new Ratings();
            float r = float.Parse(HttpContext.Session.GetString("rate"));
            //rate.rating = 4.0f;
            using (var httpClient = new HttpClient())
            {

                string movie = rate.movie;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(rate), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44382/api/Movieratings",content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    receivedemp = JsonConvert.DeserializeObject<Ratings>(apiResponse);
                }
            }
            return RedirectToAction("Mrating");
        }
        public async Task<IActionResult> Details(string id)
        {
            List<Ratings> r = new List<Ratings>();
            Ratings rate = new Ratings();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44382/api/Movieratings"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    r = JsonConvert.DeserializeObject<List<Ratings>>(apiResponse);
                }
            }
            rate = r.Where(c => c.movie == id).FirstOrDefault();
            HttpContext.Session.SetString("rate", rate.rating.ToString());
            return View(rate);
        }

    }
}
