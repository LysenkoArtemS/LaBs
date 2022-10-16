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
            int[] array = toolz.tools.CreatingArray();
            toolz.tools.FillingArrayKeyboard(array);
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("Массив по убыванию :");
            toolz.tools.PrintingArray(array);
            Console.ReadKey();
        }
    }
}
