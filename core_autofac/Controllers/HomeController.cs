using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using core_autofac.Service;

namespace core_autofac.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMsgService _msgservice;
        public HomeController(IMsgService msgservice)
        {
            _msgservice = msgservice;
        }
        public IActionResult Index()
        {
            ViewData["msg"] = _msgservice.Html();
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
            return View();
        }
    }
}
