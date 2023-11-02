using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class Post
    {
        // [HasNoKey]
        public int Id{set;get;}

        [Required]
        public string? Title{set;get;}

        [Required]
        [MinLength(10)]
        public string? Content{set;get;}
        public string? Author{set;get;}
        public DateTime PublishDate{set;get;}
    }
}