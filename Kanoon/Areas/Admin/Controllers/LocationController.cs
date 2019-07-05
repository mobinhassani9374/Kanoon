using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanoon.Data;
using Kanoon.DomainModels.Entities;
using Kanoon.DomainModels.Models.Location;
using Kanoon.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                return Ok(ServiceResult.Error(ModelState));

            var location = new Location
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
            };

            var result = _repo.Create(location);

            return Ok(result);
        }

        public IActionResult ApiGet()
        {
            var data = _repo
                .AsQueryable()
                .Include(c => c.Members)
                .ToList();

            var model = new List<LocationModel>();

            data.ForEach(c =>
            {
                var locationModel = new LocationModel();

                locationModel.Id = c.Id;

                locationModel.Title = c.Title;

                var manger = c.Members.FirstOrDefault(i => i.Type == MemberType.Manager);

                locationModel.ManagerFullName = manger?.FullName;

                if (string.IsNullOrEmpty(manger?.PhoneNumbers))
                {
                    locationModel.ManagerPhoneNumbers = new List<string>();
                }
                else
                {
                    locationModel.ManagerPhoneNumbers = JsonConvert
                    .DeserializeObject<List<string>>(manger?.PhoneNumbers);
                }

                locationModel.CountSuccessor = c.Members.Where(i => i.Type == MemberType.Successor).Count();

                model.Add(locationModel);
            });


            return Ok(model);
        }
        #endregion
    }
}