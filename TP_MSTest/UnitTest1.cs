using System;
using CreditCardApp;

namespace CreditCardAppTests
{
    [TestClass]
    public class CreditCardTests
    {
        private CreditCard _card;

        [TestInitialize]
        public void Setup()
        {
            _card = new CreditCard("1234567890123456", "John Doe", new DateTime(2025, 12, 31), "1234", 5000);
        }

        [TestMethod]
        public void TestDeposit()
        {
            double depositAmount = 1000;
            double expectedBalance = 1000;

            _card.Deposit(depositAmount);
            
            Assert.AreEqual(expectedBalance, _card.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDepositInvalidAmount()
        {
            _card.Deposit(-500);
        }

        [TestMethod]
        public void TestSpend()
        {
            _card.Deposit(2000);
            double spendAmount = 500;
            double expectedBalance = 1500;

            _card.Spend(spendAmount);

            Assert.AreEqual(expectedBalance, _card.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestSpendExceedingBalance()
        {
            _card.Spend(1000);
        }

        [TestMethod]
        public void TestChangePin()
        {
            string newPin = "5678";
            _card.ChangePin(newPin);

            Assert.AreEqual(newPin, _card.Pin);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestChangePinInvalidLength()
        {
            _card.ChangePin("123");
        }

        [TestMethod]
        public void TestCreditLimitUsage()
        {
            _card.Deposit(3000); 
            _card.Spend(3500);   
            
            bool eventTriggered = false;
            _card.CreditLimitUsed += () => eventTriggered = true;
            _card.Spend(1000); 
            Assert.IsTrue(eventTriggered);
        }
    }
}
