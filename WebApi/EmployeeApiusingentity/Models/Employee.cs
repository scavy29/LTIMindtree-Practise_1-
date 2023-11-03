using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApiusingentity.Models
{
    public class Employee
    {
        public int EmployeeId{get;set;}
        public string? EmployeeName{get;set;}
        public int Salary{get;set;}
        public int DeptId{get;set;}
    }
}