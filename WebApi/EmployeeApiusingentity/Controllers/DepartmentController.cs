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
        
        public IActionResult 
    }
}