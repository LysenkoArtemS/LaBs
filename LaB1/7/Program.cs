using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a;
            byte b;
            Console.Write("a = ");
            bool result1 = byte.TryParse(Console.ReadLine(), out a);
            Console.Write("b = ");
            bool result2 = byte.TryParse(Console.ReadLine(), out b);

            if (result1 && result2 == true)
            {
                Console.WriteLine("побитовое и чисел {0} и {1} равно {2}", a, b, a & b);
                Console.WriteLine("побитовое или чисел {0} и {1} равно {2}", a, b, a | b);
                Console.WriteLine("побитовое исключающее или чисел {0} и {1} равно {2}", a, b, a ^ b);
            }
            else
            {
                Console.WriteLine("Неправильно введённые данные");
            }
            Console.ReadKey();
        }
    }
}
