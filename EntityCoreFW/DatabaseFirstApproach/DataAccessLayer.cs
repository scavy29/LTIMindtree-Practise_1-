using Microsoft.EntityFrameworkCore;
using DatabaseFirstApproach.Data;

namespace DatabaseFirstApproach
{
    class DataAccessLayer
    {
        MyDatabaseContext db=new MyDatabaseContext();
        public void AddEmployee()
        {
            Console.WriteLine("Enter Name,DepartmentId,Salary & JoinDate");
            Employee emp=new Employee{
            EmployeeName=Console.ReadLine(),
            DepartmentId=Convert.ToInt32(Console.ReadLine()),
            Salary=Convert.ToInt32(Console.ReadLine()),
            JoinDate=DateTime.Parse(Console.ReadLine())
            };

            db.Employees.Add(emp);
            db.SaveChanges();
            
            Console.WriteLine("Employee with Id {0} inserted",emp.EmployeeId);
        }

        public void FindEmployee()
        {
            Console.WriteLine("Enter ID to Find");
            int empid=Convert.ToInt32(Console.ReadLine());
            var emp=db.Employees.Find(empid);
            if(emp!=null)
            {
                db.Employees.Remove(emp);
                db.SaveChanges();
                Console.WriteLine("Deleted");
            }
            else 
            {
                Console.WriteLine("No Such Employee");
            }
        }
        public void GetAllEmployees()
        {
            foreach(var emp in db.Employees)
            {
                Console.WriteLine("{0}  {1}   {2}   {3}",emp.EmployeeId,emp.EmployeeName,emp.DepartmentId,emp.Salary);
            }
        }

        public void GetAllEmployeesByDeptName()
        {
            foreach(var emp in db.Employees.Include("Department"))
            {
                Console.WriteLine("{0}  {1}  {2}   {3}",emp.EmployeeId,emp.EmployeeName,emp.Department.DepartmentName,emp.Salary);
            }
        }

        public void UpdateEmployee()
        {
            Console.WriteLine("Enter Id to Update");
            int empid=Convert.ToInt32(Console.ReadLine());
            var emp=db.Employees.Find(empid);
            if(emp!=null)
            {
                Console.WriteLine("Enter Name and Salary to Update");
                string? name=Console.ReadLine();
                int sal=Convert.ToInt32(Console.ReadLine());
                emp.EmployeeName=name;
                emp.Salary=sal;
                db.SaveChanges();
                Console.WriteLine("Updated");
            }
            else
            {
                Console.WriteLine("No Such Employee");
            }
        }
    }
}
