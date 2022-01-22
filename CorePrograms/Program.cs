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
                Console.WriteLine("Enter 1 to select Replace String\n"+"Enter 2 to Flip a Coin\n"
                    +"Enter 3 to Check For leap Year\n"+"Enter 4 to Calculate Power of 2\n"+"Enter 5 to Calculate Value of Nth Harmonic number\n"
                    +"Enter 6 to Find Factors\n"+"Enter 7 to exit\n"); 
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
                        LeapYear year=new LeapYear();   
                        year.Check();   
                        break;
                    case 4:
                        PowerOfTwo powerOfTwo = new PowerOfTwo();
                        powerOfTwo.Pow();
                        break;
                    case 5:
                        HarmonicNumber harmonicNumber = new HarmonicNumber();
                        harmonicNumber.Find();
                        break;
                    case 6:
                        Factor factor = new Factor();
                        factor.Fact();
                        break;
                    case 7:
                        flag= false;
                        break;
                }
            }
        }
    }
}
