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
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Register reg)
        {
            if(reg.Phoneno=="11" && reg.Password == "aa")
            {
                HttpContext.Session.SetString("phno", reg.Phoneno);
                HttpContext.Session.SetString("name", "Admin");
                HttpContext.Session.Remove("error");
                return RedirectToAction("Index", "Admin");
            }
            
            List<Register> Info = new List<Register>();
            Register r = new Register();
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
                r = Info.Where(c => c.Phoneno == reg.Phoneno && c.Password == reg.Password).FirstOrDefault();
                if (r == null)
                {
                    HttpContext.Session.SetString("error", "Invalid Login Credentials!");
                    return View();
                }
               
                HttpContext.Session.SetString("phno", reg.Phoneno);
                HttpContext.Session.SetString("name", r.Name);
                return RedirectToAction("Splash","Home");
            }
        }
       
        public async Task<IActionResult> AddBank()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBank(Bank b)
        {
            string ph = HttpContext.Session.GetString("phno");
            if (ph != b.phno)
            {
                HttpContext.Session.SetString("error", "Please enter correct Mobile number");
                return View();
            }
            string k=null;
            HttpContext.Session.Remove("error");
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(b), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44323/api/BankAccounts", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                }
            }
            return RedirectToAction("AllMovies","Movie");
        }
        public async Task<IActionResult> logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
