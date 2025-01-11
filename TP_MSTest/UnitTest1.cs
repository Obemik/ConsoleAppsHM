using MusicalInstrumentNamespace;

namespace MusicalInstrumentTests
{
    [TestClass]
    public class MusicalInstrumentTests
    {
        [TestMethod]
        public void TestViolinSound()
        {
            var violin = new Violin("Violin", "A string instrument.");
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                violin.Sound();
                Assert.AreEqual("Violin sound: Melodious string music...\r\n", sw.ToString());
            }
        }

        [TestMethod]
        public void TestTromboneSound()
        {
            var trombone = new Trombone("Trombone", "A brass instrument.");
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                trombone.Sound();
                Assert.AreEqual("Trombone sound: Powerful brass tones...\r\n", sw.ToString());
            }
        }

        [TestMethod]
        public void TestUkuleleSound()
        {
            var ukulele = new Ukulele("Ukulele", "A small string instrument.");
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                ukulele.Sound();
                Assert.AreEqual("Ukulele sound: Bright and cheerful strumming...\r\n", sw.ToString());
            }
        }

        [TestMethod]
        public void TestCelloSound()
        {
            var cello = new Cello("Cello", "A large string instrument.");
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                cello.Sound();
                Assert.AreEqual("Cello sound: Deep and resonant tones...\r\n", sw.ToString());
            }
        }

        [TestMethod]
        public void TestInstrumentNameAndDescription()
        {
            var instrument = new MusicalInstrument("Instrument", "Generic description.");
            Assert.AreEqual("Instrument", instrument.Name);
            Assert.AreEqual("Generic description.", instrument.Description);
        }
    }
}
