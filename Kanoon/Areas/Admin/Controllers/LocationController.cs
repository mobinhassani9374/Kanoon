using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanoon.Data;
using Kanoon.DomainModels.Entities;
using Kanoon.DomainModels.Models.Location;
using Kanoon.Utility;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Kanoon.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LocationController : BaseController<Location>
    {
        public LocationController(BaseRepository<Location> repo) : base(repo)
        {

        }
        public IActionResult Index()
        {
            return View();
        }

        #region Api
        [HttpPost]
        public IActionResult ApiCreate(LocationCreateModel model)
        {
            if (!ModelState.IsValid)
                return Ok(ServiceResult.Error());

            var result = _repo.Create(new Location
            {
                Title = model.Title,
                Members = new List<LocationMember>()
                {
                    new LocationMember()
                    {
                         FullName=model.ManagerFullName,
                         Type= MemberType.Manager,
                         PhoneNumbers=JsonConvert.SerializeObject(model.ManagerPhoneNumbers)
                    }
                }
            });

            return Ok(result);
        }
        #endregion
    }
}