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
            CircleTask t1 = new CircleTask(3);
            Console.WriteLine(t1.LeftNumber());
            Console.ReadKey();
        }
    }
}
