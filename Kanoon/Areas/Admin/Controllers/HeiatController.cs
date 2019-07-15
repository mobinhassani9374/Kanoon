using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanoon.Data.Repositories;
using Kanoon.DomainModels.Models.Heiat;
using Microsoft.AspNetCore.Mvc;

namespace Kanoon.Areas.Admin.Controllers
{
    public class HeiatController : BaseController
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
        public IActionResult ApiCreate(HeiatModel model)
        {
            var result = _heiatRepository.Create(model);
            return Ok(result);
        }
    }
}