using Microsoft.EntityFrameworkCore;
using DatabaseFirstApproach_Disconnected.Data;


namespace DatabaseFirstApproach_Disconnected
{
    class DataAccessLayer
    {
        MyDatabaseContext db=new MyDatabaseContext();
            public void AddEmployee()
            {
            Employee emp=new Employee{
                EmployeeName="Amitabh",
                DepartmentId=3,
                Salary=109000,
                JoinDate=DateTime.Parse("12-Dec-1995")
            };

            db.Entry(emp).State=EntityState.Added;
            db.SaveChanges();
            Console.WriteLine("Employee Added");
            }

            public void DeleteEmployee()
            {
            var emp1=db.Employees.Find(11);
                if(emp1!=null)
                {
                    db.Entry(emp1).State=EntityState.Deleted;
                    db.SaveChanges();
                    Console.WriteLine("Employee Deleted");
                }
                else
                {
                    Console.WriteLine("No Such Employeee");
                }
            }

            public void UpdateEmployee()
            {
                var emp2=db.Employees.Find(10);
                    if(emp2!=null)
                    {
                        emp2.EmployeeName="Amitabh B";
                        db.Entry(emp2).State=EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("No Such Employee Found");
                    }
            }

            public void GetEmployees()
            {
                var emplist=db.Employees.Include("Department");

                foreach(var i in emplist)
                {
                    Console.WriteLine("{0}  {1}  {2}   {3}   {4}",i.EmployeeId,i.EmployeeName,i.Salary,i.JoinDate,db.Entry(i).State);
                }
            }
    }
}