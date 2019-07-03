using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanoon.Data;
using Kanoon.DomainModels.Entities;
using Kanoon.DomainModels.Models.Location;
using Microsoft.AspNetCore.Mvc;

namespace Kanoon.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LocationController : Controller
    {
        private readonly BaseRepository<Location> _repo;
        public LocationController(BaseRepository<Location> repo)
        {
            _repo = repo;
        }
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