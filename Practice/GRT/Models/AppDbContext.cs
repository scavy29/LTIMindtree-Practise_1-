using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace GRT.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options):base(options)
        {
            
        }       

        public DbSet<EventSpace>EventSpaces {get;set;} 
        public DbSet<Booking>Bookings {get;set;} 
    }
}