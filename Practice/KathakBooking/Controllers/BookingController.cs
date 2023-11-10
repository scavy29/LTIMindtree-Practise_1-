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
    public class BookingController : Controller
    {
        private ApplicationDbContext db;

        public BookingController(ApplicationDbContext context)
        {
            this.db=context;
        }

        public IActionResult Index()
        {
            var list=db.Students;
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            db.Students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ClassEnrollmentForm(int id)
        {
            var list=db.Students;   
            return View(list);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}