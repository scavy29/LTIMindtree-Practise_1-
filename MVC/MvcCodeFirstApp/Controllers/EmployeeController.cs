using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using MvcCodeFirstApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcCodeFirstApp.Controllers
{
    // [Route("[controller]")]
    public class EmployeeController : Controller
    {
        MvcDbContext db=new MvcDbContext();
        public IActionResult Index()
        {
            var employeelist=db.Employees.Include("Department");
            return View(employeelist);
        }

        public IActionResult Create()
        {
            var deplist=db.Departments;
            SelectList sl=new SelectList(deplist,"DepartmentId","DepartmentName");
            ViewBag.deptData=sl;
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
                db.Employees.Add(emp);
                db.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            var deplist=db.Departments;
            SelectList sl=new SelectList(deplist,"DepartmentId","DepartmentName");
            ViewBag.deptData=sl;
            
            var emp=db.Employees.Find(id);
            if(emp!=null)
            {
                return View(emp);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            db.Update(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var emp=db.Employees.Find(id);
            if(emp!=null)
            {
                
                db.Employees.Remove(emp);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}