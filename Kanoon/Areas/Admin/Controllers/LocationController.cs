using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Kanoon.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}