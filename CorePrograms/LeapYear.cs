using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class LeapYear
    {
        public void Check()
        {
            Console.WriteLine("Enter the year\n");
            string input = Console.ReadLine();
            if (input.Length != 4) Console.WriteLine("Enter The COrrect Year\n");
            else
            {
                int year = Convert.ToInt32(input);
                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    Console.WriteLine("Yes it is a Leap Year\n");
                }
                else
                {
                    Console.WriteLine("No it is  not a Leap Year\n");
                }
            }
        }
    }
}


