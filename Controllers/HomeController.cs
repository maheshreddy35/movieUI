using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCMovie.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Splash()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Mrating()
        {
            return RedirectToAction("Mrating", "Rate");
        }
        public IActionResult AllMovies()
        {
            return RedirectToAction("AllMovies", "Movie");
        }
        public IActionResult Details()
        {
            return RedirectToAction("Details", "Register");
        }
        public IActionResult MyList()
        {
            return RedirectToAction("MyList", "Movie");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
