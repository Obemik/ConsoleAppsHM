

using AirplaneManagement;

namespace AirplaneManagementTests
{
    [TestClass]
    public class AirplaneTests
    {
        [TestMethod]
        public void TestSetAirplaneDetails_ValidData()
        {
            var airplane = new Airplane();
            airplane.SetAirplaneDetails("Boeing 747", "Boeing", 1968, "Passenger");
            Assert.AreEqual("Boeing 747", airplane.AirplaneName);
            Assert.AreEqual("Boeing", airplane.Manufacturer);
            Assert.AreEqual(1968, airplane.YearOfManufacture);
            Assert.AreEqual("Passenger", airplane.AirplaneType);
        }

        [TestMethod]
        public void TestSetAirplaneDetails_PartialData()
        {
            var airplane = new Airplane();
            airplane.SetAirplaneDetails("Airbus A320", "Airbus");
            Assert.AreEqual("Airbus A320", airplane.AirplaneName);
            Assert.AreEqual("Airbus", airplane.Manufacturer);
        }

        [TestMethod]
        public void TestGetAirplaneDetails()
        {
            var airplane = new Airplane("Cessna 172", "Cessna", 1955, "Private");
            string details = airplane.GetAirplaneDetails();
            Assert.IsTrue(details.Contains("Cessna 172"));
            Assert.IsTrue(details.Contains("Cessna"));
            Assert.IsTrue(details.Contains("1955"));
            Assert.IsTrue(details.Contains("Private"));
        }
    }
}