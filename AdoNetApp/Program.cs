using System;
using System.Data.SqlClient;

namespace AdoNetApp
{
    class Employee
    {
        public int EmployeeId{set;get;}
        public string? EmployeeName{set;get;}

        public double Salary{set;get;}
        public DateTime JoinDate{set;get;}
    }
    class EmployeeDetails
    {
        public void AddEmployee(Employee emp)
        {
            string conStr="server=localhost;database=LtiDb;uid=sa;password=examlyMssql@123";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string str=$"insert into Employees values('{emp.EmployeeName}',{emp.Salary},'{emp.JoinDate}')";

            SqlCommand cmd=new SqlCommand(str,con);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            Console.WriteLine("Employee Added");
        }
        public void DeleteEmployee(int empid)
        {
            string conStr="server=localhost;database=LtiDb;uid=sa;password=examlyMssql@123";
            SqlConnection con=new SqlConnection(conStr);
            con.Open();
            string str=$"delete from Employees where EmployeeId={empid}";
            SqlCommand cmd=new SqlCommand(str,con);
            int cnt=cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();

            if(cnt==0)
                Console.WriteLine("No Such Employee Found");
            else
                Console.WriteLine("Row Deleted");
        }
        public void UpdateEmployee(int empid,Employee emp)
        {
            string conStr="server=localhost;database=LtiDb;uid=sa;password=examlyMssql@123";
            SqlConnection con=new SqlConnection(conStr);
            string str=$"update Employees set EmployeeName='{emp.EmployeeName}',salary='{emp.Salary}',joindate='{emp.JoinDate}' where EmployeeId={empid}";
            con.Open();
            SqlCommand cmd=new SqlCommand(str,con);
            int count=cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            if(count==0)
                Console.WriteLine("No such Employee");
            else
                Console.WriteLine("Updated Successfully");
        }
        public void SearchEmployee(int empid)
        {
            string conStr="server=localhost;database=LtiDb;uid=sa;password=examlyMssql@123";
            SqlConnection con=new SqlConnection(conStr);
            con.Open();
            string str=$"select * from Employees where employeeid={empid}";
            SqlCommand cmd=new SqlCommand(str,con);
            SqlDataReader reader=cmd.ExecuteReader();
            if(reader.Read()==true)
            {
                Console.WriteLine(reader.GetInt32(0));
                Console.WriteLine(reader.GetString(1));
                Console.WriteLine(reader.GetDecimal(2));
                Console.WriteLine(reader.GetDateTime(3));
            }
            else
            {
                Console.WriteLine("No such employee present");
            }
            reader.Close();
            con.Close();
            con.Dispose();
        }
        public void GetAllEmployees()
        {

            string conStr="server=localhost;database=LtiDb;uid=sa;password=examlyMssql@123";
            SqlConnection con=new SqlConnection(conStr);
            con.Open();
            string str=$"select * from Employees";
            SqlCommand cmd=new SqlCommand(str,con);
            SqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()==true)
            {
                Console.WriteLine("{0},{1},{2},{3}",reader.GetInt32(0),
                reader.GetString(1),reader.GetDecimal(2),reader.GetDateTime(3));
            }
            reader.Close();
            con.Close();
            con.Dispose();
        }
    }
    class Program
    {
        public static void Main(string [] args)
        {
            // string conStr="server=localhost;database=LtiDb;uid=sa;password=examlyMssql@123";
            // SqlConnection con = new SqlConnection(conStr);
            // con.Open();
            // string str="insert into Employees values(49021,'12-Dec-2022')";
            // SqlCommand cmd = new SqlCommand(str,con);
            // cmd.ExecuteNonQuery();
            // con.Close();
            // con.Dispose();
            // Console.WriteLine("Connection Established");
            EmployeeDetails ed=new EmployeeDetails();
            Employee e1=new Employee
            {
                EmployeeName="AA",
                Salary=45890,
                JoinDate=DateTime.Parse("12-Dec-2023")
            };
            Employee e2=new Employee
            {
                EmployeeName="BB",
                Salary=49090,
                JoinDate=DateTime.Parse("12-Jan-2023")
            };
            Employee nemp=new Employee{
                EmployeeName="CCC",
                Salary=51090,
                JoinDate=DateTime.Parse("12-Jan-2021")
            };
            // ed.AddEmployee(e1);
            // ed.AddEmployee(e2);
            // ed.SearchEmployee(1);
            // ed.SearchEmployee(3);
            // ed.UpdateEmployee(4,nemp);
            // ed.SearchEmployee(4);
            ed.GetAllEmployees();
        }
    }
}
