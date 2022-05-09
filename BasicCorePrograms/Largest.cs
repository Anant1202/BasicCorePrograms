using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Largest
    {
        public void LargestNum()
        {
            Console.WriteLine("Enter the numbers");
            Console.Write("num1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("num3:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("Num1:{0} is largest", num1);
            }
            else if(num2>num1 && num2>num3)
            {
                Console.WriteLine("Num2:{0} is largest",num2);
            }
            else
            {
                Console.WriteLine("Num3:{0} is largest", num3);
            }
        }
    }
}
