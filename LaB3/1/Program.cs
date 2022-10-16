using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку ");
            string str = Console.ReadLine();
            Console.WriteLine("Средняя длина слова равна {0}", Functions.CountingAvarageWordLength(str));
            Console.ReadKey(); 
        }       
    }
}
