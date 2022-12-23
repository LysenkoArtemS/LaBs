using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class Country
    {
        public Country(int countyId, string countryTitle)
        {
            ID = countyId;
            Title = countryTitle;
        }
        public int ID {get;set;}
        public string Title { get; set; }
    }
}
