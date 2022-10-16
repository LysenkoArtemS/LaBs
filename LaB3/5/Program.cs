using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку ");
            string str = Console.ReadLine();
            Functions.PrintingDates(str);
            Console.ReadKey();
        }
    }
}
