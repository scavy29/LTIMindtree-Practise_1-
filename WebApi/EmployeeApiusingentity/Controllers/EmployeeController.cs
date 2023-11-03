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
        public EmployeeController(AppContext context)
        {
            this.db=context;
        }   
    }
}