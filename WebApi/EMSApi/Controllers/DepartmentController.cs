using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using EMSApi.Models;

namespace EMSApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        IDept repo;
        public DepartmentController(IDept _repo)
        {
            this.repo=_repo;
        }   

        [HttpGet]
        [Route("ListDept")]
        public IActionResult GetDept()
        {
            var data=repo.GetDepartments();
            return Ok(data);
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult PostDept(Department dept)
        {
            if(ModelState.IsValid)
            {
                repo.AddDepartment(dept);
                return Created("Record Added",dept);
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("ListDept/{id}")]
        public IActionResult GetDept(int id)
        {
            var data=repo.FindDept(id);
            return Ok(data);
        }
    }
}