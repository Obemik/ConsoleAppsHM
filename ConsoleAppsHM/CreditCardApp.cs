using System;

namespace CreditCardApp
{
    public class CreditCard
    {
        public string CardNumber { get; private set; }
        public string CardHolder { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public string Pin { get; private set; }
        public double CreditLimit { get; private set; }
        public double Balance { get; private set; }

        public event Action<double> AccountDeposited;
        public event Action<double> AccountSpent;
        public event Action CreditLimitUsed;
        public event Action PinChanged;

        public CreditCard(string cardNumber, string cardHolder, DateTime expirationDate, string pin, double creditLimit)
        {
            CardNumber = cardNumber;
            CardHolder = cardHolder;
            ExpirationDate = expirationDate;
            Pin = pin;
            CreditLimit = creditLimit;
            Balance = 0; 
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount to deposit must be positive.");

            Balance += amount;
            AccountDeposited?.Invoke(amount);
        }

        public void Spend(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount to spend must be positive.");

            if (Balance + CreditLimit < amount)
                throw new InvalidOperationException("Not enough funds to complete the transaction.");

            Balance -= amount;
            AccountSpent?.Invoke(amount);  

            if (Balance < 0)
                CreditLimitUsed?.Invoke(); 
        }

        public void ChangePin(string newPin)
        {
            if (newPin.Length != 4)
                throw new ArgumentException("PIN must be exactly 4 digits.");

            Pin = newPin;
            PinChanged?.Invoke(); 
        }

        public void CheckCreditLimit()
        {
            if (Balance >= CreditLimit)
            {
                CreditLimitUsed?.Invoke();
            }
        }
    }
}
