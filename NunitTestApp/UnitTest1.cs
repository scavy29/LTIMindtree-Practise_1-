namespace NunitTestApp;
using ShapeLibrary;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        //Arrange
        Rectangle rectobj=new Rectangle();
        
        //Act
        double result=rectobj.Area(12,10);
        
        //Assert
        Assert.AreEqual(120,result);
    }

    [Test]
    public void Test2()
    {
        //Arrage
        Rectangle rectobj = new Rectangle();

        //ACt
        double result = rectobj.Perimeter(6,5);

        //Asset
        Assert.AreEqual(22,result);
    }
}

