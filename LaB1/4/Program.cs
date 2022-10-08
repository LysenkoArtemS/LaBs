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
            int a;
            int skip;
            int ammount;
            int strok = 1;
            Console.Write("количество треугольников равно ");
            bool result = int.TryParse(Console.ReadLine(), out a);
            if ((result == true) && (a > 0))
            {
                for (int i = 0; i < a; i++)
                {
                    skip = a;
                    ammount = 1;
                    for (int m = 0; m < strok; m++)
                    {
                        for (int j = 0; j < skip; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < ammount; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        skip--;
                        ammount += 2;
                    }
                    strok++;
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
