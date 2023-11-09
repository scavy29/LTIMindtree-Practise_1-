using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace kathakbooking.Models
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
    public DbSet<Class> Classes { get; set; }
    public DbSet<Student> Students { get; set; }
    }
}