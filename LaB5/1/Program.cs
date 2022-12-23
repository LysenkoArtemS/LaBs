using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Aaa", "Bbb", "arrrr", DateTime.Parse("2009.11.23"));
            Console.WriteLine(user.ToString());
           // string a = "aaa, Cccc, Dddd, ar@mail.ru";
           // user.FillFromString(a);

          //  Console.WriteLine(user.ToString());
            Console.ReadKey();
        }
    }
}
