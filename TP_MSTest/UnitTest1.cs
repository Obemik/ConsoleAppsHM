using JournalNamespace; 

namespace JournalTests
{
    [TestClass]
    public class JournalTests
    {
        [TestMethod]
        public void TestSetJournalData_ValidData()
        {
            var journal = new Journal();
            journal.SetJournalData("Tech Magazine", 2005, "A magazine about technology and innovation.", "123-456-7890", "contact@techmag.com");

            Assert.AreEqual("Tech Magazine", journal.GetName());
            Assert.AreEqual(2005, journal.GetYearFounded());
            Assert.AreEqual("A magazine about technology and innovation.", journal.GetDescription());
            Assert.AreEqual("123-456-7890", journal.GetContactPhone());
            Assert.AreEqual("contact@techmag.com", journal.GetEmail());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetJournalData_EmptyName_ThrowsException()
        {
            var journal = new Journal();
            journal.SetJournalData("", 2005, "Description", "123-456-7890", "contact@techmag.com");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetJournalData_InvalidYear_ThrowsException()
        {
            var journal = new Journal();
            journal.SetJournalData("Tech Magazine", -1, "Description", "123-456-7890", "contact@techmag.com");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetJournalData_EmptyEmail_ThrowsException()
        {
            var journal = new Journal();
            journal.SetJournalData("Tech Magazine", 2005, "Description", "123-456-7890", "");
        }

        [TestMethod]
        public void TestGetJournalInfo()
        {
            var journal = new Journal();
            journal.SetJournalData("Tech Magazine", 2005, "A magazine about technology and innovation.", "123-456-7890", "contact@techmag.com");

            string expectedInfo = "Journal Name: Tech Magazine\n" +
                                  "Year Founded: 2005\n" +
                                  "Description: A magazine about technology and innovation.\n" +
                                  "Contact Phone: 123-456-7890\n" +
                                  "Email: contact@techmag.com";
            Assert.AreEqual(expectedInfo, journal.GetJournalInfo());
        }
    }
}
