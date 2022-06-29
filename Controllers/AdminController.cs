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
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddTheater()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddTheater(Movies theater)
        {
            if (theater.Price <= 0)
            {
                HttpContext.Session.SetString("error", "Please enter valid amount");
                return View();
            }
            HttpContext.Session.Remove("error" );
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(theater), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44345/api/Cinemas", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                }
            }
            return RedirectToAction("Details");
        }
        public IActionResult AddMovie()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddMovie(Ratings r)
        {
            if (r.rating <= 0)
            {
                HttpContext.Session.SetString("error", "Please enter valid rating");
                return View();
            }
            HttpContext.Session.Remove("error" );
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(r), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44382/api/Movieratings", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                }
            }
            return RedirectToAction("MovieDetails");
        }
        public async Task<IActionResult> Details()
        {
            List<Movies> Info = new List<Movies>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("https://localhost:44345/api/Cinemas");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    Info = JsonConvert.DeserializeObject<List<Movies>>(EmpResponse);

                }
                //returning the employee list to view  
                return View(Info);
            }
        }
        public async Task<IActionResult> MovieDetails()
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
            //rate = r.Where(c => c.movie == id).FirstOrDefault();
            //HttpContext.Session.SetString("rate", rate.rating.ToString());
            return View(r);
        }

        public async Task<IActionResult> AllUsers()
        {

            List<Register> Info = new List<Register>();
            Register reg = new Register();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("https://localhost:44353/api/Registers");
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    Info = JsonConvert.DeserializeObject<List<Register>>(EmpResponse);

                }

                //returning the employee list to view  
                return View(Info);
            }

        }
        [HttpGet]
        public async Task<ActionResult> DeleteMovie(string id)
        {
            List<Ratings> info = new List<Ratings>();
            Ratings r = new Ratings();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44382/api/Movieratings"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    info = JsonConvert.DeserializeObject<List<Ratings>>(apiResponse);
                }
            }
            r = info.Where(c => c.movie == id).FirstOrDefault();
            return View(r);
        }
        [HttpPost]
        [ActionName("DeleteMovie")]
        public async Task<ActionResult> DeleteMovie(Ratings m)
        {

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44382/api/Movieratings/" + m.movie))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction("MovieDetails");


        }
        [HttpGet]
        public async Task<ActionResult> DeleteTheater(int id)
        {
            List<Movies> info = new List<Movies>();
            Movies r = new Movies();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44345/api/Cinemas"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    info = JsonConvert.DeserializeObject<List<Movies>>(apiResponse);
                }
            }
            r = info.Where(c => c.Id == id).FirstOrDefault();
            return View(r);
        }
        [HttpPost]
        [ActionName("DeleteTheater")]
        public async Task<ActionResult> DeleteTheater(Movies m)
        {

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44345/api/Cinemas/" + m.Id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction("Details");


        }
        [HttpGet]
        public async Task<IActionResult> EditTheater(int id)
        {
            Movies m = new Movies();
            List<Movies> bank = new List<Movies>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44345/api/Cinemas"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    bank = JsonConvert.DeserializeObject<List<Movies>>(apiResponse);
                }
            }
            m = bank.Where(c => c.Id == id).FirstOrDefault();
            return View(m);
        }
        [HttpPost]
        public async Task<IActionResult> EditTheater(Movies b)
        {
            if (b.Price <= 0)
            {
                HttpContext.Session.SetString("error", "Please enter valid amount");
                return View();
            }
            HttpContext.Session.Remove("error");
            Movies receivedemp = new Movies();

            using (var httpClient = new HttpClient())
            {

                int id = b.Id;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(b), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:44345/api/Cinemas/" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    receivedemp = JsonConvert.DeserializeObject<Movies>(apiResponse);
                }
            }
            return RedirectToAction("Details");
        }
    }
}
