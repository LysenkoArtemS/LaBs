using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class City
    {
        public City(int cityId, int countryId, string cityTitle)
        {
            ID = cityId;
            Title = cityTitle;
            CountryID = countryId;
        }
        public int  ID { get; set; }
        public string Title { get; set; }
        public int CountryID { get; set; }
    }
}
