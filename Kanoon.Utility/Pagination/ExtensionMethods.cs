using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kanoon.Utility.Pagination
{
    public static class ExtensionMethods
    {
        public static IQueryable<T> ToPaginated<T>(this IQueryable<T> query, PaginationSearchCritria searchCritria)
        {
            query = query
                 .Skip((searchCritria.PageNumber - 1) * searchCritria.PageSize)
                 .Take(searchCritria.PageNumber);

            return query;
        }
    }
}
