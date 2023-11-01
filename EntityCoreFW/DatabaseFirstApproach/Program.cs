using DatabaseFirstApproach.Data;

using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstApproach
{
    class Program 
    {
        public static void Main(string [] args)
        {
            DataAccessLayer dl=new DataAccessLayer();
            Console.WriteLine("Enter Choice");
            Console.WriteLine("1]Add Employee");
            Console.WriteLine("2]Find Employee");
            Console.WriteLine("3]List Employees");
            Console.WriteLine("4]List Employee by DeptName");
            Console.WriteLine("5]Update Employee");
            int choice=Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:dl.AddEmployee();
                        break;
                case 2:dl.FindEmployee();
                        break;
                case 3:dl.GetAllEmployees();
                        break;
                case 4:dl.GetAllEmployeesByDeptName();
                        break;
                case 5:dl.UpdateEmployee();
                        break;
                default:Console.WriteLine("Invalid Input");
                        break;
            }
        }
    }
}