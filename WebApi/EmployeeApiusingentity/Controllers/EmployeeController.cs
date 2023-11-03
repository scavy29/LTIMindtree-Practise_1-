using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApiusingentity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            //Normal .Include gives an error since it runs in a loop and serialization error takes place
            var employeelist=db.Employees.Include("Department").Include("Designation").
                                                        Select(e=> new{
                                                            e.EmployeeId,
                                                            e.EmployeeName,
                                                            DeptName=e.Department.DeptName,
                                                            DesignationName=e.Designation.DesignationName,
                                                            e.Salary,
                                                        }).ToList();
            return Ok(employeelist);
        }

        [HttpPost]
        public IActionResult Post(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
            // return Ok(emp);
            return CreatedAtAction("Get",new{id=emp.EmployeeId},emp);
        } 

        [Route ("{Id}")]
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            var delist=db.Employees.Find(Id);
            if(delist!=null)
            {
                db.Remove(delist);
                db.SaveChanges();
                return Ok();
            }
            else
                return NotFound();
        }

        [Route ("{Id}")]
        [HttpPut]
        public IActionResult Put(int id,Employee emp)
        {
            var elist=db.Employees.Find(id);
            if(elist!=null)
            {
                db.Update(emp);
                db.SaveChanges();
                return Ok(emp);
            }
            else
                return NotFound();
        }
    }
}