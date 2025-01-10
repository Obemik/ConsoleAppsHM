using HumanHierarchy;

namespace HumanTests
{
    [TestClass]
    public class HumanTests
    {
        [TestMethod]
        public void TestHumanCreation_ValidData()
        {
            var human = new Human("Alice", 25);
            Assert.AreEqual("Alice", human.Name);
            Assert.AreEqual(25, human.Age);
            Assert.AreEqual("Name: Alice, Age: 25", human.GetInfo());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHumanCreation_InvalidAge()
        {
            var human = new Human("Alice", -5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHumanCreation_EmptyName()
        {
            var human = new Human("", 25);
        }

        [TestMethod]
        public void TestBuilderCreation_ValidData()
        {
            var builder = new Builder("John", 35, "Carpenter");
            Assert.AreEqual("John", builder.Name);
            Assert.AreEqual(35, builder.Age);
            Assert.AreEqual("Carpenter", builder.Specialty);
            Assert.AreEqual("Name: John, Age: 35, Specialty: Carpenter", builder.GetInfo());
            Assert.AreEqual("John is building a house.", builder.BuildHouse());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBuilderCreation_EmptySpecialty()
        {
            var builder = new Builder("John", 35, "");
        }

        [TestMethod]
        public void TestSailorCreation_ValidData()
        {
            var sailor = new Sailor("Mike", 40, "Captain");
            Assert.AreEqual("Mike", sailor.Name);
            Assert.AreEqual(40, sailor.Age);
            Assert.AreEqual("Captain", sailor.Rank);
            Assert.AreEqual("Name: Mike, Age: 40, Rank: Captain", sailor.GetInfo());
            Assert.AreEqual("Mike is navigating the ship.", sailor.Navigate());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSailorCreation_EmptyRank()
        {
            var sailor = new Sailor("Mike", 40, "");
        }

        [TestMethod]
        public void TestPilotCreation_ValidData()
        {
            var pilot = new Pilot("Anna", 30, "Airways Inc.");
            Assert.AreEqual("Anna", pilot.Name);
            Assert.AreEqual(30, pilot.Age);
            Assert.AreEqual("Airways Inc.", pilot.Airline);
            Assert.AreEqual("Name: Anna, Age: 30, Airline: Airways Inc.", pilot.GetInfo());
            Assert.AreEqual("Anna is flying a plane.", pilot.FlyPlane());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPilotCreation_EmptyAirline()
        {
            var pilot = new Pilot("Anna", 30, "");
        }
    }
}
