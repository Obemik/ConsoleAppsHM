using CreditCardExample;
using System;

namespace CreditCardTests
{
    [TestClass]
    public class CreditCardTests
    {
        [TestMethod]
        public void TestValidCreditCard()
        {
            var card = new CreditCard("1234567890123456", "John Doe", "123", new DateTime(2025, 12, 31));
            
            Assert.AreEqual("1234567890123456", card.CardNumber);
            Assert.AreEqual("John Doe", card.CardHolderName);
            Assert.AreEqual("123", card.CVC);
            Assert.AreEqual(new DateTime(2025, 12, 31), card.ExpirationDate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidCardNumber()
        {
            var card = new CreditCard("123", "John Doe", "123", new DateTime(2025, 12, 31));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidCVC()
        {
            var card = new CreditCard("1234567890123456", "John Doe", "12", new DateTime(2025, 12, 31));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidExpirationDate()
        {
            var card = new CreditCard("1234567890123456", "John Doe", "123", new DateTime(2020, 12, 31));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEmptyCardHolderName()
        {
            var card = new CreditCard("1234567890123456", "", "123", new DateTime(2025, 12, 31));
        }
    }
}