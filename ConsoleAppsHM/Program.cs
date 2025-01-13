using System;
using System.Collections.Generic;

namespace RainbowColorApp
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("Enter a rainbow color (e.g., Red, Green, Blue):");
            string inputColor = Console.ReadLine();

            try
            {
                var rgb = getColorRGB(inputColor);
                Console.WriteLine($"The RGB value for {inputColor} is: ({rgb.R}, {rgb.G}, {rgb.B})");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}