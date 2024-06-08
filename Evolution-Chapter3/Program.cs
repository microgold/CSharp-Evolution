class Program
{
    static async Task Main(string[] args)
    {
        await DoSomeInitializationAsync();
        int mynumber = 5;
        SetToDefault<int>(ref mynumber);
        var point = GetCoordinates();
        Console.WriteLine($"X: {point.x}, Y: {point.y}"); // output : X: 10, Y: 20
        Console.WriteLine("Initialization Complete");       
    }

    static void SetToDefault<T>(ref T input)
    {
        // Default Literal Expressions
        input = default;
        Console.WriteLine($"Value set to default: {input}");  // output : Value set to default: 0
    }

    static public (int x, int y) GetCoordinates()
    {
        int x = 10;
        int y = 20;

        // Automatically infers the tuple names from the variable names
        return (x, y);
    }

    static async Task DoSomeInitializationAsync()
    {
        // Simulate an asynchronous operation (e.g., loading configuration)
        await Task.Delay(1000);
    }

    
}