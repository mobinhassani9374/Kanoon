using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Kanoon.Controllers
{
    public class HeiatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}