using System;
using System.Collections.Generic;
using System.Text;
using Kanoon.Utility;
using Microsoft.EntityFrameworkCore;

namespace Kanoon.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public ServiceResult Save()
        {
            if (this.SaveChanges() > 0) return ServiceResult.Okay();
            return ServiceResult.Error();
        }
    }
}
