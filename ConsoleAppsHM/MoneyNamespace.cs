using System;

namespace MoneyNamespace
{
    public class Money
    {
        public int Dollars { get; private set; }
        public int Cents { get; private set; }

        public Money(int dollars, int cents)
        {
            if (dollars < 0 || cents < 0 || cents >= 100)
                throw new ArgumentException("Invalid money values. Cents should be between 0 and 99.");
            Dollars = dollars;
            Cents = cents;
        }

        public void DisplayAmount()
        {
            Console.WriteLine($"{Dollars} dollars and {Cents} cents");
        }

        public void SetAmount(int dollars, int cents)
        {
            if (dollars < 0 || cents < 0 || cents >= 100)
                throw new ArgumentException("Invalid money values. Cents should be between 0 and 99.");
            Dollars = dollars;
            Cents = cents;
        }

        public decimal ToDecimal()
        {
            return Dollars + Cents / 100m;
        }

        public static Money operator +(Money m1, Money m2)
        {
            int totalCents = m1.Cents + m2.Cents;
            int totalDollars = m1.Dollars + m2.Dollars + totalCents / 100;
            totalCents %= 100;
            return new Money(totalDollars, totalCents);
        }

        public static Money operator -(Money m1, Money m2)
        {
            int totalCents = m1.Cents - m2.Cents;
            int totalDollars = m1.Dollars - m2.Dollars;

            if (totalCents < 0)
            {
                totalCents += 100;
                totalDollars--;
            }

            if (totalDollars < 0)
                throw new InvalidOperationException("Cannot have negative money.");

            return new Money(totalDollars, totalCents);
        }

        public static bool operator ==(Money m1, Money m2)
        {
            return m1.Dollars == m2.Dollars && m1.Cents == m2.Cents;
        }

        public static bool operator !=(Money m1, Money m2)
        {
            return !(m1 == m2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Money money)
                return this == money;
            return false;
        }

        public override int GetHashCode()
        {
            return (Dollars, Cents).GetHashCode();
        }
    }
}
