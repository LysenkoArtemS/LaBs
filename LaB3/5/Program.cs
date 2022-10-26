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
            foreach (Match match in Functions.Matchns(str)) 
            {
                Console.WriteLine("{0}, где день = {1} , месяц = {2}, год = {3}",
                    match.Value, match.Groups["day"], match.Groups["month"], match.Groups["year"]);
            };
            Console.ReadKey();
        }
    }
}
