using DemoSolutions;
namespace DemoSolutions.WebApi.Controllers;
namespace DemoSolutions.Test;

public class Tests
{
    Program program=null;
    WeatherForecastController controllerforecast=null;
    [SetUp]
    public void Setup()
    {
        program=new Program();
        WeatherForecastController = new WeatherForecastController();
    }

    [Test]
    public void Test1()
    {
        Program prog=new Program();
        var value=prog.Demo();
        // Assert.AreEqual(value,100);
        Assert.That(value,Is.EqualTo(100));
    }

    // [Test]
    // public void Test2()
    // {
    //     // Program prog=new Program();
    //     var value=Program.IsOk();
    //     Assert.IsTrue(value);
    // }

    [Test]
    public void Test3()
    {
        Assert.Throws<DivideByZeroException>(()=>{
            program.ThrowDivideByZeroExceptionMethod();
        });
    }


    [Test]
    public void Test4()
    {
        StringAssert.Contains("Democ",program.GetMyName("Democ"));
    }

    [Test]
    public void Test5()
    {
        Program p=new Program();
        var value=p.POSNEG();
        Assert.AreEqual(value,-1);
    }

}


