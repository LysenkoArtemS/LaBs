using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Methods
    {


        public class PersonsInfo
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime Birthday { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public string HomeAdress { get; set; }
            public int Appartment { get; set; }

        }
        public static List<PersonsInfo> GetAllPeoplesInfo(List<Person> people, List<HomeAddress> homeAddresses, List<Street> streets, List<City> cities, List<Country> countries)
        {
            List<PersonsInfo> list = new List<PersonsInfo>();

            list = (from p in people
                    join h in homeAddresses on (p.LiveID ?? p.RegistrationID) equals h.ID
                    join s in streets on h.StreetID equals s.ID
                    join c in cities on s.CityID equals c.ID
                    join count in countries on c.CountryID equals count.ID
                    select new PersonsInfo
                    {
                        Name = p.FirstName,
                        Surname = p.LastName,
                        Birthday = p.Birthday,
                        Street = s.Title,
                        City = c.Title,
                        Country = count.Title,
                        HomeAdress = h.HomeNumber,
                        Appartment = h.Appartment
                    }).ToList();

            return list;
        }
        //-----------------------------------------------------------------//

        public static List<(string, string)> GetPersonsThatYearsAbove18(List<PersonsInfo> people, DateTime date)
        {
            List<(string, string)> list = new List<(string, string)>();
            list = (from p in people
                    where p.Birthday.AddYears(18) < date
                    select (p.Name, p.Surname)).ToList();

            return list;
        }


        public static List<(string, string)> GetSaratovPeople(List<PersonsInfo> people)
        {
            List<(string, string)> list = new List<(string, string)>();
            list = (from p in people
                    where p.City == "Saratov"
                    select (p.Name, p.Surname)).ToList();

            return list;
        }

        public static List<string> GetCityTitlesContainsSadovaya(List<PersonsInfo> cities)
        {
            List<string> list = new List<string>();

            list = ((from p in cities
                     where p.Street.Contains("Sadovaya")
                     select p.City)).Distinct().ToList();
            return list;
        }



        public static List<(string, string, string, string, string, string, int)> AllInfo(List<PersonsInfo> persons)
        {
            List<(string, string, string, string, string, string, int)> list =
        new List<(string, string, string, string, string, string, int)>();

            list = (from p in persons
                    select (p.Name, p.Surname, p.Country, p.City,p.Street, 
                   p.HomeAdress,p.Appartment)).ToList();

            return list;
        }

        public static double GetAverageAgeOfRussiaSaratov2ndSadovskaya17HomeHumber(List<PersonsInfo> persons, DateTime date)
        {
            double averageAge = (from p in persons
                                 where p.Country == "Russia" && p.City == "Saratov" && p.Street == "2nd Sadovaya"
                                 && p.HomeAdress == "17"
                                 select date.Year - p.Birthday.Year).Average();

            return averageAge;
        }

    }
}
