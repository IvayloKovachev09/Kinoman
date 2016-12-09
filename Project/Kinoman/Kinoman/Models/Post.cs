using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kinoman.Models
{
    public class Post
    {
        public Post()
        {
            this.Date = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]

        public string Title { get; set; }

        [Required]
        public string Body { get; set; }
        public object Date { get; private set; }

        [Required]
        public DateTime date { get; set; }

        public AplicationUser Author { get; set; }
    }
}
