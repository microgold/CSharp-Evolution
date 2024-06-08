using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DataProcessor
{
    public void ProcessLargeData(in LargeData data)
    {
        // Process data without the ability to modify the original data structure
        Console.WriteLine(data.Value);
    }
}
