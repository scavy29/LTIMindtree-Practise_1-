using Microsoft.EntityFrameworkCore.SqlServer;
using CodeFirstApproach.Data;

namespace CodeFirstApproach
{
    class Program
    {
        public static void Main(string [] args)
        {
            CRUDOperations co=new CRUDOperations();
            Console.WriteLine("1]Add Employee");
            Console.WriteLine("2]Delete Employee");
            Console.WriteLine("3]Update Employee");
            Console.WriteLine("1]List Employee");

            int choice=Convert.ToInt32(Console.ReadLine());
            
            switch(choice){
                case 1:co.AddEmployee();
                break;
                case 2:co.DeleteEmployee();
                break;
                case 3:co.UpdateEmployee();
                break;
                case 4:co.GetEmployees();
                break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}