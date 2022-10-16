using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Functions
    {

        public static void PrintingArray2D(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine("\n");
            }
        }


        public static int SumOfPozitionsOfEvenElements(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }

        public static void FillingArray2D(int[,] array, int randomBegins, int randomEnds)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(randomBegins, randomEnds);
                }
            }
        }

    }
}
