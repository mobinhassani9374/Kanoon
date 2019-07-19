using AutoMapper;
using AutoMapper.QueryableExtensions;
using Kanoon.Data.Context;
using Kanoon.DomainModels.Models.Heiat;
using Kanoon.Utility.Pagination;
using System;
using System.Collections.Generic;
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
            var query = this.AsQueryable();

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
