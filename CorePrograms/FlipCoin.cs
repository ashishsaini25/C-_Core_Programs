using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class FlipCoin
    {
        public void Toss()
        {
            double head = 0, tail = 0;
            Console.WriteLine("Enter the number of the coin is tossed\n");
            int repeat=Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < repeat; i++)
            {
                
                double rand=random.NextDouble();
                Console.WriteLine(rand + " ");
                if (rand < 0.5) tail++;
                else head++;

            }
            double headpercentage=(head/repeat)*100;
            Console.WriteLine("Percentage of getting head is :" + headpercentage + "\n");
            Console.WriteLine("Percentage of getting tail is :" + (100 - headpercentage) + "\n");
        }

    }
}
