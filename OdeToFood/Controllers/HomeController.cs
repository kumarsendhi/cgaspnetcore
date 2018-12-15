using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return this.BadRequest();
            //return Content("Hello from the HomeController!");

            var model = new Restaurant { Id = 1, Name = "Kumar's Pizza Place" };

            return new ObjectResult(model);
            
        }
    }
}
