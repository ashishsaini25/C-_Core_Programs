using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter 1 to select Replace String\n"+"Enter 2 to Flip a Coin\n"); 
                int  n=Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        ReplaceString replaceString = new ReplaceString();
                        replaceString.Replace();
                        break;
                    case 2:
                        FlipCoin flipCoin  = new FlipCoin();
                        flipCoin.Toss();
                        break;
                    case 3:
                        flag= false;
                        break;
                }
            }
        }
    }
}
