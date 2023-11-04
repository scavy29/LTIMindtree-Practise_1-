using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewApiProject.Models;

namespace NewApiProject.DTOs
{
    public class EmployeeDTO
    {
        public int EmployeeId{get;set;}
        public string? EmployeeName{get;set;}
        public string? DepartmentName{get;set;}
        public int DepartmentId{get;set;}
        public double Salary{get;set;}
        public Department? Department{get;set;}
    }
}