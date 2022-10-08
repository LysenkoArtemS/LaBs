using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Printing(int[,] array)
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


        static int SumOfPozitionsOfEvenElements(int[,] array)
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


        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] arr = new int[3, 3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-10,10); 
                }
            }
            Printing(arr);
            int a = SumOfPozitionsOfEvenElements(arr);
            Console.WriteLine("\nСумма элеменов, стоящих на четной позиции равна {0}", a);
            Console.ReadKey();
        }
    }
}
