using System;
using PassportApp; 

namespace PassportApp
{
    class Program
    {
        static void Main()
        {
            try
            {
                var passport = new ForeignPassport("AB1234567", "John Doe", new DateTime(2020, 5, 15), new DateTime(2030, 5, 15), "Ukrainian");

                Console.WriteLine(passport.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}