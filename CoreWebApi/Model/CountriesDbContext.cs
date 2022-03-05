using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Model
{
    public class CountriesDbContext : DbContext
    {
        public DbSet<CountryModel> Countries { get; set; }
        public CountriesDbContext(DbContextOptions<CountriesDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryModel>().ToTable("Countries");
        }
    }
}
