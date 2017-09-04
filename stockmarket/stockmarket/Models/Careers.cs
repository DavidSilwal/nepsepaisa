using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockmarket.Models
{
    public class Careers : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }

        public DateTime PublishDate { get; set; } = DateTime.Now;
        [Required]
        public DateTime DeadLine { get; set; }
        public string PublishedBy { get; set; } = $"admin";
        //[DataType(DataType.ImageUrl)]
        //public string ImageUrl { get; set; }

        public bool IsExpired { get; set; } = false;
    }
    public class News : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }

        public DateTime publishedDate { get; set; } = DateTime.Now;

        //[DataType(DataType.ImageUrl)]
        //public string ImageUrl { get; set; }

        public string addedBy { get; set; } = $"admin";
    }
    public class BaseEntity
    {
        [Key]
       public string Id { get; set; } = Guid.NewGuid().ToString();
      
    }
}
