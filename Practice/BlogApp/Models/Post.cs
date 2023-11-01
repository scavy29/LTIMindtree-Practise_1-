using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class Post
    {
        // [HasNoKey]
        public int Id{set;get;}
        public string? Title{set;get;}
        public string? Content{set;get;}
        public string? Author{set;get;}
        public DateTime PublishDate{set;get;}
    }
}