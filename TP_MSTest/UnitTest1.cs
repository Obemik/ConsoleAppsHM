using CityNamespace;
using System;
using System.Collections.Generic;

namespace CityTests
{
    [TestClass]
    public class CityUnitTests
    {
        [TestMethod]
        public void TestSetAndGetCityName()
        {
            var city = new City();
            city.SetCityName("Kyiv");

            Assert.AreEqual("Kyiv", city.GetCityName());
        }

        [TestMethod]
        public void TestSetAndGetCountryName()
        {
            var city = new City();
            city.SetCountryName("Ukraine");

            Assert.AreEqual("Ukraine", city.GetCountryName());
        }

        [TestMethod]
        public void TestSetAndGetPopulation()
        {
            var city = new City();
            city.SetPopulation(2800000);

            Assert.AreEqual(2800000, city.GetPopulation());
        }

        [TestMethod]
        public void TestSetAndGetPhoneCode()
        {
            var city = new City();
            city.SetPhoneCode("+380");

            Assert.AreEqual("+380", city.GetPhoneCode());
        }

        [TestMethod]
        public void TestSetAndGetDistricts()
        {
            var city = new City();
            var districts = new List<string> { "Shevchenkivskyi", "Podilskyi", "Pecherskyi" };
            city.SetDistricts(districts);

            CollectionAssert.AreEqual(districts, city.GetDistricts());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetNegativePopulation()
        {
            var city = new City();
            city.SetPopulation(-1000);
        }

        [TestMethod]
        public void TestPopulationIncreaseUsingPlusOperator()
        {
            var city = new City();
            city.SetPopulation(1000000);
            city = city + 500000;

            Assert.AreEqual(1500000, city.GetPopulation());
        }

        [TestMethod]
        public void TestPopulationDecreaseUsingMinusOperator()
        {
            var city = new City();
            city.SetPopulation(1000000);
            city = city - 200000;

            Assert.AreEqual(800000, city.GetPopulation());
        }

        [TestMethod]
        public void TestCitiesEqualityUsingEqualOperator()
        {
            var city1 = new City();
            city1.SetPopulation(1000000);

            var city2 = new City();
            city2.SetPopulation(1000000);

            Assert.IsTrue(city1 == city2);
        }

        [TestMethod]
        public void TestCitiesInequalityUsingNotEqualOperator()
        {
            var city1 = new City();
            city1.SetPopulation(1000000);

            var city2 = new City();
            city2.SetPopulation(2000000);

            Assert.IsTrue(city1 != city2);
        }

        [TestMethod]
        public void TestCitiesComparisonUsingLessThanOperator()
        {
            var city1 = new City();
            city1.SetPopulation(1000000);

            var city2 = new City();
            city2.SetPopulation(2000000);

            Assert.IsTrue(city1 < city2);
        }

        [TestMethod]
        public void TestCitiesComparisonUsingGreaterThanOperator()
        {
            var city1 = new City();
            city1.SetPopulation(2000000);

            var city2 = new City();
            city2.SetPopulation(1000000);

            Assert.IsTrue(city1 > city2);
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            var city1 = new City();
            city1.SetPopulation(1000000);

            var city2 = new City();
            city2.SetPopulation(1000000);

            Assert.IsTrue(city1.Equals(city2));
        }
    }
}
