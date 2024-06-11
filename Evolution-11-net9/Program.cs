using Evolution_11_net9;
using Evolution_Chapter13;
using System.Threading;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// params colleciton

new ParamsCollectionsExample().AddItems(1, 2, 3);

// new lock example

        var example = new LockExample();

        // Create multiple threads to test the lock
        var threads = new Thread[3];
        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(example.CriticalSection);
            threads[i].Start();
        }

        // Wait for all threads to complete
        foreach (var thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine("All threads completed.");

// New escape character

// Using the new \e escape sequence to represent the ESCAPE character
string escapeSequence = "\e[31mThis text is red!\e[0m";

// Displaying the string with the escape sequence
Console.WriteLine(escapeSequence);

// Alternative methods for the same escape character
string escapeSequenceAlt1 = "\u001b[31mThis text is red!\u001b[0m";
string escapeSequenceAlt2 = "\x1b[31mThis text is red!\x1b[0m";

// Displaying the alternative strings with escape sequences
Console.WriteLine(escapeSequenceAlt1);
Console.WriteLine(escapeSequenceAlt2);

// Method Group overload
var methodGroupExample = new MethodGroupOverloadExample();

methodGroupExample.Execute((Action<string>)methodGroupExample.PrintMessage);
methodGroupExample.Execute((Action<int>)methodGroupExample.PrintMessage);

// accessing elements at the end of an array using ^
int[] numbers = { 1, 2, 3, 4, 5 };

// Creating slices using ranges and the ^ operator
int[] lastTwo = numbers[^2..];      // Last two elements: { 4, 5 }
int[] middleThree = numbers[1..^1]; // Middle three elements: { 2, 3, 4 }

Console.WriteLine(string.Join(", ", lastTwo));   // Output: 4, 5
Console.WriteLine(string.Join(", ", middleThree)); // Output: 2, 3, 4

// accessing characters in a string
string text = "Hello, World!";

// Accessing characters from the end using the ^ operator
Console.WriteLine(text[^1]); // Output: !
Console.WriteLine(text[^2]); // Output: d

// using the ^ in object initializer to populate starting
// starting from the end of the array.
var countdown = new TimerRemaining(10)
{
    buffer =
            {
                [^1] = 0,
                [^2] = 1,
                [^3] = 2,
                [^4] = 3,
                [^5] = 4,
                [^6] = 5,
                [^7] = 6,
                [^8] = 7,
                [^9] = 8,
                [^10] = 9
            }
};

foreach (var item in countdown.buffer)
{
    Console.WriteLine(item);
}
// output is 9, 8, 7, 6, 5, 4, 3, 2, 1, 0