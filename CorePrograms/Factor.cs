using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class Factor
    {
        public void Fact()
        {
            Console.WriteLine("Enter the Number \n");
            Int64 number =Convert.ToInt64(Console.ReadLine());
            List<Int64> list = new List<Int64>();
            list.Add(1);
            for(int i = 2; i*i <= number; i++)
            {
                if (number % i == 0)
                {
                    list.Add(i);
                    list.Add(number/i);
                }
            }
            list.Add(number);
            list.Sort();
            Console.WriteLine("The Factor Of " + number + " are: ");
            for (int i = 0; i < list.Count; i++) Console.WriteLine(list[i] + " ");
            Console.WriteLine("\n");
        }
    }
}
