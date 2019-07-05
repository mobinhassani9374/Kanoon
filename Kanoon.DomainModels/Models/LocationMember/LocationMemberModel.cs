using System;
using System.Collections.Generic;
using System.Text;

namespace Kanoon.DomainModels.Models.LocationMember
{
    public class LocationMemberModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<string> PhoneNumbers { get; set; } = new List<string>();
        public int LocationId { get; set; }
    }
}
