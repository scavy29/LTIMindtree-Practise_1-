using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Models;
// using System.Web.Http;


namespace EmployeeApi.Controllers
{


    [ApiController]

    //Follow the link in this format
    [Route("api/[controller]")]

    public class EmployeeController : ControllerBase
    {
        //Declaring a List to store list of employees
        private static List<Employee> employeelist=new List<Employee>{
            new Employee{EmployeeId=101,EmployeeName="Vikrant",Salary=20400},
            new Employee{EmployeeId=121,EmployeeName="Sushil",Salary=50900},
            new Employee{EmployeeId=131,EmployeeName="Harshal",Salary=45330},
            new Employee{EmployeeId=141,EmployeeName="Musu",Salary=45000},
            new Employee{EmployeeId=151,EmployeeName="Ankit",Salary=21400}
        };
    
        //To Iterate the Emp List & to get all details as well(***)
        // public IEnumerable<Employee> Get()
        // {
        //     return (employeelist);
        // }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employeelist);
        }

        // public Employee Get(int id)
        // {
        //     var emp = employeelist.Find(e=>e.EmployeeId==id);
        //     if(emp!=null)
        //         return Ok(emp);
        //     else
        //         return NotFound();
        // }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var emp = employeelist.Find(e=>e.EmployeeId==id);
            if(emp!=null)
                return Ok(emp);
            else
                return NotFound();
        }

        // public void Post(Employee emp)
        // {
        //     employeelist.Add(emp);
        // }
        [HttpPost]
        public IActionResult Post(Employee emp)
        {
            employeelist.Add(emp);
            return Ok(emp);
        }

        // public IActionResult Delete(int id)
        // {
        //     Employee emp=this.Get(id);
        //     employeelist.FirstOrDefault(e=>e.EmployeeId==id);
        //     employeelist.Remove(emp);
        // }
        [HttpPost]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var emp=employeelist.FirstOrDefault(e=>e.EmployeeId==id);
            if(emp!=null)
            {
                employeelist.Remove(emp);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id,Employee e)
        {
            var emp=employeelist.FirstOrDefault(e=>e.EmployeeId==id);
            if(emp!=null)
            {
                emp.EmployeeName=e.EmployeeName;
                emp.Salary=e.Salary;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}