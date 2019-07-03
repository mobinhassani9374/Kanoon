using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanoon.Data;
using Kanoon.DomainModels.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Kanoon.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BaseController<TEntity> : Controller where TEntity : BaseEntity
    {
        protected readonly BaseRepository<TEntity> _repo;
        public BaseController(BaseRepository<TEntity> repo)
        {
            _repo = repo;
        }
    }
}