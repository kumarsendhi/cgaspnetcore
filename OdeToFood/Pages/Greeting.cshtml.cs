using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Services;

namespace OdeToFood.Pages
{
    public class GreetingModel : PageModel
    {
        private IGreeter _greeter;
        public string currentMessage { get; set; }

        public GreetingModel(IGreeter Greeter)
        {
            _greeter = Greeter;
        }
        public void OnGet()
        {
            currentMessage = _greeter.GetMessageOfTheDay();
        }
    }
}