using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "-21";
          
            if (StringIsInt.CheckInt(str))
                Console.WriteLine("yes");
            else Console.WriteLine("no");
            Console.ReadKey();
        }
    }
}
