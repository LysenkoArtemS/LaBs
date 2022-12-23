using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class PatternException : ArgumentException
    {
        public string Pattern { get; }
        
        public PatternException(string message, string patternAmmount)
            : base(message)
        {
            Pattern = patternAmmount;
        }
    }
}
