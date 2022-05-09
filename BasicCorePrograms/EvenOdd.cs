using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class EvenOdd
    {
        public void check()
        {
            Console.Write("Enter a number:");
            int num=Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
