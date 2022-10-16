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
            int[] array = new int[toolz.tools.arraySize];
            toolz.tools.FillingArray(array, -50, 50);
            Console.WriteLine("Массив :");
            toolz.tools.PrintingArray(array);
            array = Functions.DoublingAmmountOfAllNegativeElements(array);
            Console.WriteLine("\nМассив, в котором отрицательные числа записаны дважды :");
            toolz.tools.PrintingArray(array);
            Console.ReadKey();
        }
    }
}
