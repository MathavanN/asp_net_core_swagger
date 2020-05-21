using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Test.Models;

namespace Test.Context
{
    public class TestDataContext : IdentityDbContext<ApplicationUser>
    {
        public TestDataContext(DbContextOptions<TestDataContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>()
                .HasData(
                    new Country { Id = 1, CountryName = "Singapore", CountryCode = "SG", DateAdded = DateTime.Now, DateModified = DateTime.Now },
                    new Country { Id = 2, CountryName = "Sri Lanka", CountryCode = "SL", DateAdded = DateTime.Now, DateModified = DateTime.Now }
                );
        }
    }
}
