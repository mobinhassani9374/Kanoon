using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Design;
using System.ComponentModel.DataAnnotations;

namespace Kanoon.DomainModels.Entities
{
    public class LocationMember : BaseEntity
    {
        public MemberType Type { get; set; }

        public string FullName { get; set; }

        public string PhoneNumbers { get; set; }

        public Location Location { get; set; }

        public int LocationId { get; set; }
    }
    public enum MemberType
    {
        [Display(Name = "مسیول")]
        Manager = 1,

        [Display(Name = "جانشین")]
        Successor = 2
    }
}
