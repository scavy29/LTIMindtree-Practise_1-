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
        var val=prog.Demo();
        Assert.Pass();
    }
}