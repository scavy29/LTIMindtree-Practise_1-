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
        public IActionResult PostDept(Department department)
        {
            if(ModelState.IsValid)
            {
                repo.AddDepartment(department);
                return Created("Record Added",department);
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

        [HttpPut]
        [Route("EditDept/{id}")]
        public IActionResult PutDept(int id,Department department)
        {
            repo.EditDepartment(department);
            return Ok();   
        }

        [HttpDelete]
        [Route("DeleteDept/{id}")]
        public IActionResult DeleteDept(int id)
        {
            repo.DeleteDepartment(id);
            return Ok();
        }

        //post
        // https://localhost:8080/DepartmentController/auth
        [HttpPost]
        [Route("auth")]
        public string AuthenticateUser(UserData data)
        {
            string token="";
            if(data.Username=="username" && data.Password=="password")
            {
                token = TokenGenerator(data);
            }
            return "lorem ipsum";
        }

        public string TokenGenerator(UserData data)
        {
            var securitykey=new SymmetricSecurityKey()
            return "token";
        }
    }
}