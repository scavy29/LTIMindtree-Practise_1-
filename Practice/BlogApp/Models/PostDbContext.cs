using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Models
{
    public partial class PostDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("User Id=sa;password=examlyMssql@123;Database=PostDB;Multiple Active Result Sets=true;trusted_connection=false;Encrypt=false");
        }

        public virtual DbSet<Post>Posts{get;set;}        
    }
}