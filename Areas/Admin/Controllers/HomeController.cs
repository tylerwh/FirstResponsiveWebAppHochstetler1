using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppHochstetler.Models;

namespace FirstResponsiveWebAppHochstetler.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("[area]/[controller]/{id?}")]
        public IActionResult Index()
        {
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        [Route("[area]/[controller]/{id?}")]
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
