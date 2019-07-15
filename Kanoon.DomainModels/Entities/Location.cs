using System;
using System.Collections.Generic;
using System.Text;

namespace Kanoon.DomainModels.Entities
{
    public class Location : BaseEntity
    {
        /// <summary>
        /// عنوان محله
        /// </summary>
        public string Title { get; set; }

        public ICollection<LocationMember> Members { get; set; }

        public ICollection<Heiat> Heiats { get; set; }
    }
}
