using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using KathakBooking.Models;
using Microsoft.AspNetCore.Mvc;

namespace KathakBooking.Controllers
{
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

        public IActionResult ClassEnrollmentForm(int id)
        {   
            return View();
        }

        [HttpPost]
        public IActionResult ClassEnrollmentForm(int id,string name,string email)
        {
            Student s=new Student
            {
                Name=name,
                Email=email,
                ClassId=id
            };
            db.Students.Add(s);
            db.SaveChanges();
            return RedirectToAction("EnrollmentConfirmation",new{id=id});
        }

        public IActionResult EnrollmentConfirmation(int id)
        {
            // var studi=db.Classes.Where(c =>c.ClassId==id).FirstOrDefault();
            var studi=db.Classes.Find(id);
            return View(studi);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}