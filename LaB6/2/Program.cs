using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "Peter Piper picked a peck of pickled peppers.A peck of pickled peppers Peter Piper picked.If Peter Piper picked a peck of pickled peppers, where is the peck that Peter Piper picked.";
            DictionaryTask d1 = new DictionaryTask(data);
            d1.PrintDictionary();
            Console.ReadKey();
        }
    }
}
