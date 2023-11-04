using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewApiProject.Repositories;
using NewApiProject.Models;
using log4net;
using log4net.Config;

namespace NewApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        // EmployeeRepository repo=new EmployeeRepository();
        private readonly ILog _logger;
        private IEmployeeRepository repo;
        public EmployeeController(IEmployeeRepository repository,ILog logger)
        {
            _logger=logger;
            repo=repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var emplist=repo.GetAllEmployees();
            _logger.Info("Employee Data Fetched From Database");
            _logger.Error("This is an error log.");
            return Ok(emplist);
        }

        [HttpPost]
        public IActionResult Post(Employee newemp)
        {
            var emp=repo.AddEmployee(newemp);
            return CreatedAtAction("Get",new {id=emp.EmployeeId},emp);
        }
    }
}
