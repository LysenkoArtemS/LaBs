using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static int[] DoublingAmmountOfAllNegativeElements(int[] arr)
        {
            int number = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    number++;
                }
            }
            int j = 0;
            int[] freearr = new int[number];
            for (int i = 0; i < arr.Length; i++)
            {
                freearr[j] = arr[i];
                j++;
                if (arr[i] < 0)
                {
                    freearr[j] = arr[i];
                    j++;
                }         
            }
            return freearr;
        }

        static void Main(string[] args)
        {
            int[] array = new int[12];
            toolz.toolz.FillingArray(array);
            Console.WriteLine("Массив :");
            toolz.toolz.Printing1(array);
            array = DoublingAmmountOfAllNegativeElements(array);
            Console.WriteLine("\nМассив, в котором отрицательные числа записаны дважды :");
            toolz.toolz.Printing1(array);
            Console.ReadKey();
        }
    }
}
