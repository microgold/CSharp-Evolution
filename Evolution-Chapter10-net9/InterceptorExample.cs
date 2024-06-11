using System.Reflection;

namespace Evolution_Chapter10
{

    public class LoggingInterceptorAttribute : Attribute //  IInterceptor
    {
        public void Intercept(MethodBase method, object[] args)
        {
            Console.WriteLine($"Entering {method.Name}");
        }
    }

    public class InterceptorExample
    {
        [LoggingInterceptor]
        public void PerformAction()
        {
            Console.WriteLine("Action performed.");
        }
    }
      
}

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    sealed class InterceptsLocationAttribute(string filePath, int line, int column) : Attribute
    {
    }
}
