using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PrimeFactor
    {
        public void findingPrimeFactors()
        {
            Console.WriteLine("Enter the number to find the prime fators");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <num; i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine("{0} is the prime factor of {1}", i, num);
                }
                
            }
        }
    }
}
