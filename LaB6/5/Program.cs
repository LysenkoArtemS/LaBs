using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _5.Methods;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2022, 12, 23);

            List<Country> countries = ClassOfLists.FillCountryList();
            List<City> cities = ClassOfLists.FillCityList();
            List<Street> streets = ClassOfLists.FillStreetList();
            List<HomeAddress> homeAddresses = ClassOfLists.FillHomeAddressList();
            List<Person> people = ClassOfLists.FillPeopleList();
            List<PersonsInfo> info = Methods.GetAllPeoplesInfo(people, homeAddresses, streets, cities, countries);



            var adults = Methods.GetPersonsThatYearsAbove18(info, date);
            foreach (var item in adults)
            {
                Console.WriteLine($"{item.Item1}, {item.Item2}");
            }

            Console.WriteLine("=========================================");

            var saratovPeople = Methods.GetSaratovPeople(info);

            foreach (var item in saratovPeople)
            {
                Console.WriteLine($"{item.Item1}, {item.Item2}");
            }

            Console.WriteLine("=========================================");

            var cityTitles = Methods.GetCityTitlesContainsSadovaya(info);

            foreach (var item in cityTitles)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("=========================================");

            var peoples = Methods.AllInfo(info);

            foreach (var item in peoples)
            {
                Console.WriteLine($"{item.Item1}, {item.Item2}, {item.Item3}, {item.Item4}, {item.Item5}, {item.Item6}, {item.Item7}");
            }

            Console.WriteLine("=========================================");

            var averageAge = Methods.GetAverageAgeOfRussiaSaratov2ndSadovskaya17HomeHumber(info, date);

            Console.WriteLine($"averageAge: {Math.Round(averageAge)}");
            Console.ReadKey();
        }
    }
}
