using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int arraySize2D = 3;
            int[,] arr = new int[arraySize2D, arraySize2D];
            Functions.FillingArray2D(arr,-10,10);
            Functions.PrintingArray2D(arr);
            int a = Functions.SumOfPozitionsOfEvenElements(arr);
            Console.WriteLine("\nСумма элеменов, стоящих на четной позиции равна {0}", a);
            Console.ReadKey();
        }
    }
}
