using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcViewModelApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcViewModelApp.Models
{
    public class MvcViewModelApp:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string conStr="User Id=sa;password=examlyMssql@123;Database=MvcDB;Persist Security Info=False;Encrypt=False;MultipleActiveResultSets=True";
            options.UseSqlServer(conStr);
        }
        public DbSet<Login>Logins{set;get;}
        public DbSet<Register>Registers{set;get;}
    }
}
