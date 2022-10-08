using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void ReplacingPozitiveNumbersWithZero(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if ((arr[i, j, k]) > 0)
                        { 
                        arr[i, j, k] = 0;
                        }
                    }
                }          
            };
        }


        static void Printing(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("\n z = {0}", i);
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write("{0}\t", arr[i, j, k]);
                    }
                    Console.WriteLine();
                }
            };
        }


        static void Main(string[] args)
        {
            int[,,] array = new int[2, 5, 5];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = rnd.Next(-50, 50);
                    }
                }              
            };
            Console.WriteLine("Созданый массив :");
            Printing(array);
            ReplacingPozitiveNumbersWithZero(array);
            Console.WriteLine("\nЗамена всех положительных чисел нулями :");
            Printing(array);
            Console.ReadKey();
        }
    }
}
