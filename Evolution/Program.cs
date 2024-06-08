// See https://aka.ms/new-console-template for more information

using Evolution.Chapter1;

Console.WriteLine("*** Demoing immediate assignment to the out parameter ***\r\n");

Console.WriteLine("Hello, World!");
if (int.TryParse("123", out int result))
{
    Console.WriteLine(result); // Output: 123
}

Console.WriteLine("*** Demoing matching types and auto assignment ***\r\n");

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

Console.WriteLine("**** Demoing new Tuples ****\r\n");

(string, int) GetNameAndAge() => ("John Doe", 30);
var (name, age) = GetNameAndAge();
// Output: John Doe is 30 years old
Console.WriteLine($"{name} is {age} years old.");

Console.WriteLine("**** Demoing Local Functions ****\r\n");

int Fibonacci(int n)
{
    int Fib(int value) => value <= 1 ? value : Fib(value - 1) + Fib(value - 2);
    return Fib(n);
}
Console.WriteLine(Fibonacci(6)); // Output: 8

Console.WriteLine("\r\n**** Demoing Ref Returns **          **\r\n");


// Usage
var matrix = new Matrix(10);
ref int found = ref matrix.FindElement(5); // Assume element '5' exists for simplicity
found = 100; // Modify the element directly in the matrix
Console.WriteLine(matrix.FindElement(100)); // Output: 100