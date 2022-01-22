using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class PowerOfTwo
    {
        public void Pow()
        {
            Console.WriteLine("Enter the Power\n");
            int pwr=Convert.ToInt32(Console.ReadLine());
            Int64 ans = 1;
            for (int i = 0; i < pwr; i++)
            {
                ans *= 2;

            }
            if ((ans > 0) && (ans % 2) == 0)
            {
                Console.WriteLine("The Required Result is :" + ans);
            }
            else
            {
                Console.WriteLine("The Result must be two large therefore it over Flowed\n");
            }

        }
    }
}
