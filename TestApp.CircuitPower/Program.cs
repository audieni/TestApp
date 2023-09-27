namespace TestApp.CircuitPower;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, world!");
    }

    public int CircuitPower(int voltage, int current)
    {
        return voltage * current;
    }
}