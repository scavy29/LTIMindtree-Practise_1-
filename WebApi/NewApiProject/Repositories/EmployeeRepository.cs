using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewApiProject.Models;
using Microsoft.EntityFrameworkCore;
using NewApiProject.DTOs;
using NewApiProject.Repositories;

namespace NewApiProject.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {   
        private ApplicationDbContext db;

        public EmployeeRepository()
        {

        }
        public EmployeeRepository(ApplicationDbContext context)
        {
            this.db=context;
        }

        public Employee AddEmployee(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
            return (emp);
        }

        public Employee SearchEmployee(int id)
        {
            var emp=db.Employees.Find(id);
            if(emp!=null)
            {
                return emp;
            }
            else
            {
                return null;
            }
        }

        public List<EmployeeDTO> GetAllEmployees()
        {
            var emplist=db.Employees.Include("Department")
            .Select(e=>new EmployeeDTO{
                EmployeeId = e.EmployeeId,
                EmployeeName = e.EmployeeName,
                DepartmentName=e.Department.DeptName,
                Salary = e.Salary
            }).ToList();
            return emplist;
        }

        public Employee DeleteEmployee(int id)
        {
            var emp=db.Employees.Find(id);
            if(emp!=null)
            {
                db.Remove(emp);
                db.SaveChanges();
                return emp;
            }
            else
            {
                return null;
            }
        }

        public Employee UpdateEmployee(int id,Employee uemp)
        {
            var emp=db.Employees.Find(id);
            if(emp!=null)
            {
                db.Update(uemp);
                db.SaveChanges();
                return emp;
            }
            else
            {
                return null;
            }
        }
    }
}