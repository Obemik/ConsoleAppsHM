using System;

namespace RainbowColor
{
    class Program
    {
        static void Main(string[] args)
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

            string color = "blue";
            string rgbValue = getRainbowColorRGB(color);
            Console.WriteLine($"The RGB value for {color} is: {rgbValue}");
        }
    }
}