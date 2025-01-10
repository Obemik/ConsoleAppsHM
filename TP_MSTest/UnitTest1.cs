using StoreNamespace;

namespace StoreTests
{
    [TestClass]
    public class StoreTests
    {
        [TestMethod]
        public void TestSetStoreData_ValidData()
        {
            var store = new Store();
            store.SetStoreData("Tech Store", "123 Main St, City", "A store selling electronics and gadgets.", "123-456-7890", "contact@techstore.com");

            Assert.AreEqual("Tech Store", store.Name);
            Assert.AreEqual("123 Main St, City", store.Address);
            Assert.AreEqual("A store selling electronics and gadgets.", store.ProfileDescription);
            Assert.AreEqual("123-456-7890", store.ContactPhone);
            Assert.AreEqual("contact@techstore.com", store.Email);
        }

        [TestMethod]
        public void TestArea_Increase()
        {
            var store = new Store();
            store += 50.5;

            Assert.AreEqual(50.5, store.Area);
        }

        [TestMethod]
        public void TestArea_Decrease()
        {
            var store = new Store();
            store += 100.0;
            store -= 30.0;

            Assert.AreEqual(70.0, store.Area);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestArea_NegativeValue_ThrowsException()
        {
            var store = new Store();
            store -= 1.0; 
        }

        [TestMethod]
        public void TestEqualityOperator()
        {
            var store1 = new Store();
            var store2 = new Store();

            store1 += 100.0;
            store2 += 100.0;

            Assert.IsTrue(store1 == store2);
        }

        [TestMethod]
        public void TestInequalityOperator()
        {
            var store1 = new Store();
            var store2 = new Store();

            store1 += 100.0;
            store2 += 50.0;

            Assert.IsTrue(store1 != store2);
        }

        [TestMethod]
        public void TestComparisonOperators()
        {
            var store1 = new Store();
            var store2 = new Store();

            store1 += 200.0;
            store2 += 150.0;

            Assert.IsTrue(store1 > store2);
            Assert.IsTrue(store2 < store1);
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            var store1 = new Store();
            var store2 = new Store();

            store1 += 300.0;
            store2 += 300.0;

            Assert.IsTrue(store1.Equals(store2));
        }

        [TestMethod]
        public void TestGetStoreInfo()
        {
            var store = new Store();
            store.SetStoreData("Tech Store", "123 Main St, City", "A store selling electronics and gadgets.", "123-456-7890", "contact@techstore.com");
            store += 75.0;

            string expectedInfo = "Store Name: Tech Store\n" +
                                  "Address: 123 Main St, City\n" +
                                  "Profile Description: A store selling electronics and gadgets.\n" +
                                  "Contact Phone: 123-456-7890\n" +
                                  "Email: contact@techstore.com\n" +
                                  "Area: 75 square meters";

            Assert.AreEqual(expectedInfo, store.GetStoreInfo());
        }
    }
}
