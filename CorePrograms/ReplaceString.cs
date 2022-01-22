using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class ReplaceString
    {
       public void Replace()
        {
            Console.WriteLine("Enter your username\n");
            string name=Console.ReadLine();
            if (name.Length < 3) Console.WriteLine("Username minimum have 3 character\n");
            else Console.WriteLine("Hello " + name + " How are you ?");
        }
    }
}
