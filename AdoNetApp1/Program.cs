using System;
using System.Data.SqlClient;


//Make Methods as Return type
namespace AdoNetApp1{
    class Employee{
        public int EmployeeId{set;get;}
        public string? EmployeeName{set;get;}
        public double Salary{set;get;}
        public DateTime JoinDate{set;get;}
    }

    class EmployeeDetails{
        public bool AddEmployee(Employee emp)
        {
            string strCon="server=localhost;database=LtiDb;uid=sa;password=examlyMssql@123";
            SqlConnection con=new SqlConnection(strCon);
            con.Open();

            string str=$"insert into employees values ('{emp.EmployeeName}',{emp.Salary},'{emp.JoinDate}')";
            SqlCommand cmd=new SqlCommand(str,con);
            int rowcount=cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            if(rowcount>0)
            {
                Console.WriteLine("Added");
                return true;
            }
            else
            {
                Console.WriteLine("No such Employee");
                return false;
            }
        }
        
        public bool DeleteEmployee(int empid)
        {
            string strCon="server=localhost;database=LtiDb;uid=sa;password=examlyMssql@123";
            SqlConnection con=new SqlConnection(strCon);
            con.Open();

            string str=$"delete from employees where EmployeeId={empid}";
            SqlCommand cmd=new SqlCommand(str,con);
            int rowcount=cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();

            if(rowcount>0)
            {
                Console.WriteLine("Deleted");
                return true;
            }
            else
            {
                Console.WriteLine("No Such Employee");
                return false;
            }
        }
        public void DataReaderMethods()
        {
            try
            {
                string conStr="server=localhost;database=LtiDb;uid=sa;password=examlyMssql@123";
                SqlConnection con=new SqlConnection(conStr);
                con.Open();

                string str=$"select * from employees";
                SqlCommand cmd=new SqlCommand(str,con);
                SqlDataReader reader=cmd.ExecuteReader();
                reader.Read();
                
                    Console.WriteLine("The row has {0} counts",reader.HasRows);
                    Console.WriteLine("The row has {0} rows",reader.FieldCount);
                    Console.WriteLine("First Column: {0} ",reader.GetName(0));
                    Console.WriteLine("Database: {0}",reader.IsDBNull(1));
                    Console.WriteLine("First Name Entry: {0}",reader.GetSqlValue(1));
                    Console.WriteLine("Salary of First Name: ",reader["Salary"]);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

    class Program{
        public static void Main(string[] args)
        {
            EmployeeDetails ed = new EmployeeDetails();
            Employee e1=new Employee
            {
                EmployeeName="Andrew",
                Salary=34000,
                JoinDate=DateTime.Parse("21-Mar-2023")
            };

            ed.DataReaderMethods();
        }
    }
}