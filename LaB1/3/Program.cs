using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество строк равно ");
            int a;
            int skip;
            int ammount = 1;
            bool result = int.TryParse(Console.ReadLine(), out a);
            skip = a;
            if ((result == true) && (a > 0))
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < skip; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < ammount; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    skip--;
                    ammount += 2;
                }
            }
            else
            {
                Console.WriteLine("Неправильно введённые данные");
            }
            Console.ReadKey();
        }
    }
}
