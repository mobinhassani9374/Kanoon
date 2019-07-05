using System;
using System.Collections.Generic;
using System.Text;

namespace Kanoon.DomainModels.Models.Location
{
    public class LocationUpdateModel
    {
       public int Id { get; set; }
        // [Required(ErrorMessage = "عنوان محله نمی تواند فاقد مقدار باشد")]
        public string Title { get; set; }
        public string ManagerFullName { get; set; }

        public List<string> ManagerPhoneNumbers { get; set; } = new List<string>();
    }
}
