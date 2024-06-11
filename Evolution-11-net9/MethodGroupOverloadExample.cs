using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution_11_net9;

internal class MethodGroupOverloadExample
{
        public void PrintMessage(string message)
        {
            Console.WriteLine($"String: {message}");
        }

        public void PrintMessage(int number)
        {
            Console.WriteLine($"Integer: {number}");
        }

        public void Execute(Action<string> action)
        {
            action("Hello from string");
        }

        public void Execute(Action<int> action)
        {
            action(42);
        }
}
