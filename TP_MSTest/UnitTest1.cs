using WebsiteNamespace;

namespace WebsiteTests
{
    [TestClass]
    public class WebsiteTests
    {
        [TestMethod]
        public void TestSetWebsiteData_ValidData()
        {
            var website = new Website();
            website.SetWebsiteData("Google", "https://www.google.com", "Search Engine", "8.8.8.8");

            Assert.AreEqual("Google", website.GetName());
            Assert.AreEqual("https://www.google.com", website.GetUrl());
            Assert.AreEqual("Search Engine", website.GetDescription());
            Assert.AreEqual("8.8.8.8", website.GetIpAddress());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetWebsiteData_EmptyName_ThrowsException()
        {
            var website = new Website();
            website.SetWebsiteData("", "https://www.google.com", "Search Engine", "8.8.8.8");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetWebsiteData_EmptyUrl_ThrowsException()
        {
            var website = new Website();
            website.SetWebsiteData("Google", "", "Search Engine", "8.8.8.8");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetWebsiteData_EmptyIpAddress_ThrowsException()
        {
            var website = new Website();
            website.SetWebsiteData("Google", "https://www.google.com", "Search Engine", "");
        }

        [TestMethod]
        public void TestGetWebsiteInfo()
        {
            var website = new Website();
            website.SetWebsiteData("Google", "https://www.google.com", "Search Engine", "8.8.8.8");

            string expectedInfo = "Website Name: Google\nURL: https://www.google.com\nDescription: Search Engine\nIP Address: 8.8.8.8";
            Assert.AreEqual(expectedInfo, website.GetWebsiteInfo());
        }
    }
}
