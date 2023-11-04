using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewApiProject.Models;
using NewApiProject.DTOs;

namespace NewApiProject.Repositories
{
    public interface IEmployeeRepository
    {
        Employee AddEmployee(Employee emp);
        Employee SearchEmployee(int id);
        List<EmployeeDTO> GetAllEmployees();
        Employee UpdateEmployee(int id,Employee uemp);
    }
}