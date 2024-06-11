using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution_Chapter13
{
    public class LockExample
    {
        private Lock _lock = new Lock();

        public void CriticalSection()
        {
            // Using the new Lock type to enter an exclusive scope
            using (_lock.EnterScope())
            {
                // Critical section code here
                Console.WriteLine("Entering critical section.");
                Thread.Sleep(1000);  // Simulate work
                Console.WriteLine("Exiting critical section.");
            }
        }
    }
}
