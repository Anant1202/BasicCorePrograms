using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Powerof2
    {
        public void calculatingPower()
        {
            Console.WriteLine("Enter the Power value N:");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                if (N <= 32)
                {
                    double Power =Math.Pow(2,i) ;
                    
                    Console.WriteLine("2^{0}={1}", i, Power);
                }
            }
            Console.WriteLine("Enter N value between 0 and 32");
        }
    }
}
