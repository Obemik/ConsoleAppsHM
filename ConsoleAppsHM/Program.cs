using System;

namespace ProgrammerDayChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<DateTime, bool> isProgrammersDay = date => date.DayOfYear == 256;

            var testDate1 = new DateTime(2024, 9, 12); 
            Console.WriteLine($"{testDate1.ToShortDateString()} is Programmer's Day: {isProgrammersDay(testDate1)}");

            var testDate2 = new DateTime(2023, 9, 13); 
            Console.WriteLine($"{testDate2.ToShortDateString()} is Programmer's Day: {isProgrammersDay(testDate2)}");

            var testDate3 = new DateTime(2023, 1, 1); 
            Console.WriteLine($"{testDate3.ToShortDateString()} is Programmer's Day: {isProgrammersDay(testDate3)}");
        }
    }
}