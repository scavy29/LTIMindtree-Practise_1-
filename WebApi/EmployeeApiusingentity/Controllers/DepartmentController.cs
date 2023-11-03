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

        [HttpPost]
        public IActionResult Post(Department d)
        {
                db.Add(d);
                db.SaveChanges();
                return Ok(d);
            
        }
    }
}

