using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcCodeFirstApp.Data
{
    public class MvcDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string conStr="User Id=sa;password=examlyMssql@123;Database=MvcDB;Persist Security Info=False;Encrypt=False;MultipleActiveResultSets=True";
            options.UseSqlServer(conStr);
        }
        public DbSet<Department>Departments{set;get;}
        public DbSet<Employee>Employees{set;get;}
    }
}