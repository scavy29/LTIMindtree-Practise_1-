using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using EMSApi.Models;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace EMSApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        private IConfiguration _con;

        // public DepartmentController(ILogger<DepartmentController> logger,)
        IDept repo;
        public DepartmentController(IDept _repo,IConfiguration con)
        {
            this.repo=_repo;
            _con=con;
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
            var securitykey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_con["JWT:Key"]));
            var credentials=new SigningCredentials(securitykey,SecurityAlgorithms.HmacSha256);

            var claims=new[]
            {
                new Claim(ClaimTypes.Name,data.Username),
                new Claim(ClaimTypes.Role,"hero"),
            };

            var token=new JwtSecurityToken(_con["JWT:Issuer"],
            _con["JWT:Audience"],
            claims,
            expires:DateTime.Now.AddMinutes(2),
            signingCredentials:credentials
            );

            string finalToken = new JwtSecurityTokenHandler().WriteToken(token);

            return finalToken;
        }
    }
}