using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanoon.Data;
using Kanoon.DomainModels.Entities;
using Kanoon.DomainModels.Models.Location;
using Kanoon.DomainModels.Models.LocationMember;
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


                var successor = c.Members.Where(i => i.Type == MemberType.Successor).ToList();

                successor.ForEach(i =>
                {
                    locationModel.Successor.Add(new LocationMemberModel
                    {
                        FullName = i.FullName,
                        Id = i.Id,
                        LocationId = i.LocationId,
                        PhoneNumbers = JsonConvert.DeserializeObject<List<string>>(i.PhoneNumbers)
                    });
                });

                model.Add(locationModel);
            });


            return Ok(model);
        }

        [HttpPost]
        public IActionResult ApiEdit(LocationUpdateModel model)
        {
            if (!ModelState.IsValid)
                return Ok(ServiceResult.Error(ModelState));

            // update location
            var location = _repo.Find(model.Id);

            if (location == null)
                return Ok(ServiceResult.Error("شناسه ارسال شده فاقد اعتبار است"));

            location.Title = model.Title;

            var updateResult = _repo.Update(location);

            // update manager of location
            var manager = _repo.AsQueryable<LocationMember>()
                  .Where(c => c.Type == MemberType.Manager && c.LocationId == model.Id)
                  .FirstOrDefault();

            if (manager != null) _repo.Delete<LocationMember>(manager);

            _repo.Create<LocationMember>(new LocationMember()
            {
                FullName = model.ManagerFullName,
                LocationId = model.Id,
                Type = MemberType.Manager,
                PhoneNumbers = JsonConvert.SerializeObject(model.ManagerPhoneNumbers)
            });

            return Ok(ServiceResult.Okay());

        }

        public IActionResult ApiDelete(int id)
        {
            var location = _repo.Find(id);
            if (location == null) return Ok(ServiceResult.Error("شناسه ارسال شده فاقد اعتبار است"));
            var result = _repo.Delete(location);

            var members = _repo
                .AsQueryable<LocationMember>()
                .Where(c => c.LocationId == id)
                .ToList();

            _repo.DeleteAll<LocationMember>(members);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult ApiCreateSuccessor(LocationMemberCreateModel model)
        {
            if (!ModelState.IsValid)
                return Ok(ServiceResult.Error(ModelState));

            var location = _repo.Find(model.LocationId);

            if (location == null) return Ok(ServiceResult.Error("شناسه ارسال شده فاقد اعتبار است"));

            var result = _repo.Create<LocationMember>(new LocationMember
            {
                FullName = model.FullName,
                LocationId = model.LocationId,
                PhoneNumbers = JsonConvert.SerializeObject(model.PhoneNumbers),
                Type = MemberType.Successor
            });

            return Ok(result);
        }
        #endregion
    }
}