using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Swap
    {
        public void swapTwoNumber()
        {
            Console.Write("a:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("b:");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp= a;
            a=b;
            b=temp;
            Console.WriteLine("------After Swapping-------");
            Console.WriteLine("a:"+a);
            Console.WriteLine("b:"+b);
        }
    }
}
