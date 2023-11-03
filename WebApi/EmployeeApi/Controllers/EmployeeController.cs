using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Models;

namespace EmployeeApi.Controllers
{

    //Declaring a List to store list of employees
    private List<Employee> employeelist=new List<Employee>{
        new Employee{EmployeeId=101,EmployeeName="Vikrant",Salary=20400},
        new Employee{EmployeeId=121,EmployeeName="Sushil",Salary=50900},
        new Employee{EmployeeId=131,EmployeeName="Harshal",Salary=45330},
        new Employee{EmployeeId=141,EmployeeName="Must",Salary=45000},
        new Employee{EmployeeId=151,EmployeeName="Ankit",Salary=21400},
    };
    [ApiController]
    [Route("api/[controller]")]

    public class EmployeeController : ControllerBase
    {
        //To Iterate the Emp List & to get all details as well(***)
        public IEnumerable<EmployeeApi> Get()
        {
            return (employeelist);
        }
    }
}