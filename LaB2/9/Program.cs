using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Compairing(int[] arr1, int[] arr2)
        {
            bool same = true;
            bool noRepeats = true;
            Array.Sort(arr1);
            Array.Sort(arr2);
            for (int i = 0; i < arr1.Length; i++)
            { 
                if ((arr1[i]) != (arr2[i]))
                {
                    same = false;
                }
                if ((i > 0) && ((arr1[i-1] == arr1[i]) || (arr2[i - 1] == arr2[i])))
                {
                    noRepeats = false;
                }
            }
            if ((same == true) && (noRepeats == true))
            {
                Console.WriteLine("\nМассивы одинаковы.");
            }
            else
            {
                if (noRepeats == false)
                {
                    Console.WriteLine("\nВ массивах есть одинаковые элементы");
                }
                else
                {
                    Console.WriteLine("\nМассивы различны.");
                }               
            }           
        }


        static void Main(string[] args)
        {
 
            int[] array1 = new int[2];       
            int[] array2 = new int[2];
            Console.WriteLine("Первый массив ");
            toolz.toolz.FillingArrayKeyboard(array1);
            Console.WriteLine("Второй массив ");
            toolz.toolz.FillingArrayKeyboard(array2);
            Console.Write("Первый ");
            toolz.toolz.Printing1(array1);
            Console.Write("\nВторой ");
            toolz.toolz.Printing1(array2);
            Compairing(array1, array2);
            Console.ReadKey();
        }
    }
}
