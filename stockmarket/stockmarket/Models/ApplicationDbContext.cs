using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockmarket.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public ApplicationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().ToTable("News");

            modelBuilder.Entity<Careers>().ToTable("Careers");
            modelBuilder.Entity<Company>().ToTable("stock_api_stockdata");

            base.OnModelCreating(modelBuilder);     
        }

        public DbSet<Careers> Careers { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Company> Company { get; set; }




    }
}
