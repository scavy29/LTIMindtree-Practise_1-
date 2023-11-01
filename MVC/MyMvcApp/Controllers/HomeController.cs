using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;
namespace MyMvcApp.Controllers;
using System.Data.SqlClient;
using System;
using System.Data;
// using System.Collections.IEnumerable;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // public IActionResult Index()
    // {
    //     return View();
    // }

    public IActionResult Privacy()
    {
        return View();
    }

    public string Name()
    {
        return "Vikrant";
    }
    public IActionResult ContactUs()
    {
        return View();
    }

    public IActionResult Projects()
    {
        return View("myprojects");
    }

    public ContentResult Content()
    {
        return Content("Welcome");
    }

    public FileResult FileDownload()
    {
        return File("https://4.bp.blogspot.com/-wpqeFEBT248/WiWVqJ8d1XI/AAAAAAACrU8/0oSxzdSJbTATn99GlCno38UCZTzCX_DWQCLcBGAs/s1600/Lamborghini-Urus%2B%25287%2529.jpg","img/jpg","myring");
    }

    public RedirectResult Redirect()
    {
        return Redirect("http://www.fb.com");
    }

    public JsonResult Json()
    {
        List<string>obj=new List<string>{"IND","RUS","DXB"};
        return Json(obj);
    }

/*
    public ViewResult Index()
    {
        var str="Welcome to MVC Asp.Net";
        ViewData["message"]=str;

        ViewBag.message2="ASP.net is flexible";
        return View();
    }

    public ViewResult Index()
    {
        List<string> al=new List<string>{"AMAN","SURESH","ADARSH","PIYUSH"};
        // ViewData["message3"]=al;
        ViewBag.message3=al;
        return View();
    }

    public ViewResult Index()
    {
        Employee empobj=new Employee{
            EmployeeId=1011,
            EmployeeName="DV",
            Salary=45000,
            JoinDate=DateTime.Parse("12-Dec-2022")
        };
        return View(empobj);
    }
*/

    // public ViewResult Index()
    // {
    //     List <Employee> el=new List<Employee>{
    //     new Employee{
    //         EmployeeId=101,
    //         EmployeeName="DV",
    //         Salary=90000,
    //         JoinDate=DateTime.Parse("12-Dec-2021")
    //     },
    //     new Employee{
    //         EmployeeId=102,
    //         EmployeeName="PO",
    //         Salary=90020,
    //         JoinDate=DateTime.Parse("12-Dec-2211")
    //     },
    //     new Employee{
    //         EmployeeId=103,
    //         EmployeeName="IO",
    //         Salary=9000,
    //         JoinDate=DateTime.Parse("23-Jan-2020")
    //     }
    //     };
    //     return View(el);
    // }

//Retrieve Data From SQL DB and Display the Result directly to the View using Connected Architecture
    // public ViewResult Index()
    // {
    //     List<Employee>emplist=new List<Employee>();
    //     string conStr="server=localhost;database=LtiDb;uid=sa;password=examlyMssql@123";
    //         SqlConnection con=new SqlConnection(conStr);
    //         con.Open();
    //         string str=$"select * from Employees";
    //         SqlCommand cmd=new SqlCommand(str,con);
    //         SqlDataReader reader=cmd.ExecuteReader();
    //         while(reader.Read()==true)
    //         {
    //             Employee e=new Employee
    //             {
    //                 EmployeeId=reader.GetInt32(0),
    //                 EmployeeName=reader.GetString(1),
    //                 Salary=reader.GetDecimal(2),
    //                 JoinDate=reader.GetDateTime(3)
    //             };
    //             emplist.Add(e);
    //         }
    //         reader.Close();
    //         con.Close();
    //         con.Dispose();
            
    //         return View(emplist);
    // }


//Retrieve Data FROM "SQL DB" and Display the result directly to View using Disconnected Architecture
    public ViewResult Index()
    {
        List<Employee>emplist=new List<Employee>();
        string conStr="server=localhost;database=LtiDb;uid=sa;password=examlyMssql@123";
        SqlConnection con=new SqlConnection(conStr);
        string str="select * From Employees";
        SqlDataAdapter da=new SqlDataAdapter(str,con);
        DataSet ds=new DataSet();
        SqlCommandBuilder build=new SqlCommandBuilder(da);                //Generates SQL statements
        da.MissingSchemaAction=MissingSchemaAction.AddWithKey;          //adds Pk details into table
        da.Fill(ds,"dtEmployees");

        foreach(DataRow row in ds.Tables[0].Rows)
        {
            Employee newemp=new Employee();

                newemp.EmployeeId = (int) row[0];
                newemp.EmployeeName = (string) row[1];
                newemp.Salary = (decimal) row[2];
                newemp.JoinDate = (DateTime) row[3];
            
            emplist.Add(newemp);
        }

        return View(emplist);
    }

    public ViewResult Create()
    {

        string conStr="server=localhost;database=LtiDb;uid=sa;password=examlyMssql@123";
        SqlConnection con = new SqlConnection(conStr);
        con.Open();

        Employee emp=new Employee();
        emp.EmployeeName="Sunny";
        emp.Salary=5600;
        emp.JoinDate=DateTime.Parse("31-Dec-2022");

        SqlCommand cmd=new SqlCommand("proc_InsertEmployee",con);

        cmd.CommandType=System.Data.CommandType.StoredProcedure;
        SqlParameter p_employeeid=new SqlParameter("@employeeid",System.Data.SqlDbType.Int);
        p_employeeid.Direction=System.Data.ParameterDirection.Output;
        cmd.Parameters.Add(p_employeeid);
        cmd.Parameters.AddWithValue("@employeename",emp.EmployeeName);
        cmd.Parameters.AddWithValue("@Salary",emp.Salary);
        cmd.Parameters.AddWithValue("@joindate",emp.JoinDate);
        cmd.ExecuteNonQuery();

        // Console.WriteLine("Employee with {0} Inserted Successfully",p_employeeid.Value);

        // var obj=p_employeeid.Value;
        ViewData["message"]=p_employeeid.Value;
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
