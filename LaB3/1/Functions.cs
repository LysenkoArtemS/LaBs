using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Functions
    {
        public static double CountingAvarageWordLength(string str)
        {
            double ammount = 0;
            double sum = 0;
            char[] charSepatators = new char[] { ' ', '.', ',', '?', '-', ':', ';' };
            string[] substr = str.Split(charSepatators,StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < substr.Length; i++)
            {
                    sum += substr[i].Length;
                    ammount++;
            }
            return (sum/ammount);
        }
    }
}
