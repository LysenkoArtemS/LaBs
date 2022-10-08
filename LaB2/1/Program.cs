using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void SortingByMax(int[] arr)
        {
            int znach;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        znach = arr[i];
                        arr[i] = arr[j];
                        arr[j] = znach;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[20];
            Console.WriteLine("Исходный массив :");
            toolz.toolz.FillingArray(array);
            toolz.toolz.Printing1(array);
            SortingByMax(array);
            Console.WriteLine("\nОтсортированный массив :");
            toolz.toolz.Printing1(array);
            Console.WriteLine("\nМинимальное значение = {0}. Максимальное значение = {1}",
                                array[0], array[array.Length - 1]);
            Console.ReadKey();
        }
    }
}
