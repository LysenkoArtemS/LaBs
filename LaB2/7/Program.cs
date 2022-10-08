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
            int[] array = toolz.toolz.CreatingArray();
            toolz.toolz.FillingArrayKeyboard(array);
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("Массив по убыванию :");
            toolz.toolz.Printing1(array);
            Console.ReadKey();

        }
    }
}
