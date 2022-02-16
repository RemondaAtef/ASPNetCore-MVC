using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject2_GP.Controllers
{
    public class Test1Controller : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        [Route("~/About")]
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
