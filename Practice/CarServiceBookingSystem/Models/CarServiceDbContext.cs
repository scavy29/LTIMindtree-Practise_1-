using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarServiceBookingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CarServiceBookingSystem.Models
{
    public class CarServiceDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("User Id=sa;password=examlyMssql@123;Database=CarServiceDB;Multiple Active Result Sets=True;trusted_connection=False;Encrypt=False");
        }       
        public virtual DbSet<CarService> CarServices {get;set;} 
    }
}