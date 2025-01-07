using CityNamespace;

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
    }
}