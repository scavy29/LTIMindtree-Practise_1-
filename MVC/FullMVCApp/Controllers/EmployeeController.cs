using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FullMVCApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FullMVCApp.Controllers
{
    public class EmployeeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<Department>deptlist = new List<Department>{
                new Department{DepartmentId=1,DepartmentName="Account"},
                new Department{DepartmentId=2,DepartmentName="Finance"},
                new Department{DepartmentId=3,DepartmentName="Tech"},
                new Department{DepartmentId=4,DepartmentName="Human Resource"}
            };
            SelectList sl=new SelectList(deptlist,"DepartmentId","DepartmentName");
            ViewBag.Data=sl;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                ModelState.Clear();
                ViewBag.message="Employee Added";   
            }
            else
            {
                ViewBag.message="Invalid Input";
            }   
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}