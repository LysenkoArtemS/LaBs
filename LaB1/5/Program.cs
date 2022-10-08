using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            int sum = 0;
            for (int i = 3; i < n; i++) 
            { 
                if (i % 3 == 0 || i % 5 == 0) 
                { 
                    sum += i; 
                }
            }
            Console.Write("Сумма чисел кратных 3 или 5 от 0 до 1000 = ");
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
