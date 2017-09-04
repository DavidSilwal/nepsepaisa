using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockmarket.Models
{
    public class SeedDataHelper
    {
        private readonly ApplicationDbContext _context;
        public SeedDataHelper(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Initialize()
        {
            var news = new News {
                  Title = $"test",
                   Body = $"test",
            };

            if (!_context.News.Any()) {
                _context.News.Add(news);
            }
            var careers = new Careers
            {
                Title = $"test",
                Body = $"test",
            };
            if (!_context.Careers.Any())
            {
                _context.Careers.Add(careers);
            }

        }

    }
}
