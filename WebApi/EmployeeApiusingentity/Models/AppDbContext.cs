using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApiusingentity.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApiusingentity.Models
{
    public partial class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }   

        public DbSet<Employee>Employees{get;set;}     
        public DbSet<Department>Departments{get;set;}     
        public DbSet<Designation>Designation{get;set;}     
    }
}