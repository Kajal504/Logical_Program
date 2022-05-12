using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class Coupon_Number
    {
        public static void CouponNumber()
        {
            int Number;
            Console.WriteLine("Enter your Number");
            Number = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int Num = random.Next(0, Number);
            Console.WriteLine(Num);
        }
    }
    
}
