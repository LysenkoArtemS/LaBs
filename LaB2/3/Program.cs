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
            int[] array = new int[toolz.tools.arraySize];
            Console.Write("Массив : ");
            toolz.tools.FillingArray(array,-50,50);
            toolz.tools.PrintingArray(array);
            Console.WriteLine("\nСумма положительных чисел равна {0}", Functions.SumOfPositiveNumbers(array));
            Console.ReadKey();
        }
    }
}
