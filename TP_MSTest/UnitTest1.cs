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

            Assert.AreEqual("Tech Store", store.GetName());
            Assert.AreEqual("123 Main St, City", store.GetAddress());
            Assert.AreEqual("A store selling electronics and gadgets.", store.GetProfileDescription());
            Assert.AreEqual("123-456-7890", store.GetContactPhone());
            Assert.AreEqual("contact@techstore.com", store.GetEmail());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetStoreData_EmptyName_ThrowsException()
        {
            var store = new Store();
            store.SetStoreData("", "123 Main St, City", "A store selling electronics and gadgets.", "123-456-7890", "contact@techstore.com");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetStoreData_EmptyEmail_ThrowsException()
        {
            var store = new Store();
            store.SetStoreData("Tech Store", "123 Main St, City", "A store selling electronics and gadgets.", "123-456-7890", "");
        }

        [TestMethod]
        public void TestGetStoreInfo()
        {
            var store = new Store();
            store.SetStoreData("Tech Store", "123 Main St, City", "A store selling electronics and gadgets.", "123-456-7890", "contact@techstore.com");

            string expectedInfo = "Store Name: Tech Store\n" +
                                  "Address: 123 Main St, City\n" +
                                  "Profile Description: A store selling electronics and gadgets.\n" +
                                  "Contact Phone: 123-456-7890\n" +
                                  "Email: contact@techstore.com";
            Assert.AreEqual(expectedInfo, store.GetStoreInfo());
        }
    }
}
