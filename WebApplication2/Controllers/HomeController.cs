using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Localization;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IStringLocalizer<HomeController> _localizer;
        //private ILogger _logger;
        public HomeController(){ //IStringLocalizer<HomeController> localizer) {
            //_localizer = localizer;
            //_logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Number = 2.2M;
            //List<string> emptyList = new List<string>();
            //int elementAt = 3;
            //try
            //{

            //    var element3 = emptyList[elementAt];
            //}
            //catch (Exception ex)
            //{
            //    _logger.LogError(ex, "Something went wrong while fetching element at index {elementIndex}", elementAt);
            //}

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
