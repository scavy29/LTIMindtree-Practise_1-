// See https://aka.ms/new-console-template for more information

namespace DemoSolutions{
    public class Program
    {
        
        public static void Main(string [] args)
        {
            Console.WriteLine("Hello!!! World");
        }

    public int Demo()
    {
        return 100;
    }

    public static bool IsOK()
    {
        return true;
    }
    public void ThrowDivideByZeroExceptionMethod()
    {
        throw new System.DivideByZeroException("Divide by zero");
    }

    public string GetMyName(string name)
    {
        return name;
    }

    public int POSNEG()
    {
        
    }
    }
}