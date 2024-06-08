// See https://aka.ms/new-console-template for more information

// inline out variables

using Evolution.Chapter2;
using System.Linq.Expressions;
using System.Xml.Linq;

if (int.TryParse("123", out int result))
{
    Console.WriteLine(result); // Output: 123
}


// pattern matching improvements (use of is on type)

object obj = "Hello, World!";
if (obj is string s)
{
    Console.WriteLine(s.ToLower()); // Output: hello, world!
}

switch (obj)
{
    case string str:
        Console.WriteLine(str.ToUpper()); // Output: HELLO, WORLD!
        break;
}



// tuples
static  (int X, int Y) GetCoordinates()
{
    return (5, 10);
}

// Usage
var coords = GetCoordinates();
Console.WriteLine(coords.X); // Output: 5


// deconstructing tuples
(string, int) GetNameAndAge() => ("John Doe", 30);

var (name, age) = GetNameAndAge();
// Output: John Doe is 30 years old
Console.WriteLine($"{name} is {age} years old.");

// local functions within a function

int Fibonacci(int n)
{
    int Fib(int value) => value <= 1 ? value : Fib(value - 1) + Fib(value - 2);
    return Fib(n);
}

// the fifth term of a fibonacci sequence is 5
Console.WriteLine(Fibonacci(5)); // Output: 5


// retrieve ref from an element in a matrix
var matrix = new Matrix(10);
ref int found = ref matrix.FindElement(5); // Assume element '5' exists for simplicity
found = 100; // Modify the element directly in the matrix
Console.WriteLine(matrix.FindElement(100)); // Output: 100

// Expression-bodied Members Expansion
public class Person
{
    private string name;
    public string Name
    {
        get => name;
        set => name = value;
    }
}

// Expression - bodied Finalizer Example
public class ResourceHandler
{
    private IntPtr nativeResource; // Handle to an unmanaged resource

    public ResourceHandler(IntPtr resource)
    {
        nativeResource = resource;
    }

    // Expression-bodied finalizer
    ~ResourceHandler() => ReleaseUnmanagedResources(nativeResource);

    private void ReleaseUnmanagedResources(IntPtr res)
    {
        // Assume this method properly releases the unmanaged resource
        Console.WriteLine("Unmanaged resources released.");
    }
}


// Throw Expressions to simplify exception handling
public class Person2
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }
}
