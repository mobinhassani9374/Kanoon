﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanoon.Data.Repositories;
using Kanoon.DomainModels.Models.Heiat;
using Kanoon.Utility;
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
            if (model.LocationId == 0)
            {
                return Ok(ServiceResult.Error("محله را انتخاب نکرده اید"));
            }

            if(string.IsNullOrEmpty(model.Name))
            {
                return Ok(ServiceResult.Error("نام هییٔت نمی تواند فاقد مقدار باشد"));
            }

            var result = _heiatRepository.Create(model);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult ApiGet(HeiatSearchModel model)
        {
            var data = _heiatRepository.Search(model);

            return Ok(data);
        }

        [HttpPost]
        public IActionResult ApiEdit(HeiatModel model)
        {
            var result = _heiatRepository.Update(model.Id, model);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult ApiDelete(int id)
        {
            var result = _heiatRepository.Delete(id);
            return Ok(result);
        }
    }
}