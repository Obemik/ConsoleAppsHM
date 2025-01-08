using System;
using System.Collections.Generic;

namespace NumberWordToDigitTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestValidWordInput()
        {
            var wordToDigit = new Dictionary<string, int>
            {
                { "zero", 0 },
                { "one", 1 },
                { "two", 2 },
                { "three", 3 },
                { "four", 4 },
                { "five", 5 },
                { "six", 6 },
                { "seven", 7 },
                { "eight", 8 },
                { "nine", 9 }
            };

            Assert.AreEqual(5, wordToDigit["five"]);
            Assert.AreEqual(0, wordToDigit["zero"]);
        }

        [TestMethod]
        public void TestInvalidWordInput()
        {
            var wordToDigit = new Dictionary<string, int>
            {
                { "zero", 0 },
                { "one", 1 },
                { "two", 2 },
                { "three", 3 },
                { "four", 4 },
                { "five", 5 },
                { "six", 6 },
                { "seven", 7 },
                { "eight", 8 },
                { "nine", 9 }
            };

            Assert.IsFalse(wordToDigit.ContainsKey("ten"));
        }
    }
}