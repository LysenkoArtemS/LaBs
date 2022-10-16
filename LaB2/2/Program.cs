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
        static void Main(string[] args)
        {
            const int arraySize3D = 5;
            int[,,] array = new int[arraySize3D, arraySize3D, arraySize3D];
            Functions.FillingArray3D(array,-50,50);
            Console.WriteLine("Созданый массив :");
            Functions.PrintingArray3D(array);
            Functions.ReplacingPozitiveNumbersWithZero(array);
            Console.WriteLine("\nЗамена всех положительных чисел нулями :");
            Functions.PrintingArray3D(array);
            Console.ReadKey();
        }
    }
}
