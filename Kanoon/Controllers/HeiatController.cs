using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanoon.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Kanoon.Controllers
{
    public class HeiatController : Controller
    {
        private readonly HeiatRepository _heiatRepository;
        public HeiatController(HeiatRepository heiatRepository)
        {
            _heiatRepository = heiatRepository;
        }

        [HttpPost]
        public IActionResult Search()
        {
            return View();
        }
    }
}