using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static int[] RemovingAllNegativeElementsInArray(int[] arr)
        {
            int number = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    number++;
                }
            }
            int j = 0;
            int[] freearr= new int [number];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    freearr[j] = arr[i];
                    j++;
                }
            }
            return freearr;
        }

        static void Main(string[] args)
        {
            int[] array = new int[22];
            toolz.toolz.FillingArray(array);
            Console.WriteLine("Массив :");
            toolz.toolz.Printing1(array);
            array = RemovingAllNegativeElementsInArray(array);
            Console.WriteLine("\nМассив, в котором нет отрицательных чисел :");
            toolz.toolz.Printing1(array);
            Console.ReadKey();
        }
    }
}
