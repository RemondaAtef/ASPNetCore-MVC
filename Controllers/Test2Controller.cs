using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject2_GP.Controllers
{
    public class Test2Controller : Controller
    {
        [Route("~/Contact")]
        public IActionResult ContactUs()
        {
            return View();
        }

        [Route("~/Gallery")]
        public IActionResult Gallery()
        {
            return View();
        }
    }
}
