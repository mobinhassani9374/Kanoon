using Kanoon.Data.Context;
using Kanoon.DomainModels.Entities;
using Kanoon.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanoon.Data
{
    public class Repository
    {
        private readonly AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;
        }
        
    }
}
