using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppHochstetler.Models;

namespace FirstResponsiveWebAppHochstetler.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Message = "";
            return View();
        }

        [HttpPost]
        [Route("[controller]")]
        public IActionResult Index(Person model)
        {
            if (ModelState.IsValid)
            {
                int age = (int)model.AgeToday();
                ViewBag.Message = model.FirstName + ", you are " + age + " years old today.";
            }
            else
            {
                ViewBag.Message = "";
            }
            
            return View(model);
        }

        [Route("[controller]/[action]")]
        public IActionResult About()
        {
            return View();
        }

        [Route("[controller]/[action]")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("[controller]/[action]")]
        public IActionResult More()
        {
            return View();
        }
    }
}
