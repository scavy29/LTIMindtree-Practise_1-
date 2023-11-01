namespace DisconnectedAdoApp;
using System.Data;
using System.Data.SqlClient;
using static System.Console;

class EmployeeDetails{
        string conStr="server=localhost;database=LtiDb;uid=sa;password=examlyMssql@123";
    SqlConnection con;
    SqlDataAdapter da;
    DataSet ds;
    string str;
    SqlCommandBuilder build;
    public EmployeeDetails()
    {
        con=new SqlConnection(conStr);
        str="select * From Employees";
        da=new SqlDataAdapter(str,con);
        ds=new DataSet();
        build=new SqlCommandBuilder(da);                //Generates SQL statements
        da.MissingSchemaAction=MissingSchemaAction.AddWithKey;          //adds Pk details into table
        da.Fill(ds,"dtEmployees");
    }
    public void GetAllEmployee()
    {
        foreach(DataRow row in ds.Tables[0].Rows)
        {
            WriteLine("{0} {1} {2} {3}",row[0],row[1],row[2],row[3]);
        }
    }
    public void AddEmployee(Employee emp)
    {
        DataRow row=ds.Tables[0].NewRow();
        row[1]=emp.EmployeeName;
        row[2]=emp.Salary;
        row[3]=emp.JoinDate;
        ds.Tables[0].Rows.Add(row);
        da.Update(ds.Tables[0]);
        WriteLine("Row inserted!");
    } 
    public void SearchEmployee(int empid)
    {
        DataRow? row = ds.Tables[0].Rows.Find(empid);
        if(row!=null)
        {
            WriteLine("{0},{1},{2},{3}",row[0],row[1],row[2],row[3]);
        }
        else
        {
            WriteLine("No such Employee");
        }
    }
    public void DeleteEmployee(int empid)
    {
        DataRow? row=ds.Tables[0].Rows.Find(empid);
        if(row!=null)
        {
            row.Delete();
            da.Update(ds.Tables[0]);
            WriteLine("Deleted Row");
        }
        else
        {
            WriteLine("No Employee found");
        }
    }
    public void UpdateEmployee(int empid,Employee emp)
    {
        DataRow? row=ds.Tables[0].Rows.Find(empid);
        if(row!=null)
        {
            row[1]=emp.EmployeeName;
            row[2]=emp.Salary;
            row[3]=emp.JoinDate;
            da.Update(ds.Tables[0]);
            WriteLine("Updated!!");
        }
        else
        {
            WriteLine("No Such Employee");
        }
    }
    public void DisplayUpdateState()
    {
        foreach(DataRow row in ds.Tables[0].Rows)
        {
            WriteLine("{0},{1}",row[0],row.RowState);
        }
        da.Update(ds.Tables[0]);
    }
}