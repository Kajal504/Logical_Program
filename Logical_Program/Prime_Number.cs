using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class Prime_Number
    {
        public static void PrimeNumber()
        {
            Console.WriteLine();
            Console.WriteLine("Prime Number");
            int i, n, count = 0;
            Console.WriteLine("Enter any number to check whetner it is Prime Number or not");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
                Console.WriteLine("It is a Prime Number");
            else
                Console.WriteLine("It is Not a Prime Number");
        }

    }
}
