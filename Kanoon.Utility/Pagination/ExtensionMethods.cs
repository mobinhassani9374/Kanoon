using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kanoon.Utility.Pagination
{
    public static class ExtensionMethods
    {
        public static Paginated<T> ToPaginated<T>(this IQueryable<T> query, PaginationSearchCritria searchCritria)
        {
            var result = new Paginated<T>();

            result.TotalRows = query.Count();

            query = query
                .Skip((searchCritria.PageNumber - 1) * searchCritria.PageSize)
                .Take(searchCritria.PageSize);

            result.Data = query.ToList();

            result.CurrentPage = searchCritria.PageNumber;

            result.PageSize = searchCritria.PageSize;

            result.TotalPages = result.TotalRows / searchCritria.PageSize;

            if (result.TotalRows % searchCritria.PageSize != 0)
            {
                result.TotalPages++;
            }

            return result;
        }
    }
}
