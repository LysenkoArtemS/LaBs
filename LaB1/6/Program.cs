using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double S;
            double p;
            Console.Write("a = ");
            bool result1 = double.TryParse(Console.ReadLine(), out a);
            Console.Write("b = ");
            bool result2 = double.TryParse(Console.ReadLine(), out b);
            Console.Write("c = ");
            bool result3 = double.TryParse(Console.ReadLine(), out c);
            p = (a + b + c) / 2;
            if ((result1 == true) && (result2 == true) && (result3 == true))
            {
                if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || c + b <= a || a + c <= b)
                {
                    Console.WriteLine("Треугольник не существует.");
                }
                else
                {
                    S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine("S = {0}", S);
                };
            }
            else
            {
                Console.WriteLine("Неправильно введённые данные");
            }
            Console.ReadKey();
        }
    }
}
