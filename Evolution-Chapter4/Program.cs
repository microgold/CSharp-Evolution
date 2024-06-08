// Span<T> and Memory<T>

void ProcessSpan(Span<int> numbers)
{
    // Example operation on Span
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= 2;
    }
}

int[] array = { 1, 2, 3, 4 };
ProcessSpan(array); // Passing an array as a Span
Console.WriteLine(string.Join(", ", array)); // Output: 2, 4, 6, 8

async Task ProcessMemoryAsync(Memory<int> numbers)
{
    // Asynchronously process the numbers
    await Task.Delay(100); // Simulate async work

    // Use Memory<T> directly in async method
    var arraySegment = numbers.ToArray();
    for (int i = 0; i < arraySegment.Length; i++)
    {
        arraySegment[i] += 10;
    }

    // Copy the results back to the Memory
    arraySegment.CopyTo(numbers);
}

// using ref readonly and in to return a reference to the max element in an array
static void ShowMax()
{

    static ref readonly int FindMax(in int[] numbers)
    {
        int maxIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[maxIndex])
            {
                maxIndex = i;
            }
        }
        return ref numbers[maxIndex]; // Return a reference to the max element
    }

    int[] randomArray = { 1, 3, 5, 7, 6, 4, 2 };
    ref readonly int max = ref FindMax(randomArray);
    Console.WriteLine(max); // Output: 7
}



ShowMax();
await ProcessMemoryAsync(array); // Passing an array as Memory
Console.WriteLine(string.Join(", ", array)); // Output: 11, 12, 13, 14