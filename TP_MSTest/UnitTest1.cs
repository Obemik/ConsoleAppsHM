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

            Assert.AreEqual("Tech Magazine", journal.Name);
            Assert.AreEqual(2005, journal.YearFounded);
            Assert.AreEqual("A magazine about technology and innovation.", journal.Description);
            Assert.AreEqual("123-456-7890", journal.ContactPhone);
            Assert.AreEqual("contact@techmag.com", journal.Email);
        }

        [TestMethod]
        public void TestEmployeeCount_Increase()
        {
            var journal = new Journal();
            journal += 5;

            Assert.AreEqual(5, journal.EmployeeCount);
        }

        [TestMethod]
        public void TestEmployeeCount_Decrease()
        {
            var journal = new Journal();
            journal += 10;
            journal -= 3;

            Assert.AreEqual(7, journal.EmployeeCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEmployeeCount_NegativeValue_ThrowsException()
        {
            var journal = new Journal();
            journal -= 1; 
        }

        [TestMethod]
        public void TestEqualityOperator()
        {
            var journal1 = new Journal();
            var journal2 = new Journal();

            journal1 += 10;
            journal2 += 10;

            Assert.IsTrue(journal1 == journal2);
        }

        [TestMethod]
        public void TestInequalityOperator()
        {
            var journal1 = new Journal();
            var journal2 = new Journal();

            journal1 += 10;
            journal2 += 5;

            Assert.IsTrue(journal1 != journal2);
        }

        [TestMethod]
        public void TestComparisonOperators()
        {
            var journal1 = new Journal();
            var journal2 = new Journal();

            journal1 += 15;
            journal2 += 10;

            Assert.IsTrue(journal1 > journal2);
            Assert.IsTrue(journal2 < journal1);
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            var journal1 = new Journal();
            var journal2 = new Journal();

            journal1 += 20;
            journal2 += 20;

            Assert.IsTrue(journal1.Equals(journal2));
        }

        [TestMethod]
        public void TestGetJournalInfo()
        {
            var journal = new Journal();
            journal.SetJournalData("Tech Magazine", 2005, "A magazine about technology and innovation.", "123-456-7890", "contact@techmag.com");
            journal += 8;

            string expectedInfo = "Journal Name: Tech Magazine\n" +
                                  "Year Founded: 2005\n" +
                                  "Description: A magazine about technology and innovation.\n" +
                                  "Contact Phone: 123-456-7890\n" +
                                  "Email: contact@techmag.com\n" +
                                  "Employee Count: 8";

            Assert.AreEqual(expectedInfo, journal.GetJournalInfo());
        }
    }
}
