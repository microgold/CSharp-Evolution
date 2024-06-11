int[] numbers = { 1, 2, 3, 4, 5 };

// starts with 1, 2, 3
if (numbers is [1, 2, 3, ..])
{
    Console.WriteLine("The array starts with 1, 2, 3.");
}

// exactly 1, 2, 3, 4, 5    
if (numbers is [1, 2, 3, 4, 5])
{
    Console.WriteLine("The array is exactly [1, 2, 3, 4, 5].");
}
// Output: The array is exactly [1, 2, 3, 4, 5].

// has pattern 1, _, 3, _, 5 with wildcards
if (numbers is [1, _, 3, _, 5])
{
    Console.WriteLine("The array matches the pattern [1, _, 3, _, 5].");
}
// Output: The array matches the pattern [1, _, 3, _, 5].

// starts with 1, 2
if (numbers is [1, 2, ..])
{
    Console.WriteLine("The array starts with [1, 2].");
}
// Output: The array starts with [1, 2].

// ends with 4, 5
if (numbers is [.., 4, 5])
{
    Console.WriteLine("The array ends with [4, 5].");
}
// Output: The array ends with [4, 5].

// starts with [1, 2], [3, 4] (nested list)
int[][] nestedNumbers = { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } };

if (nestedNumbers is [[1, 2], [3, 4], ..])
{
    Console.WriteLine("The nested array starts with [1, 2] and [3, 4].");
}
// Output: The nested array starts with [1, 2] and [3, 4].


// starts with 1, 2
List<int> numberList = new List<int> { 1, 2, 3, 4, 5 };

if (numberList is [1, 2, ..])
{
    Console.WriteLine("The list starts with [1, 2].");
}
// Output: The list starts with [1, 2].

// can also have logic with variables like rest
if (numbers is [1, 2, 3, .. var rest] && rest.Length == 2)
{
    Console.WriteLine("The array starts with [1, 2, 3] and has exactly 2 more elements.");
}

// Usage
var person = new Person { Name = "John", Age = 30 };  // Valid

// Won't compile, Age is a required property and can't be null
// var errorPerson  = new Person { Name = "John" }; // Error: Age is required

// Raw string literal to write json:

string json = """
{
    "name": "John Doe",
    "age": 30,
    "isEmployed": true,
    "address": {
        "street": "123 Main St",
        "city": "Anytown",
        "state": "CA"
    }
}
""";
Console.WriteLine(json);

// custom task builder

static async CustomTask ProcessDataAsync()
{
    await Task.Delay(1000);  // Simulate asynchronous operation
    Console.WriteLine("Data processed");
}

 var task = ProcessDataAsync();
 task.GetAwaiter().GetResult();  // To keep the console open until async operation completes




// Reduce Nullability warnings:
string? input = Console.ReadLine();
if (input is not null)
{
    // The compiler understands 'input' is definitely not null here.
    Console.WriteLine(input.Length);
}