using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class FlipCoin
    {
        public void Percentage()
        {
            //Enter a positive integer
            Console.WriteLine("Enter the number of times to Flip a coin");
            int num=Convert.ToInt32(Console.ReadLine());
           
            double x=0, y=0;
            for (int i = 0; i < num; i++)
            {
                Random random = new Random();
                double getnum = random.NextDouble();
                Console.WriteLine("No.:"+getnum);
                if (getnum < 0.5)
                {
                    Console.WriteLine("Tails");
                    x++;
                }
                else
                {
                    Console.WriteLine("Heads");
                    y++;
                }
            }
            double Tail = x;
            double Per = Tail * 100;
            double Tailper = Per / num;
            Console.WriteLine("Tail percentage:" + Tailper);
            double Head = y;
            double Per1 = Head * 100;
            double Headper = Per1 / num;
            Console.WriteLine("Head percentage:" + Headper);
        }
    }
}
