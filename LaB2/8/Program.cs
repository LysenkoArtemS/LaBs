using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = toolz.tools.CreatingArray();
            toolz.tools.FillingArray(array, 0, 10);
            toolz.tools.PrintingArray(array);
            int number = Functions.CheckingInt();
            int[] arrOfIndex = Functions.CreatingIndexArray(array, number);
            if (arrOfIndex.Length == 0)
            {
                Console.WriteLine("элементы не найдены");
            }
            else
            {
                toolz.tools.PrintingArray(arrOfIndex);
            }
            Console.ReadKey();
        }
    }
}
