using System;

namespace BasicCorePrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs");
            Console.WriteLine("Enter number between 1 to 10 to check Programs");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    FlipCoin obj1 = new FlipCoin();
                    obj1.Percentage();
                    break;
                case 2:
                    LeapYear ob2 = new LeapYear();
                    ob2.checkingLeapYear();
                    break;
                case 3:
                    Powerof2 ob3 = new Powerof2();
                    ob3.calculatingPower();
                    break;
                case 4:
                    HarmonicNumber ob4 = new HarmonicNumber();
                    ob4.harmonicValue();
                    break;
                case 5:
                    PrimeFactor ob5 = new PrimeFactor();
                    ob5.findingPrimeFactors();
                    break;
                case 6:
                    QuotientAndRemainder ob6 = new QuotientAndRemainder();
                    ob6.Compute();
                    break;
                case 7:
                    Swap ob7 = new Swap();
                    ob7.swapTwoNumber();
                    break;
                case 8:
                    EvenOdd ob8 = new EvenOdd();
                    ob8.check();
                    break;
                case 9:
                    VowelOrConsonant ob9 = new VowelOrConsonant();
                    ob9.checkAlphabet();
                    break;
                case 10:
                    Largest ob10 = new Largest();
                    ob10.LargestNum();
                    break;
            }
        }
    }
}
