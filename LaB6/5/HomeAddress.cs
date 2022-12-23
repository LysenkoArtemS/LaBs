using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class HomeAddress
    {
        public HomeAddress(int homeAdressId, int streetId, string homeNumber, int appartment)
        {
            ID = homeAdressId;
            HomeNumber = homeNumber;
            StreetID = streetId;
            Appartment = appartment;
        }
        public int ID { get; set; }
        public string HomeNumber { get; set; }
        public int Appartment { get; set; }
        public int StreetID { get; set; }
    }
}
