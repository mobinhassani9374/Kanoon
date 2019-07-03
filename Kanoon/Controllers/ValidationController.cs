using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DNTPersianUtils.Core;

namespace Kanoon.Controllers
{
    public class ValidationController : Controller
    {
        public IActionResult PhoneNumber(string id)
        {
            var isValid = false;

            if (!string.IsNullOrEmpty(id))
                isValid = id.IsValidIranianMobileNumber();

            return Ok(isValid);
        }
    }
}