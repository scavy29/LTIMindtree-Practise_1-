using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeApiusingentity.Models;

namespace EmployeeApiusingentity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        
        private AppDbContext db;
        public DepartmentController(AppDbContext context)
        {
            this.db=context;
        }   
        
        [HttpGet]
        public IActionResult Get()
        {
            var Departmentlist=db.Departments;
            return Ok(Departmentlist);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult Get(int id)
        {
            var d1=db.Departments.FirstOrDefault(d=>d.DepartmentId==id);
            if(d1!=null)
                return Ok(d1);
            else
                return NotFound();
        }

        [HttpPost]
        public IActionResult Post(Department d)
        {
                db.Add(d);
                db.SaveChanges();
                return Ok(d);
        }

        [HttpPost]
        [Route ("{Id}")]
        public IActionResult Delete(int id)
        {
            var deptlist=db.Departments.Find(id);
            if(deptlist!=null)
            {
                db.Remove(deptlist);
                db.SaveChanges();
                return Ok(deptlist);
            }
            else
                return NotFound();
        }
    }
}


