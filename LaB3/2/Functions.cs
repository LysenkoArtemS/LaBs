using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Functions
    {
        public static bool CheckingIfPolindrom(string str)
        {
            char[] str1 = str.ToUpper().ToCharArray();
            var poli = new StringBuilder();
            for (int i = 0; i < str1.Length; i++)
            {
                if (char.IsLetter(str1[i]))
                {
                    poli.Append(str1[i]);
                }
            };
            char[] str2 = poli.ToString().ToCharArray();
            Array.Reverse(str2);
            string reversedPoli = new string(str2);
            if (poli.ToString() == reversedPoli)
             {
                 return true;
             }
             else
             {
                 return false;
             }
        }
    }
}
