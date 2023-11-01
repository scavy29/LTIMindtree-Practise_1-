using DisconnectedAdoApp;

class Program
{
    public static void Main(string [] args)
    {
        EmployeeDetails ed=new EmployeeDetails();

        Employee e=new Employee{
            EmployeeName="Allu Arjun",
            Salary=40500,
            JoinDate=Convert.ToDateTime("12-Dec-2022")
        };
        Employee e1=new Employee{
            EmployeeName="Anjali",
            Salary=49500,
            JoinDate=Convert.ToDateTime("22-Jan-2020")
        };
        Employee e2=new Employee{
            EmployeeName="Vikrant",
            Salary=40500,
            JoinDate=Convert.ToDateTime("17-Mar-2022")
        };
        Employee e3=new Employee{
            EmployeeName="Harshal",
            Salary=400,
            JoinDate=Convert.ToDateTime("02-Sep-2023")
        };
        Employee e4=new Employee{
            EmployeeName="Sushil",
            Salary=30900,
            JoinDate=Convert.ToDateTime("13-Aug-2022")
        };
        Employee e5=new Employee{
            EmployeeName="Livia",
            Salary=98762,
            JoinDate=Convert.ToDateTime("28-Jul-2022")
        };

        // ed.AddEmployee(e);
        // ed.AddEmployee(e1);
        // ed.AddEmployee(e2);
        // ed.AddEmployee(e3);
        // ed.AddEmployee(e4);
        // ed.AddEmployee(e5);
        // ed.SearchEmployee(2);
        // ed.UpdateEmployee(1,e);
        // ed.GetAllEmployee();
        // ed.DisplayUpdateState();
    }
}