using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[toolz.tools.arraySize];
            toolz.tools.FillingArray(array, -50, 50);
            Console.WriteLine("Массив :");
            toolz.tools.PrintingArray(array);
            int[] finalArray = Functions.RemovingAllNegativeElementsInArray(array);
            Console.WriteLine("\nМассив, в котором нет отрицательных чисел :");
            toolz.tools.PrintingArray(finalArray);
            Console.ReadKey();
        }
    }
}
