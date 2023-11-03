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
    public class DesignationController : ControllerBase
    {
        private AppDbContext db;
        public DesignationController(AppDbContext context)
        {
            this.db=context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Designations);
        }

        [HttpPost]
        public IActionResult Post(Designation d)
        {
            db.Designations.Add(d);
            db.SaveChanges();
            return Ok(d);
        }

        [HttpPost]
        [Route ("{Id}")]
        public IActionResult Delete(int id,Designation d)
        {
            var designlist=db.Designations.Find(id);
            if(designlist!=null)
            {
                db.Remove(d);
                db.SaveChanges();
                return Ok(d);
            }
            else
                return NotFound();
        }
    }
}