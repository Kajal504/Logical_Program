using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class Reverse_A_Number
    {
        public static void ReverseNumber()
        {
            int num, num2, remainder, reverse = 0;
            Console.WriteLine("Enter a Number");
            num = int.Parse(Console.ReadLine());
            num2 = num;
            while (num > 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }
            Console.WriteLine("Given number is = {0}", num2);
            Console.WriteLine("Its reverse is = {0}", reverse);
            Console.ReadLine();
        }
    }
    
}
