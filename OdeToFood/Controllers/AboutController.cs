using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    [Route("about")]
    public class AboutController
    {
        [Route("")]
        public string phone()
        {
            return "00189898989";
        }

        [Route("address")]
        public string address()
        {
            return "USA";
        }
    }
}
