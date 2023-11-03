using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApiusingentity.Models
{
    public class AppDbContext:DbContext
    {
        public AppContext(DbContextOptions<AppDbContext> options)
        {
            
        }   
        public virtual DbSet<Employee>Employees{get;set;}     
        public virtual DbSet<Department>Departments{get;set;}     
    }
}