using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class Street
    {
        public Street(int streetId, int cityId, string streetTitle)
        {
            ID = streetId;
            Title = streetTitle;
            CityID = cityId;
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public int CityID { get; set; }
    }
}
