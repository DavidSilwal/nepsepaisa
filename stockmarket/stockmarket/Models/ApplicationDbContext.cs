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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().ToTable("News");

            modelBuilder.Entity<Careers>().ToTable("Careers");
            base.OnModelCreating(modelBuilder);     
        }

        public DbSet<Careers> Careers { get; set; }
        public DbSet<News> News { get; set; }



    }
}
