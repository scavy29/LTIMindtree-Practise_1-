using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewApiProject.Models;
using Microsoft.EntityFrameworkCore;

namespace NewApiProject.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Employee>Employees{get;set;}
        public DbSet<Department>Departments{get;set;}
    }
}