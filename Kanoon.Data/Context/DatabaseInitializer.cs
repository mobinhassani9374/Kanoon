using Kanoon.DomainModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanoon.Data.Context
{
    public static class DatabaseInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.Add(new User
                {
                    FullName = "مبین حسنی",
                    IsAdmin = true,
                    Password = "123456",
                    UserName = "mobin"
                });

                context.Users.Add(new User
                {
                    FullName = "مهدی حسنی",
                    IsAdmin = true,
                    Password = "123456",
                    UserName = "mahdi"
                });

                context.Save();
            }
        }
    }
}
