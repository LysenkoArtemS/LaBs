using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class PatternException : ArgumentException
    {
        public string Pattern { get; }
        public DateTime Date { get; }
        public PatternException(string message, string patternAmmount)
            : base(message)
        {
            Pattern = patternAmmount;
        }
        public PatternException(string message, DateTime date)
           : base(message)
        {
            Date = date;
        }
    }
}
