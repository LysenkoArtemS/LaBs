using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            int[] array1 = new int[toolz.tools.arraySize];       
            int[] array2 = new int[toolz.tools.arraySize];
            Console.WriteLine("Первый массив ");
            toolz.tools.FillingArrayKeyboard(array1);
            Console.WriteLine("Второй массив ");
            toolz.tools.FillingArrayKeyboard(array2);
            Console.Write("Первый ");
            toolz.tools.PrintingArray(array1);
            Console.Write("\nВторой ");
            toolz.tools.PrintingArray(array2);
            if (Functions.CheckingArraysSame(array1, array2))
            {
                Console.WriteLine("Массивы одинаковы");
            }
            else
            {
                Console.WriteLine("Массивы не одинаковы");
            }
            Console.ReadKey();
        }
    }
}
