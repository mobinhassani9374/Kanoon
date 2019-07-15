using Kanoon.Data.Context;
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
    }
}
