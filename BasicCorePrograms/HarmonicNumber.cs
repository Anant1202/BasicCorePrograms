using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicNumber
    {
        public void harmonicValue()
        {
            Console.WriteLine("Enter the value of Harmonic Number N");
            int n=Convert.ToInt32(Console.ReadLine());
            float HN = 0, i;
            for (i = 1; i <=n; i++)
            {
                HN += (1 / i);
            }
            Console.WriteLine("Harmonic series is:"+ HN); 
            
            
        }
    
    }
}
