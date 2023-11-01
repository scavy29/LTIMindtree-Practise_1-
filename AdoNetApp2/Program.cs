using System;
using static System.Console;
using System.Data.SqlClient;

//Program with using methods, create connection class
namespace AdoNetApp
{
    class Employee
    {
        public int EmployeeId{set;get;}
        public string? EmployeeName{set;get;}

        public double Salary{set;get;}
        public DateTime JoinDate{set;get;}
    }
    //Class for Connection
    class DbConnect
    {
        public static string ConnectionString
        {
            get 
            {
                return "server=localhost;database=LtiDb;uid=sa;password=examlyMssql@123";
            }
        }
    }

    class EmployeeDetails
    {
        public void AddEmployee(Employee emp)
        {
            try{
            using SqlConnection con = new SqlConnection(DbConnect.ConnectionString);
                con.Open();
                string str=$"insert into Employees values('{emp.EmployeeName}',{emp.Salary},'{emp.JoinDate}')";

                SqlCommand cmd=new SqlCommand(str,con);
                cmd.ExecuteNonQuery();
                WriteLine("Emp Added");
            }
            catch(Exception ex)
            {
                WriteLine(ex.ToString());
            }
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

        public void DataReaderMethods()
        {
            using SqlConnection con=new SqlConnection(DbConnect.ConnectionString);
            con.Open();
            string str=$"select * from employees";
            SqlCommand cmd=new SqlCommand(str,con);
            // SqlDataReader reader=cmd.ExecuteNonQuery();
        }

        //Using Stored Procedute to execute queries
        public void AddEmployeestoredproc(Employee emp)
        {
            try{
            using SqlConnection con = new SqlConnection(DbConnect.ConnectionString);
                con.Open();
                SqlCommand cmd=new SqlCommand("proc_InsertEmployee",con);
                cmd.CommandType=System.Data.CommandType.StoredProcedure;

                SqlParameter p_employeeid=new SqlParameter("@employeeid",System.Data.SqlDbType.Int);
                p_employeeid.Direction=System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(p_employeeid);

                cmd.Parameters.AddWithValue("@employeename",emp.EmployeeName);
                cmd.Parameters.AddWithValue("@Salary",emp.Salary);
                cmd.Parameters.AddWithValue("@joindate",emp.JoinDate);

                cmd.ExecuteNonQuery();
                WriteLine("Employee with {0} Inserted Successfully",p_employeeid.Value);
            }
            catch(Exception ex)
            {
                WriteLine(ex.ToString());
            }
        }
        //ExecuteScalar Method
        public void GetMaxSalary()
        {
            try
            {
                using SqlConnection con=new SqlConnection(DbConnect.ConnectionString);
                con.Open();
                SqlCommand cmd=new SqlCommand("select max(salary) from employees",con);
                Object obj=cmd.ExecuteScalar();
                if(!Convert.IsDBNull(obj))
                    WriteLine("Maximum Salary is {0}",obj);
                else
                    WriteLine("No such record Found");
            }
            catch(Exception ex)
            {
                WriteLine(ex.ToString());
            }
        }
        public void GetXmlData()
        {
            try
            {
                using SqlConnection con=new SqlConnection(DbConnect.ConnectionString);
                con.Open();
                string str="select * from employees for xml auto";

                SqlCommand cmd=new SqlCommand(str,con);
                System.Xml.XmlReader reader=cmd.ExecuteXmlReader();
                reader.Read();

                while(!reader.EOF)
                {
                    WriteLine(reader.ReadOuterXml());
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                WriteLine(ex.ToString());
            }
        }
    }
    class Program
    {
        public static void Main(string [] args)
        {

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
                Salary=34567,
                JoinDate=DateTime.Parse("12-Jan-2023")
            };
            Employee nemp=new Employee{
                EmployeeName="Varun",
                Salary=5090,
                JoinDate=DateTime.Parse("12-Sep-2023")
            };
            // ed.AddEmployee(e1);
            // ed.UpdateEmployee(4,nemp);
            // ed.GetAllEmployees();
            // ed.AddEmployeestoredproc(nemp);
            // ed.GetMaxSalary();
            ed.GetXmlData();
        }
    }
}
