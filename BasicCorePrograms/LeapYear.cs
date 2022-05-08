﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LeapYear
    {
        public void checkingLeapYear()
        {
            Console.Write("Enter Year in 4 digit number:");
            int year =Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year.", year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year.", year);
            }       
        }
    }
}
