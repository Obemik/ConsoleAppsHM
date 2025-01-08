
using System;
using PassportApp;

namespace PassportAppTests
{
    [TestClass]
    public class ForeignPassportTests
    {
        [TestMethod]
        public void TestValidPassport()
        {
            var passport = new ForeignPassport("AB1234567", "John Doe", new DateTime(2020, 5, 15), new DateTime(2030, 5, 15), "Ukrainian");
            
            Assert.AreEqual("AB1234567", passport.PassportNumber);
            Assert.AreEqual("John Doe", passport.FullName);
            Assert.AreEqual(new DateTime(2020, 5, 15), passport.IssueDate);
            Assert.AreEqual(new DateTime(2030, 5, 15), passport.ExpiryDate);
            Assert.AreEqual("Ukrainian", passport.Nationality);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidPassportNumber()
        {
            var passport = new ForeignPassport("AB123", "John Doe", new DateTime(2020, 5, 15), new DateTime(2030, 5, 15), "Ukrainian");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIssueDateInTheFuture()
        {
            var passport = new ForeignPassport("AB1234567", "John Doe", DateTime.Now.AddDays(1), new DateTime(2030, 5, 15), "Ukrainian");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestExpiryDateBeforeIssueDate()
        {
            var passport = new ForeignPassport("AB1234567", "John Doe", new DateTime(2020, 5, 15), new DateTime(2019, 5, 15), "Ukrainian");
        }
    }
}