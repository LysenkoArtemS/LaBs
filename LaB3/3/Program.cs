using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку ");
            string str =  Console.ReadLine();
            Console.WriteLine(Functions.CheckingIfStringEmail(str));          
            Console.ReadKey();
        }
    }
}
