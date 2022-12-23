using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    static class StringIsInt
    {
        public static bool CheckInt(this string value)
        {
            if (value == null || value.Length == 0)
            {
                return false;
            }               
            var str = value.Trim();
            if (str.Length == 0)
            {
                return false;
            }
            foreach (var i in str)
            {
                if (!char.IsDigit(i))
                {
                    return false;
                }                  
            }
            return true;
        }
    }
}
