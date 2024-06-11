public class DefaultLambdaExample
{
    public void ShowDefaultLambda()
    {
        var incrementValue = (int source, int increment = 3) => source + increment;
        Console.WriteLine(incrementValue(5)); // output 8
    }

}


// Ref Readonly

public struct LargeData
{
    public readonly long[] Data;
    public LargeData(long[] data) => Data = data;
}

//var nameToAge = new Dictionary<string, int> {
//           ["Alice"] = 30,
//            ["Bob"] = 25,
//            ["Charlie"] = 35
//       };

//foreach (var kvp in nameToAge)
//{
//    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//}
