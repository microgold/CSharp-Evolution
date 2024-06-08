object obj = 100;
if (obj is int i && i > 50) // Enhanced pattern matching with additional condition
{
    Console.WriteLine($"{i} is an integer and greater than 50.");
}

// demo the new pattern matching features
Demo();

// demo the generic preference
new ShowGenericPreference().Test("hello");
new ShowGenericPreference().Test(new Person() { Age = 20, Name = "Cindy"});

// demo overload of in parameter
var myNumber = 10;
new  TestInOverload().Test(myNumber);
new  TestInOverload().Test(in myNumber);

// test nullable overload
new TestNullableOverload().Test(10);
new TestNullableOverload().Test(null);

// tuple overload for named tuples
var example = new TupleOverload();

// Tuple without element names
example.Process((5, 10));

// Tuple with element names
example.Process((X: 15, Y: 20));

example.Process((15.0d, Y: 20.0d));

example.Process(15d);

// illustrate ref returns
int[] numbers = { 1, 2, 3, 4, 5 };
ref int target = ref Find(numbers, 3);
target = 10;
Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 2, 10, 4, 5

var result = new Inventory().FindItem(1);
Console.WriteLine(result.TonsOfData); // Output: 100


static void ProcessObject(object obj)
{
    switch (obj)
    {
        case int i when i > 0:
            Console.WriteLine($"{i} is a positive integer.");
            break;
        case int i when i <= 0:
            Console.WriteLine($"{i} is a non-positive integer.");
            break;
        case string s when s.Length > 10:
            Console.WriteLine($"String is too long: {s.Substring(0, 10)}...");
            break;
        case string s:
            Console.WriteLine($"String: {s}");
            break;
        case double d when d == 0.0:
            Console.WriteLine("Double is zero.");
            break;
        case null:
            Console.WriteLine("Object is null.");
            break;
        default:
            Console.WriteLine("Unknown type or condition.");
            break;
    }
}

// illustrates ref return
static ref int Find(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
            return ref numbers[i];  // returns a reference to the array element
    }
    throw new IndexOutOfRangeException($"{target} not found");
}

// Demo calling the method
static void Demo()
{
    ProcessObject(15);        // Output: 15 is a positive integer.
    ProcessObject(-1);        // Output: -1 is a non-positive integer.
    ProcessObject("Hello");   // Output: String: Hello
    ProcessObject("Hello World from C# 7.3"); // Output: String is too long: Hello Worl...
    ProcessObject(0.0);       // Output: Double is zero.
    ProcessObject(null);      // Output: Object is null.
    ProcessObject(new List<int>()); // Output: Unknown type or condition.
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class ShowGenericPreference
{
    public void Test<T>(T obj) where T : class
    {
        Console.WriteLine("Generic T where T : class");
    }

    public void Test(string text)
    {
        Console.WriteLine("Specific string");
    }
}




