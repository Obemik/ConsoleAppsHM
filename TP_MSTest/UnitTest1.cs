using System;

namespace ProgrammerDayChecker.Tests
{
    [TestClass]
    public class ProgrammerDayTests
    {
        [TestMethod]
        public void TestIsProgrammersDay_LeapYear()
        {
            Func<DateTime, bool> isProgrammersDay = date => date.DayOfYear == 256;

            var testDate = new DateTime(2024, 9, 12); 
            Assert.IsTrue(isProgrammersDay(testDate), $"{testDate.ToShortDateString()} should be Programmer's Day.");
        }

        [TestMethod]
        public void TestIsProgrammersDay_NonLeapYear()
        {
            Func<DateTime, bool> isProgrammersDay = date => date.DayOfYear == 256;

            var testDate = new DateTime(2023, 9, 13); 
            Assert.IsTrue(isProgrammersDay(testDate), $"{testDate.ToShortDateString()} should be Programmer's Day.");
        }

        [TestMethod]
        public void TestIsNotProgrammersDay()
        {
            Func<DateTime, bool> isProgrammersDay = date => date.DayOfYear == 256;

            var testDate = new DateTime(2023, 1, 1); 
            Assert.IsFalse(isProgrammersDay(testDate), $"{testDate.ToShortDateString()} should not be Programmer's Day.");
        }
    }
}