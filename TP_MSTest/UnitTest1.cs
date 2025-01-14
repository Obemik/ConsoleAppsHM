namespace RainbowColor.Tests
{
    [TestClass]
    public class RainbowColorTests
    {
        [TestMethod]
        public void TestGetRainbowColorRGB_Red()
        {
            Func<string, string> getRainbowColorRGB = (color) =>
            {
                switch (color.ToLower())
                {
                    case "red":
                        return "RGB(255, 0, 0)";
                    case "orange":
                        return "RGB(255, 165, 0)";
                    case "yellow":
                        return "RGB(255, 255, 0)";
                    case "green":
                        return "RGB(0, 255, 0)";
                    case "blue":
                        return "RGB(0, 0, 255)";
                    case "indigo":
                        return "RGB(75, 0, 130)";
                    case "violet":
                        return "RGB(238, 130, 238)";
                    default:
                        return "Unknown color";
                }
            };

            string result = getRainbowColorRGB("red");
            Assert.AreEqual("RGB(255, 0, 0)", result);
        }

        [TestMethod]
        public void TestGetRainbowColorRGB_Green()
        {
            Func<string, string> getRainbowColorRGB = (color) =>
            {
                switch (color.ToLower())
                {
                    case "red":
                        return "RGB(255, 0, 0)";
                    case "orange":
                        return "RGB(255, 165, 0)";
                    case "yellow":
                        return "RGB(255, 255, 0)";
                    case "green":
                        return "RGB(0, 255, 0)";
                    case "blue":
                        return "RGB(0, 0, 255)";
                    case "indigo":
                        return "RGB(75, 0, 130)";
                    case "violet":
                        return "RGB(238, 130, 238)";
                    default:
                        return "Unknown color";
                }
            };

            string result = getRainbowColorRGB("green");
            Assert.AreEqual("RGB(0, 255, 0)", result);
        }

        [TestMethod]
        public void TestGetRainbowColorRGB_UnknownColor()
        {
            Func<string, string> getRainbowColorRGB = (color) =>
            {
                switch (color.ToLower())
                {
                    case "red":
                        return "RGB(255, 0, 0)";
                    case "orange":
                        return "RGB(255, 165, 0)";
                    case "yellow":
                        return "RGB(255, 255, 0)";
                    case "green":
                        return "RGB(0, 255, 0)";
                    case "blue":
                        return "RGB(0, 0, 255)";
                    case "indigo":
                        return "RGB(75, 0, 130)";
                    case "violet":
                        return "RGB(238, 130, 238)";
                    default:
                        return "Unknown color";
                }
            };

            string result = getRainbowColorRGB("pink");
            Assert.AreEqual("Unknown color", result);
        }
    }
}