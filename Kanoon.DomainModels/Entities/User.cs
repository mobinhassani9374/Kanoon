using System;
using System.Collections.Generic;
using System.Text;

namespace Kanoon.DomainModels.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}
