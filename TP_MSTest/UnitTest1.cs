using WorkerNamespace;
using System.IO;

namespace WorkerTests
{
    [TestClass]
    public class WorkerTests
    {
        [TestMethod]
        public void TestPresidentPrint()
        {
            var president = new President("Alice");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                president.Print();
                Assert.AreEqual("President: Alice - Oversees the entire organization.\r\n", sw.ToString());
            }
        }

        [TestMethod]
        public void TestSecurityPrint()
        {
            var security = new Security("Bob");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                security.Print();
                Assert.AreEqual("Security: Bob - Ensures safety and security at the workplace.\r\n", sw.ToString());
            }
        }

        [TestMethod]
        public void TestManagerPrint()
        {
            var manager = new Manager("Charlie");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                manager.Print();
                Assert.AreEqual("Manager: Charlie - Manages teams and projects.\r\n", sw.ToString());
            }
        }

        [TestMethod]
        public void TestEngineerPrint()
        {
            var engineer = new Engineer("Diana");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                engineer.Print();
                Assert.AreEqual("Engineer: Diana - Designs, develops, and maintains systems.\r\n", sw.ToString());
            }
        }
    }
}