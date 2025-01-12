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
            var card = new CreditCard("1234567890123456", "John Doe", "123", new DateTime(2025, 12, 31), 1000m);
            
            Assert.AreEqual("1234567890123456", card.CardNumber);
            Assert.AreEqual("John Doe", card.CardHolderName);
            Assert.AreEqual("123", card.CVC);
            Assert.AreEqual(new DateTime(2025, 12, 31), card.ExpirationDate);
            Assert.AreEqual(1000m, card.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInsufficientBalance()
        {
            var card = new CreditCard("1234567890123456", "John Doe", "123", new DateTime(2025, 12, 31), 1000m);
            card = card - 1500m;
        }

        [TestMethod]
        public void TestCreditCardOperators()
        {
            var card1 = new CreditCard("1234567890123456", "John Doe", "123", new DateTime(2025, 12, 31), 1000m);
            var card2 = new CreditCard("9876543210987654", "Jane Doe", "123", new DateTime(2025, 12, 31), 1500m);

            card1 = card1 + 500m;
            Assert.AreEqual(1500m, card1.Balance);

            card1 = card1 - 200m;
            Assert.AreEqual(1300m, card1.Balance);

            Assert.IsTrue(card1 == card2);

            Assert.IsTrue(card1 < card2);
            Assert.IsTrue(card2 > card1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidCVC()
        {
            var card = new CreditCard("1234567890123456", "John Doe", "12", new DateTime(2025, 12, 31), 1000m);
        }
    }
}
