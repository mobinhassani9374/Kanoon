using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanoon.DomainModels.Models.Location;
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

        #region Api
        public IActionResult ApiCreate(LocationCreateModel model)
        {
            return Ok();
        }
        #endregion
    }
}