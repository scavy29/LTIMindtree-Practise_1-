using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KathakBooking.Controllers
{
    [Route("[controller]")]
    public class BookingController : Controller
    {
        private ApplicationDbContext db;
        public BookingController(ApplicationDbContext context)
        {
            this.db=context;
        }

        public IActionResult ClassEnrollmentForm(int id)
        {
            
        }

        [HttpPost]
        public IActionResult ClassEnrollmentForm(int id,string name,string email)
        {

        }

        public IActionResult EnrollmentConfirmation(int studentid)
        {
            
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