using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KathakBooking.Models;

namespace KathakBooking.Controllers
{
    // [Route("[controller]")]
    public class ClassController : Controller
    {
        private ApplicationDbContext db;
        public ClassController(ApplicationDbContext context)
        {
            this.db=context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AvailableClasses()
        {

        }
        public IActionResult BookedClasses()
        {

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}