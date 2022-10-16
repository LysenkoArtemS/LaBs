using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Functions
    {
        public static void ReplacingPozitiveNumbersWithZero(int[,,] arr)
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
        public static void FillingArray3D(int[,,] arr, int randomBegins, int randomEnds)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = rnd.Next(randomBegins, randomEnds);
                    }
                }
            };
        }
        public static void PrintingArray3D(int[,,] arr)
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
    }

}
