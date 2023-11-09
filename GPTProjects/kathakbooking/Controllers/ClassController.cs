using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using kathakbooking.Models;
using Microsoft.EntityFrameworkCore;

namespace kathakbooking.Controllers
{
    // [Route("[controller]")]
    public class ClassController : Controller
    {
        private ApplicationDbContext db;

        public ClassController(ApplicationDbContext context)
        {
            this.db=context;
        }

        public IActionResult AvailableClasses()
    {
        // Get classes that are available (not fully booked)
        var availableClasses = db.Classes
            .Where(c => c.Students.Count < c.Capacity)
            .ToList();

        return View(availableClasses);
    }

    public IActionResult BookedClasses()
    {
        // Get classes that are fully booked
        var bookedClasses = db.Classes
            .Where(c => c.Students.Count >= c.Capacity)
            .ToList();

        return View(bookedClasses);
    }
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}