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
            var designationlist=db.Designations;
            return Ok(designationlist);
        }
    }
}