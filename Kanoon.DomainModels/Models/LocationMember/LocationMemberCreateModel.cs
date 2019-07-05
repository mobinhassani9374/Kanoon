using System;
using System.Collections.Generic;
using System.Text;

namespace Kanoon.DomainModels.Models.LocationMember
{
    public class LocationMemberCreateModel
    {
        public int LocationId { get; set; }

        public string FullName { get; set; }

        public List<string> PhoneNumbers { get; set; } = new List<string>();
    }
}
