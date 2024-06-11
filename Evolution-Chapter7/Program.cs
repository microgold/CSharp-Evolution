
// See https://aka.ms/new-console-template for more information

// Example 1 - records
using System.Runtime.InteropServices;

var person1 = new Person("John", "Doe");
var person2 = new Person("John", "Doe");
Console.WriteLine(person1 == person2); // Output: True

// Example 2 - records with methods
Employee employee1 = new Employee("Alice", "Johnson");
Employee employee2 = new Employee("Bob", "Smith");

// Using the FullName method
Console.WriteLine(employee1.FullName());

// Using the static CreateAnonymous method
Employee anonymous = Employee.CreateAnonymous();
Console.WriteLine(anonymous);

// Using the Greet method
Console.WriteLine(employee1.Greet(employee2));

// Example 3 - records thread-safe
var person = new Person("John", "Doe");

Task task1 = Task.Run(() => DisplayPerson(person));
Task task2 = Task.Run(() => DisplayPerson(person));

Task.WaitAll(task1, task2);
    

 static void DisplayPerson(Person person)
{
    Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
}

var product = new Product { Name = "Laptop", Price = 999.99m };
// product.Name = "Tablet"; // Compiler error: Init-only property can only be assigned during initialization
Console.WriteLine($"{product.Name}, {product.Price}");

// top-level statements

Console.WriteLine("Starting program...");

if (args.Length > 0)
{
    Console.WriteLine($"Argument received: {args[0]}");
}

await FetchDataFromApiAsync();

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

async Task FetchDataFromApiAsync()
{
    HttpClient client = new HttpClient();
    string response = await client.GetStringAsync("https://www.google.com");
    PrintMessage(response.Substring(0, 100)); // Print only the first 100 characters
}

// relational patterns
int age = 34;
string lifeStage = age switch
{
    < 13 => "Child",
    < 20 => "Teenager",
    < 60 => "Adult",
    _ => "Senior"
};
Console.WriteLine(lifeStage); // Output: Adult

// logical patterns
bool isLetter(char c) => c switch
{
    >= 'a' and <= 'z' or >= 'A' and <= 'Z' => true,
    _ => false
};
Console.WriteLine(isLetter('x')); // Output: True

nint index = 5;
nuint length = 10;

Console.WriteLine($"Index: {index}, Length: {length}");

static void WriteAndReadUnmanagedMemory()
{
    // Allocate 100 bytes of unmanaged memory
    nuint size = 100;
    IntPtr memory = Marshal.AllocHGlobal((int)size);

    try
    {
        // Cast IntPtr to nint for arithmetic operations
        nint baseAddress = (nint)memory;

        // Write values to the allocated memory
        for (nuint i = 0; i < size; i++)
        {
            Marshal.WriteByte((IntPtr)(baseAddress + (nint)i), (byte)(i % 256));
        }

        // Read a value from a specific memory location
        nint offset = 50; // Go to the 50th byte
        byte value = Marshal.ReadByte((IntPtr)(baseAddress + offset));

        Console.WriteLine($"Value at offset {offset}: {value}");
    }
    finally
    {
        // Free the allocated memory
        Marshal.FreeHGlobal(memory);
    }
}

WriteAndReadUnmanagedMemory();