using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeviceNamespace;

namespace DeviceTests
{
    [TestClass]
    public class DeviceTests
    {
        [TestMethod]
        public void TestKettleSound()
        {
            var kettle = new Kettle("Kettle", "A device used to boil water.");
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                kettle.Sound();
                Assert.AreEqual("Kettle sound: Whistling...\r\n", sw.ToString());
            }
        }

        [TestMethod]
        public void TestMicrowaveSound()
        {
            var microwave = new Microwave("Microwave", "A device used to heat food.");
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                microwave.Sound();
                Assert.AreEqual("Microwave sound: Beep beep...\r\n", sw.ToString());
            }
        }

        [TestMethod]
        public void TestCarSound()
        {
            var car = new Car("Car", "A motor vehicle used for transportation.");
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                car.Sound();
                Assert.AreEqual("Car sound: Vroom vroom...\r\n", sw.ToString());
            }
        }

        [TestMethod]
        public void TestSteamboatSound()
        {
            var steamboat = new Steamboat("Steamboat", "A vessel powered by steam.");
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                steamboat.Sound();
                Assert.AreEqual("Steamboat sound: Toot toot...\r\n", sw.ToString());
            }
        }

        [TestMethod]
        public void TestDeviceNameAndDescription()
        {
            var device = new Device("Device", "Generic device description.");
            Assert.AreEqual("Device", device.Name);
            Assert.AreEqual("Generic device description.", device.Description);
        }
    }
}
