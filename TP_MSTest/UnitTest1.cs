using System;
using System.Collections.Generic;

namespace RainbowColorApp
{
    [TestClass]
    public class RainbowColorTests
    {
        [TestMethod]
        public void TestValidRainbowColor()
        {
            Func<string, (int R, int G, int B)> getColorRGB = delegate (string color)
            {
                var rainbowColors = new Dictionary<string, (int R, int G, int B)>
                {
                    { "Red", (255, 0, 0) },
                    { "Orange", (255, 165, 0) },
                    { "Yellow", (255, 255, 0) },
                    { "Green", (0, 128, 0) },
                    { "Blue", (0, 0, 255) },
                    { "Indigo", (75, 0, 130) },
                    { "Violet", (238, 130, 238) }
                };

                if (rainbowColors.TryGetValue(color, out var rgb))
                {
                    return rgb;
                }
                throw new ArgumentException($"Color '{color}' is not a valid rainbow color.");
            };

            var redRGB = getColorRGB("Red");
            Assert.AreEqual((255, 0, 0), redRGB);

            var blueRGB = getColorRGB("Blue");
            Assert.AreEqual((0, 0, 255), blueRGB);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidRainbowColor()
        {
            Func<string, (int R, int G, int B)> getColorRGB = delegate (string color)
            {
                var rainbowColors = new Dictionary<string, (int R, int G, int B)>
                {
                    { "Red", (255, 0, 0) },
                    { "Orange", (255, 165, 0) },
                    { "Yellow", (255, 255, 0) },
                    { "Green", (0, 128, 0) },
                    { "Blue", (0, 0, 255) },
                    { "Indigo", (75, 0, 130) },
                    { "Violet", (238, 130, 238) }
                };

                if (rainbowColors.TryGetValue(color, out var rgb))
                {
                    return rgb;
                }
                throw new ArgumentException($"Color '{color}' is not a valid rainbow color.");
            };

            getColorRGB("Pink");
        }
    }
}
