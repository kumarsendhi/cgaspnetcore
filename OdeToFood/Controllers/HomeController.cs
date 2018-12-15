﻿using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        public IActionResult Index()
        {
            //return this.BadRequest();
            //return Content("Hello from the HomeController!");

            //var model = new Restaurant { Id = 1, Name = "Kumar's Pizza Place" };
            var model = _restaurantData.GetAll();

            //return new ObjectResult(model);

            return View(model);
            
        }
    }
}
