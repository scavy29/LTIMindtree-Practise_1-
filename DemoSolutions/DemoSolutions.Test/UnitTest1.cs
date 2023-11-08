using DemoSolutions;
namespace DemoSolutions.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Program prog=new Program();
        var value=prog.Demo();
        // Assert.AreEqual(value,100);
        Assert.That(value,Is.EqualTo(100));
    }

    [Test]
    public void Test2()
    {
        Program prog=new Program();
        var value=prog.IsOk();
        Assert.IsTrue(value);
    }
}


