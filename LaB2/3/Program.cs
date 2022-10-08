using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static int SumOfPositiveNumbers(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
            
        }
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.Write("Массив : ");
            toolz.toolz.FillingArray(array);
            toolz.toolz.Printing1(array);
            int a = SumOfPositiveNumbers(array);
            Console.WriteLine("\nСумма положительных чисел равна {0}", a);
            Console.ReadKey();
        }
    }
}
