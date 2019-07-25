﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kanoon.DomainModels.Models.Heiat
{
    public class HeiatSearchModel
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public string Day { get; set; }

        public int? LocationId { get; set; }
    }
}
