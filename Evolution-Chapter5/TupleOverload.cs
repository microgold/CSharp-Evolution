
public class TupleOverload
{
    public void Process((int, int) point)
    {
        Console.WriteLine($"int tuple: ({point.Item1}, {point.Item2})");
    }

    // Method with named tuple
    public void Process((double X, double Y) doublePoint)
    {
        Console.WriteLine($"double tuple: ({doublePoint.X}, {doublePoint.Y})");
    }

    public void Process(double X)
    {
        Console.WriteLine($"X: {X}");
    }
}