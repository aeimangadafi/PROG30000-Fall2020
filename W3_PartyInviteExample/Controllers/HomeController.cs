using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using W3_PartyInviteExample.Models;

namespace W3_PartyInviteExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //  baseurl  /home /home/index 
        public IActionResult Index()
        {
            return View();
        }

        // /home/privacy 
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveGuestResponse()
        {
            //todo: 1. save the response
            //todo: 2. show thank you page
            return View();
        }


        public IActionResult RsvpForm()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
