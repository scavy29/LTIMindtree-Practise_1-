using EfCoreDbFirstApp.Data;

using Microsoft.EntityFrameworkCore;

MyDatabaseContext db=new MyDatabaseContext();

/*AddEmployee

Employee emp=new Employee
{
    EmployeeName="Livia",
    DepartmentId=1,
    Salary=35900,
    JoinDate=DateTime.Parse("01-Apr-2021")
};

db.Employees.Add(emp);
db.SaveChanges();
Console.WriteLine("Row Inserted with Id {0} Sucessfully",emp.EmployeeId);
*/

/*GetAllEmployees
foreach(var emp in db.Employees)
{
    Console.WriteLine("{0}  {1}   {2}   {3}",emp.EmployeeId,emp.EmployeeName,emp.DepartmentId,emp.Salary);

}
*/

/*
//If you want to display Department Name
foreach(var emp in db.Employees.Include("Department"))
{
    Console.WriteLine("{0},{1},{2},{3}",emp.EmployeeId,emp.EmployeeName,emp.Department.DepartmentName,emp.Salary);
}
*/



/*FindEmployee
var emp=db.Employees.Find(1);
if(emp!=null)
    Console.WriteLine("{0}  {1}  {2}",emp.EmployeeId,emp.EmployeeName,emp.Salary);
else
    Console.WriteLine("NO such Employee");
*/

/*DeleteEmployee
var emp=db.Employees.Find(1);
if(emp!=null)
{
    db.Employees.Remove(emp);
    db.SaveChanges();
    Console.WriteLine("Deleted");
}
else{
    Console.WriteLine("No Such Employee");
}
*/

/*Update Employees
var emp=db.Employees.Find(2);
if(emp!=null)
{
    emp.EmployeeName="Vicky";
    emp.Salary=90009;
    db.SaveChanges();
    Console.WriteLine("Updated");
}
else
{
    Console.WriteLine("No Such Employee");
}
*/