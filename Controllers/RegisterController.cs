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
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IndexAsync(Register reg)
        {
            HttpContext.Session.SetString("phno", reg.Phoneno);
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(reg), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44353/api/Registers", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                }
            }
            return RedirectToAction("Splash","Home");
        }
        [HttpGet]
        public async Task<IActionResult> editdetails(string id)
        {
            id = HttpContext.Session.GetString("phno");
            Register reg = new Register();
            List<Register> r = new List<Register>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44353/api/Registers"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    r = JsonConvert.DeserializeObject<List<Register>>(apiResponse);
                }
            }
            reg = r.Where(c => c.Phoneno == id).FirstOrDefault();
            return View(reg);
        }
        [HttpPost]
        public async Task<IActionResult> editdetails(Register reg)
        {
            Register receivedemp = new Register();

            using (var httpClient = new HttpClient())
            {

                string id = reg.Phoneno;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(reg), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:44353/api/Registers/" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    receivedemp = JsonConvert.DeserializeObject<Register>(apiResponse);
                }
            }
            return RedirectToAction("Details");
        }
        public async Task<IActionResult> Details(string ph)
        {
            ph = HttpContext.Session.GetString("phno");
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
                reg = Info.Where(c => c.Phoneno == ph).FirstOrDefault();
                //returning the employee list to view  
                return View(reg);
            }


        }

    }
}
