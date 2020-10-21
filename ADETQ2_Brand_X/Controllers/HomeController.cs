using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ADETQ2_Brand_X.Models;

namespace ADETQ2_Brand_X.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult home()
        {
            return View(Repository.Response);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Privacy(list response)
        {
            if (ModelState.IsValid)
            {
                Repository.addResponse(response);
                return View("Finish", response);
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
