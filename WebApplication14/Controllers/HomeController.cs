using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Home#Index";
            ViewBag.Message = "YOU HAVE REACHED THE HOME PAGE!!";
            return View();
        }

        public IActionResult OtherPage()
        {
            ViewBag.Title = "Home#OtherPage";
            ViewBag.Message = "YOU HAVE REACHED THE OTHER PAGE!!";
            return View();
        }
    }
}
