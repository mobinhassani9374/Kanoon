using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanoon.Data;
using Kanoon.DomainModels.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kanoon.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BaseController : Controller
    {

    }
}