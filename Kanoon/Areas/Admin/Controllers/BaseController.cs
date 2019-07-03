using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanoon.DomainModels.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Kanoon.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BaseController<TEntity> : Controller where TEntity : BaseEntity
    {

    }
}