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
            int[] array = new int[toolz.tools.arraySize];
            Console.WriteLine("Исходный массив :");
            toolz.tools.FillingArray(array,-50,50);
            toolz.tools.PrintingArray(array);
            Console.WriteLine("\nМинимальное значение = {0}. Максимальное значение = {1}",
                                Functions.FindingMinInArray(array), Functions.FindingMaxInArray(array));
            Functions.SortingByMax(array);
            Console.WriteLine("\nОтсортированный массив :");
            toolz.tools.PrintingArray(array);
            
            Console.ReadKey();
        }
    }
}
