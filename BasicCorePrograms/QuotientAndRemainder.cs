using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientAndRemainder
    {
        public void Compute()
        {
            Console.Write("Enter a number x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number y:");
            int y = Convert.ToInt32(Console.ReadLine());
            int Q = x / y;
            int R = x % y;
            Console.WriteLine("Quotient :" +Q);
            Console.WriteLine("Remainder :" + R);
        }
    }
}
