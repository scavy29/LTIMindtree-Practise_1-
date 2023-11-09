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
            return View();   
        }

        [HttpPost]
        public IActionResult ClassEnrollmentForm(int id,string name,string email)
        {
            Student s=new Student();
            db.Students.Add(s);
            db.SaveChanges();
            return RedirectToAction("EnrollmentConfirmation");
        }

        // public IActionResult EnrollmentConfirmation(int studentid)
        // {

        // }

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