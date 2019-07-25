using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanoon.Data.Repositories;
using Kanoon.DomainModels.Models.Heiat;
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

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(HeiatSearchModel model)
        {
            System.Threading.Thread.Sleep(5000);
            var data = _heiatRepository.Search(model);
            return Ok(data);
        }
    }
}