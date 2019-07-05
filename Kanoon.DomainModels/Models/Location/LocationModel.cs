using System;
using System.Collections.Generic;
using System.Text;

namespace Kanoon.DomainModels.Models.Location
{
    public class LocationModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string ManagerFullName { get; set; }

        public List<string> ManagerPhoneNumbers { get; set; } = new List<string>();

        public int CountSuccessor { get; set; }
    }
}
