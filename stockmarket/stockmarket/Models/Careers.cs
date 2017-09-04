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
        public DateTime PublishDate { get; set; }
        [Required]
        public DateTime DeadLine { get; set; }
        public string PublishedBy { get; set; }
        //[DataType(DataType.ImageUrl)]
        //public string ImageUrl { get; set; }

        public bool IsExpired { get; set; }
    }
    public class News : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }

        public DateTime publishedDate { get; set; }

        //[DataType(DataType.ImageUrl)]
        //public string ImageUrl { get; set; }

        public string addedBy { get; set; }
    }
    public class BaseEntity
    {
        [Key]
       public string Id { get; set; } = Guid.NewGuid().ToString();
      
    }
}
