using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "bb < b< > Это </ b > текст < i > с </ i > < font color =”red”> HTML </ font > кодами</ i > bb <gg";
            string rezult1 = Functions.ReturningEmailWithReg(str);
            Console.WriteLine(rezult1);
            string rezult2 = Functions.ReturningEmailWithoutReg(str);
            Console.WriteLine(rezult2);
            Console.ReadKey();
        }
    }
}
