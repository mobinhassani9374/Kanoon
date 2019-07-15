using System;
using System.Collections.Generic;
using System.Text;

namespace Kanoon.Utility.Pagination
{
    public class Paginated<T>
    {
        public List<T> Data = new List<T>();

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }

        public int TotalPages { get; set; }
    }
}
