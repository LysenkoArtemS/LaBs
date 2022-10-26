using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5
{
    internal class Functions
    {
        public static MatchCollection Matchns(string str)
        {
            Regex reg = new Regex(@"(?<day>0[1-9]|[12][0-9]|3[01])\-(?<month>0[0-9]|1[0-2])\-(?<year>[01][0-9][0-9][0-9]|20[01][0-9]|202[0-2])", RegexOptions.IgnoreCase);
            MatchCollection mc = reg.Matches(str);

            return mc;
        }
    }
}
