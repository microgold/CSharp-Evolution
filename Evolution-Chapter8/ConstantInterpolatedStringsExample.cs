using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution_Chapter8
{
    public class ConstantInterpolatedStringsExample
    {
        const int value = 255;
        readonly string hexValue = $"Hexadecimal: {value:X}";
        readonly string decimalValue = $"Decimal: {value:D}";
        readonly string currencyValue = $"Currency: {value:C}";

        const string name = "World";
        const string greeting = $"Hello, {name}"; // This is evaluated at 

        public void DisplayInterpolatedString()
        {   
            Console.WriteLine(greeting);         // Output: "Hello, World"
            Console.WriteLine(hexValue);       // Output: "Hexadecimal: FF"
            Console.WriteLine(decimalValue);   // Output: "Decimal: 255"
            Console.WriteLine(currencyValue);  // Output: "Currency: $255.
        }
    }
}
