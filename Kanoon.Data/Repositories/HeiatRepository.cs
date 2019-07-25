using AutoMapper;
using AutoMapper.QueryableExtensions;
using Kanoon.Data.Context;
using Kanoon.DomainModels.Models.Heiat;
using Kanoon.Utility.Pagination;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanoon.Data.Repositories
{
    public class HeiatRepository : BaseRepository<DomainModels.Entities.Heiat>
    {
        public HeiatRepository(AppDbContext context) : base(context)
        {

        }
        public Paginated<HeiatModel> Search(HeiatSearchModel model)
        {
            var query = this
                .AsQueryable()
                .Include(c => c.Location)
                .AsQueryable();

            if (!string.IsNullOrEmpty(model.Day))
            {
                query = query.Where(c => c.WeekDay == model.Day);
            }

            if(model.LocationId.HasValue)
            {
                query = query.Where(c => c.LocationId.Equals(model.LocationId));
            }

            var data = query
                .ProjectTo<HeiatModel>()
                .ToPaginated(new PaginationSearchCritria
                {
                    PageNumber = model.PageNumber,
                    PageSize = model.PageSize
                });

            return data;
        }
    }
}
