using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressTaxi.Controllers
{
    public class LostPropertyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
