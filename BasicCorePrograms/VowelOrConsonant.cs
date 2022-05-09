using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class VowelOrConsonant
    {
        public void checkAlphabet()
        {
            Console.WriteLine("Enter an Alphabet:");
            char ch = Convert.ToChar(Console.Read());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("{0} is a Vowel", ch);
            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'z'))
            {
                Console.WriteLine("{0} is a Consonant", ch);
            }


        }
    }
}
