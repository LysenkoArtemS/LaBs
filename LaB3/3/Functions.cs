using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3
{
    internal class Functions
    {
        public static string CheckingIfStringEmail(string str)
        {
            Regex reg = new Regex(@"^[^\W_](?:[\w\-\.]*[^\W_])?@(?:[^\W_](?:[\w\-]*[^\W_])?\.){1,}[a-zA-Z]{2,6}$", RegexOptions.IgnoreCase);
            MatchCollection mc = reg.Matches(str);//w includes _
            foreach (Match match in mc)
            {
                return("строка является электронной почтой");
            };
            return ("строка НЕ является электронной почтой");
        }       
    }
}
