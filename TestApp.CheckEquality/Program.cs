namespace TestApp.CheckEquality;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, world!");
    }

    public bool CheckEquality(object a, object b)
    {
        return a.GetType() == b.GetType() && a.Equals(b);
    }
}