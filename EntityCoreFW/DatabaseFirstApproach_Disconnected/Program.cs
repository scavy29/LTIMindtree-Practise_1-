using Microsoft.EntityFrameworkCore.SqlServer;
using DatabaseFirstApproach_Disconnected.Data;

namespace DatabaseFirstApproach_Disconnected
{
    class Program
    {
        public static void Main(string [] args)
        {
            DataAccessLayer dl=new DataAccessLayer();
            // dl.AddEmployee();
            // dl.DeleteEmployee();
            // dl.UpdateEmployee();
            dl.GetEmployees();
        }
    }
}