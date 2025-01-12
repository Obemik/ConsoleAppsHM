using System;
using System.Collections.Generic;

namespace CityNamespace
{
    public class City
    {
        private string _cityName;
        private string _countryName;
        private int _population;
        private string _phoneCode;
        private List<string> _districts;

        public City()
        {
            _districts = new List<string>();
        }

        public void SetCityName(string cityName) => _cityName = cityName;
        public void SetCountryName(string countryName) => _countryName = countryName;
        public void SetPopulation(int population)
        {
            if (population < 0) throw new ArgumentException("Population cannot be negative.");
            _population = population;
        }
        public void SetPhoneCode(string phoneCode) => _phoneCode = phoneCode;
        public void SetDistricts(List<string> districts) => _districts = new List<string>(districts);

        public string GetCityName() => _cityName;
        public string GetCountryName() => _countryName;
        public int GetPopulation() => _population;
        public string GetPhoneCode() => _phoneCode;
        public List<string> GetDistricts() => new List<string>(_districts);

        public void DisplayCityInfo()
        {
            Console.WriteLine($"City Name: {_cityName}");
            Console.WriteLine($"Country Name: {_countryName}");
            Console.WriteLine($"Population: {_population}");
            Console.WriteLine($"Phone Code: {_phoneCode}");
            Console.WriteLine("Districts:");
            _districts.ForEach(district => Console.WriteLine($"- {district}"));
        }

        public static City operator +(City city, int populationIncrease)
        {
            city._population += populationIncrease;
            return city;
        }

        public static City operator -(City city, int populationDecrease)
        {
            city._population -= populationDecrease;
            if (city._population < 0) city._population = 0;
            return city;
        }

        public static bool operator ==(City city1, City city2)
        {
            return city1._population == city2._population;
        }

        public static bool operator !=(City city1, City city2)
        {
            return city1._population != city2._population;
        }

        public static bool operator <(City city1, City city2)
        {
            return city1._population < city2._population;
        }

        public static bool operator >(City city1, City city2)
        {
            return city1._population > city2._population;
        }

        public override bool Equals(object obj)
        {
            if (obj is City otherCity)
            {
                return _population == otherCity._population;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _population.GetHashCode();
        }
    }
}
