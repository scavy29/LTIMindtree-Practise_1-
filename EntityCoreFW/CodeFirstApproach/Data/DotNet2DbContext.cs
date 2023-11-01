using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Data
{
    public partial class DotNet2DbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("User Id=sa;password=examlyMssql@123;server=localhost;Database=DotNet2Db;trusted_connection=False;Persist Security Info=False;MultipleActiveResultSets=true;Encrypt=False");
        }
        public virtual DbSet<Department>? Departments{set;get;}
        public virtual DbSet<Employee>? Employees{set;get;}
    }
}