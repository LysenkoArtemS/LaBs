using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            Console.Write("a = ");
            bool result1 = double.TryParse(Console.ReadLine(), out a);
            Console.Write("b = ");
            bool result2 = double.TryParse(Console.ReadLine(), out b);      
            if (((a <= 0) || (b <= 0)) || (result1 == false) || (result2 == false))
            {
                Console.WriteLine("Некорректно введенные данные");
            }
            else
            {
                Console.WriteLine("S = {0}", a * b);
            }
            Console.ReadKey();
        }
    }
}
