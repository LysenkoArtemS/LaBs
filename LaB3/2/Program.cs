using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку ");
            string str = Console.ReadLine();        
           if (Functions.CheckingIfPolindrom(str))
            {
                Console.WriteLine("является палиндромом");
            }
            else
            {
                Console.WriteLine("не является палиндромом.");
            }
            Console.ReadKey();
        }
    }
}
