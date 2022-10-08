using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество строк равно ");
            int a;
            bool result = int.TryParse(Console.ReadLine(), out a);
            if ((result == true) && (a > 0))
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Неверно введённые данные");
            }
            Console.ReadKey();
        }    
    }
}
