using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void SearchingNumber(int[] arr, int zn)
        {
            int znach = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == zn)
                {
                    Console.Write("{0};", i);
                    znach++;
                }    
            };
            if (znach > 0)
            {
                Console.Write("<- индексы числа {0} ", zn);
            }
            else
            {
                Console.Write("Число {0} не найдено ", zn);
            }

        }

        static void Main(string[] args)
        {
            int number;
            Random rnd = new Random();
            int[] array = toolz.toolz.CreatingArray();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
            }
            toolz.toolz.Printing1(array);
            Console.Write("\nВведите искомое число : ");
            bool check = int.TryParse(Console.ReadLine(),out number);
            if (check == true)
            {
                SearchingNumber(array, number);
            }
            else
            {
                Console.WriteLine("Некорректное значение");
            }

            Console.ReadKey();
        }
    }
}
