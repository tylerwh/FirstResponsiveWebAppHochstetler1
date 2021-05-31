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
    }
}
