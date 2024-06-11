using Evolution_Chapter10;
using System.ComponentModel;
using ProjectMatrix = System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>>;

IList<int> numbers = [1, 2, 3, 4]; // collection expression
foreach (var number in numbers)
{
    Console.Write($"{number}, ");  // output:
}

Console.WriteLine();


int[] greaterValues = [5, 6];
int[] lesserValues = [-1,0];
int[] largerList = [..lesserValues, ..numbers, ..greaterValues, 7];

foreach (var number in largerList)
{
    Console.Write($"{number}, ");  // output:
}

static void ProcessData(ref readonly LargeData data)
{
    // data.Data[0] = 123; // This would be an error: cannot assign to a member of a readonly variable
    Console.WriteLine();
    Console.WriteLine(data.Data.Length);
}

// Usage
var largeData = new LargeData(new long[1000]);
ProcessData(ref largeData);


// default lambda expression

new DefaultLambdaExample().ShowDefaultLambda();

// alias any type


ProjectMatrix matrix = new ProjectMatrix();
matrix.Add(1, new List<string> { "Hello", "World" });
Console.WriteLine(matrix[1][0]); // Output: HELLO

Buffer buffer = new Buffer();

buffer[8] = 45;
// Simulating the array access (for demonstration purposes)
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    Console.Write($"{i}:{buffer[i]}, ");
}

// new ExperimentalTestExample().TestFeature();

// Usage
new InterceptorExample().PerformAction();