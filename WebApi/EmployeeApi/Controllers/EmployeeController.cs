using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Models;

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
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return (employeelist);
        }

        [HttpGet]
        [Route("{id}")]
        public Employee Get(int id)
        {
            var emp = employeelist.Find(e=>e.EmployeeId==id);
            return emp;
        }

        [HttpPost]
        public void Post(Employee emp)
        {
            employeelist.Add(emp);
        }

        public void Post()
    }
}