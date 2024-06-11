using System.Diagnostics.CodeAnalysis;

namespace Evolution_Chapter10
{
    public class ExperimentalTestExample
    {
        [Experimental("EXP401")]
        public void TestFeature() => Console.WriteLine("This feature is under development.");
    }
}
