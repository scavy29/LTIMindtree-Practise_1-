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
        public int DesignationId{get;set;}
        public int DepartmentId{get;set;}
        public double Salary{get;set;}
        public Department? Department{get;set;}
        public Designation? Designation{get;set;}
    }
}