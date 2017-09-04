using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Core.Domains;

namespace WebApplication
{
    public class WebApplicationDbContext :DbContext
    {
        public WebApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public WebApplicationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }

        public DbSet<News> News { get; set; }
        public DbSet<Careers> Careers { get; set; }
       
    }
}
