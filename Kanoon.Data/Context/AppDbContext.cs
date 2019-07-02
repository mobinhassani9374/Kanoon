using System;
using System.Collections.Generic;
using System.Text;
using Kanoon.DomainModels.Entities;
using Kanoon.Utility;
using Microsoft.EntityFrameworkCore;

namespace Kanoon.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Location> Locations { get; set; }

        public DbSet<LocationMember> LocationMembers { get; set; }

        public ServiceResult Save()
        {
            if (this.SaveChanges() > 0) return ServiceResult.Okay();
            return ServiceResult.Error();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // location
            modelBuilder
                .Entity<Location>()
                .Property(c => c.Title)
                .HasMaxLength(200);

            modelBuilder.Entity<Location>()
                .HasMany(c => c.Members)
                .WithOne(c => c.Location)
                .HasForeignKey(c => c.LocationId)
                .OnDelete(DeleteBehavior
                .Cascade);

            // locationMember
            modelBuilder.Entity<LocationMember>()
                .Property(c => c.FullName)
                .HasMaxLength(200);
        }
    }
}
