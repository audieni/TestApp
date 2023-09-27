namespace TestApp;

public class Program
{
    public static void Main(string[] args)
    {
        var sum = new Sum.Program();
        Console.WriteLine("Sum(3, 2) = " + sum.Sum(3, 2));
        Console.WriteLine("Sum(-3, -6) = " + sum.Sum(-3, -6));
        Console.WriteLine("Sum(7, 3) = " + sum.Sum(7, 3));

        var checkEquality = new CheckEquality.Program();
        Console.WriteLine("CheckEquality(1, true) = " + checkEquality.CheckEquality(1, true));
        Console.WriteLine("CheckEquality(0, \"0\") = " + checkEquality.CheckEquality(0, "0"));
        Console.WriteLine("CheckEquality(1, 1) = " + checkEquality.CheckEquality(1,  1));

        var circuitPower = new CircuitPower.Program();
        Console.WriteLine("CircuitPower(230, 10) = " + circuitPower.CircuitPower(230, 10));
        Console.WriteLine("CircuitPower(110, 3) = " + circuitPower.CircuitPower(110, 3));
        Console.WriteLine("CircuitPower(480, 20) = " + circuitPower.CircuitPower(480, 20));
        
        Console.WriteLine(sum);
        Console.WriteLine(checkEquality);
        Console.WriteLine(circuitPower);

        GC.Collect();
        
        Console.WriteLine(sum);
        Console.WriteLine(checkEquality);
        Console.WriteLine(circuitPower);
    }
}
