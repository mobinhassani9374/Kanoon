using Kanoon.Data.Context;
using Kanoon.DomainModels.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanoon.Data.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(AppDbContext context):base(context)
        {

        }
    }
}
