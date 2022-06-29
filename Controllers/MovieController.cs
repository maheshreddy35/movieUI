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
    public class MovieController : Controller
    {
        public async Task<IActionResult> AllMoviesAsync()
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
        public async Task<IActionResult> MovieBooking(int id)
        {
            List<Movies> Info = new List<Movies>();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  
                HttpResponseMessage Res = await client.GetAsync("https://localhost:44345/api/Cinemas");
                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result; 
                    Info = JsonConvert.DeserializeObject<List<Movies>>(EmpResponse);
                }
               
                Movies m = Info.Where(c => c.Id == id).FirstOrDefault();
                Booking b = new Booking();
                b.Id = m.Id;
                b.Movie = m.Movie;
                b.Price = (double)m.Price;
                b.Theater = m.Theatername;
                b.Phno = HttpContext.Session.GetString("phno");
                
                List<Bank> info = new List<Bank>();
                Bank bank = new Bank();
                using (var client1 = new HttpClient())
                {
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage Res1 = await client.GetAsync("https://localhost:44323/api/BankAccounts");
                    if (Res1.IsSuccessStatusCode)
                    {
                        var Response = Res1.Content.ReadAsStringAsync().Result;
                        info = JsonConvert.DeserializeObject<List<Bank>>(Response);
                    }
                    bank = info.Where(c => c.phno == b.Phno).Select(i=>i).FirstOrDefault();
                }
                if (bank == null)
                {
                    return RedirectToAction("AddBank", "Login");
                }

                return View(b);
            }
        }
        [HttpPost]
        public async Task<IActionResult> MovieBooking(Booking b)
        {
            if (b.Price < 0)
            {
                HttpContext.Session.SetString("error", "Please enter valid amount");
                return View();
            }
            if (int.Parse(b.NoOfTickets) <=0)
            {
                HttpContext.Session.SetString("error", "Please enter valid number of Tickets");
                return View();
            }
            HttpContext.Session.Remove("error");
            Booking rec = new Booking();
            b.Price = b.Price * int.Parse(b.NoOfTickets);
            
            using (var httpClient = new HttpClient())
            {
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(b), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:44345/api/Bookings" , content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                }
            }
            return RedirectToAction("MyList");
        }
        public async Task<IActionResult> MyList()
        {
            List<Booking> r = new List<Booking>();
           
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44345/api/Bookings"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    r = JsonConvert.DeserializeObject<List<Booking>>(apiResponse);
                }
            }
            string ph = HttpContext.Session.GetString("phno");
            r = r.Where(c => c.Phno == ph).ToList();
            //rate = r.Where(c => c.movie == id).FirstOrDefault();
            //HttpContext.Session.SetString("rate", rate.rating.ToString());
            return View(r);
        }
        [HttpGet]
        public async Task<ActionResult> RemoveMovie(int id)
        {
            List<Booking> info = new List<Booking>();
            Booking r = new Booking();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44345/api/Bookings"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    info = JsonConvert.DeserializeObject<List<Booking>>(apiResponse);
                }
            }
            r = info.Where(c => c.Id == id).FirstOrDefault();
            return View(r);
        }
        [HttpPost]
        [ActionName("RemoveMovie")]
        public async Task<ActionResult> RemoveMovie(Booking b)
        {

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44345/api/Bookings/" + b.Id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction("MyList");


        }
    }
}
