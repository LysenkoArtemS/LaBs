using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class ClassOfLists
    {
        public static List<Country> FillCountryList()
        {
            List<Country> countries = new List<Country>()
            {
            new Country(1, "Russia"),
            new Country(2, "United States")
            };

            return countries;
        }

        public static List<City> FillCityList()
        {
            List<City> cities = new List<City>()
            {
                new City(1, 1, "Saratov"),
                new City(2, 1, "Moscow"),
                new City(3, 2, "New York")
            };

            return cities;
        }

        public static List<Street> FillStreetList()
        {
            List<Street> streets = new List<Street>()
            {
                new Street(1, 1, "2nd Sadovaya"),
                new Street(2, 1, "Bolshaya Sadovaya"),
                new Street(3, 2, "Red Square"),
                new Street(4, 2, "Tverskaya "),
                new Street(5, 3, "Fifth Avenue")
            };

            return streets;
        }

        public static List<HomeAddress> FillHomeAddressList()
        {
            List<HomeAddress> homeAddresses = new List<HomeAddress>()
            {
                new HomeAddress(1, 1, "31-35", 1),
                new HomeAddress(2, 1, "17", 2),
                new HomeAddress(3, 2, "25", 32),
                new HomeAddress(4, 3, "45", 4),
                new HomeAddress(5, 4, "60", 55),
                new HomeAddress(6, 5, "71", 62)
            };

            return homeAddresses;
        }

        public static List<Person> FillPeopleList()
        {
            List<Person> people = new List<Person>()
            {
                new Person(1, "John", "Doe", new DateTime(1985, 1, 1), 2, 2),
                new Person(2, "Jane", "Doe", new DateTime(1987, 2, 2), 3, 4),
                new Person(3, "Bob", "Smith", new DateTime(1970, 3, 3), 5, null),
                new Person(4, "Alice", "Soprano", new DateTime(2000, 1, 5), 1, 1),
                new Person(5, "Adriane", "Maltisanti", new DateTime(2005, 3, 7), 2, 3),
                new Person(6, "James", "Fring", new DateTime(1998, 4, 4), 5, null),
                new Person(7, "Kate", "Salamca", new DateTime(1991, 2, 1), 3, 7),
                new Person(8, "Jimmy", "Shreder", new DateTime(1978, 3, 5), 1, 2),
                new Person(9, "Saul", "Goodman", new DateTime(1985, 3, 1), 3, 1),
                new Person(10, "Based", "Kiddy", new DateTime(2010, 3, 7), 4, 3)
            };

            return people;
        }
    }
        
}
/*
 Все эти объекты хранятся в коллекциях List. Написать запросы, которые:
1
Возвращают Фамилии и имена всех жителей старше 18 лет.
2
Возвращают Фамилии и Имена всех жителей города Саратов.
3
Возвращают названия городов, у которых есть улица, в названии которой встречается
«Садовая» (например: «2-я Садовая», «Большая Садовая»)
4
Возвращают Фамилии, имена и полный адрес всех жителей, занесенных в базу данных.
5
Возвращают средний возраст жителей дома №17, по адресу Россия, Саратов, ул. 2-я Садовая.*/