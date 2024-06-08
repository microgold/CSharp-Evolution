using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution_Chapter6
{
    internal class AsycStreamSimpleExample
    {
        public async IAsyncEnumerable<int> GetNumbersAsync()
        {
            for (int i = 0; i < 5; i++)
            {
                await Task.Delay(1000); // Simulate async work
                yield return i;
            }
        }

        public async Task DisplayAsyncNumbers()
        {
            await foreach (var number in GetNumbersAsync())
            {
                Console.WriteLine(number);
            }
        }
    }
}
