using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class Stop_Watch
    {
        public static void StopWatch()
        {
            Console.WriteLine();
            Console.WriteLine("\nStopWatch Program");
            Console.WriteLine("Press any key to start the timer");
            Console.ReadKey();
            Console.WriteLine();
            var watch = System.Diagnostics.Stopwatch.StartNew(); 

            Console.Write("Press <Enter> to exit stopwatch... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                watch.Stop();
            }
            Console.WriteLine($"Execution Time : {watch.ElapsedMilliseconds} ms");
        }
    }
    
}
