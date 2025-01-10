using MoneyNamespace;
using System;

namespace MoneyTests
{
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void TestMoneyAddition()
        {
            var money1 = new Money(10, 50);
            var money2 = new Money(5, 75);
            var result = money1 + money2;
            Assert.AreEqual(16, result.Dollars);
            Assert.AreEqual(25, result.Cents);
        }

        [TestMethod]
        public void TestMoneySubtraction()
        {
            var money1 = new Money(10, 50);
            var money2 = new Money(5, 75);
            var result = money1 - money2;
            Assert.AreEqual(4, result.Dollars);
            Assert.AreEqual(75, result.Cents);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestNegativeMoneySubtraction()
        {
            var money1 = new Money(5, 50);
            var money2 = new Money(10, 75);
            var result = money1 - money2;
        }

        [TestMethod]
        public void TestProductPriceReduction()
        {
            var money = new Money(10, 50);
            var product = new Product("Phone", money);
            product.ReducePrice(new Money(2, 50));
            Assert.AreEqual(8, product.Price.Dollars);
            Assert.AreEqual(0, product.Price.Cents);
        }

        [TestMethod]
        public void TestMoneyEquality()
        {
            var money1 = new Money(5, 75);
            var money2 = new Money(5, 75);
            Assert.IsTrue(money1 == money2);
        }

        [TestMethod]
        public void TestMoneyInequality()
        {
            var money1 = new Money(5, 75);
            var money2 = new Money(6, 75);
            Assert.IsTrue(money1 != money2);
        }
    }
}