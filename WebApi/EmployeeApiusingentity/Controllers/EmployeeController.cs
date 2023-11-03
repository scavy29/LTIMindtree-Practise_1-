using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApiusingentity.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApiusingentity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private AppDbContext db;
        public EmployeeController(AppDbContext context)
        {
            this.db=context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Employees);
        }

        [HttpPost]
        public IActionResult Post(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
            // return Ok(emp);
            return CreatedAtAction("Get",new{id=emp.EmployeeId},emp);
        } 
    }
}