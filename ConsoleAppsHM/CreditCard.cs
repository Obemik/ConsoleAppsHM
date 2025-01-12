using System;

namespace CreditCardExample
{
    public class CreditCard
    {
        public string CardNumber { get; private set; }
        public string CardHolderName { get; private set; }
        public string CVC { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public decimal Balance { get; private set; }

        public CreditCard(string cardNumber, string cardHolderName, string cvc, DateTime expirationDate, decimal balance)
        {
            SetCardNumber(cardNumber);
            SetCardHolderName(cardHolderName);
            SetCVC(cvc);
            SetExpirationDate(expirationDate);
            SetBalance(balance);
        }

        public void SetCardNumber(string cardNumber)
        {
            if (string.IsNullOrWhiteSpace(cardNumber) || cardNumber.Length != 16 || !IsDigitsOnly(cardNumber))
            {
                throw new ArgumentException("Card number must be 16 digits.");
            }
            CardNumber = cardNumber;
        }

        public void SetCardHolderName(string cardHolderName)
        {
            if (string.IsNullOrWhiteSpace(cardHolderName))
            {
                throw new ArgumentException("Card holder name cannot be empty.");
            }
            CardHolderName = cardHolderName;
        }

        public void SetCVC(string cvc)
        {
            if (string.IsNullOrWhiteSpace(cvc) || cvc.Length != 3 || !IsDigitsOnly(cvc))
            {
                throw new ArgumentException("CVC must be 3 digits.");
            }
            CVC = cvc;
        }

        public void SetExpirationDate(DateTime expirationDate)
        {
            if (expirationDate < DateTime.Now)
            {
                throw new ArgumentException("Expiration date cannot be in the past.");
            }
            ExpirationDate = expirationDate;
        }

        public void SetBalance(decimal balance)
        {
            if (balance < 0)
            {
                throw new ArgumentException("Balance cannot be negative.");
            }
            Balance = balance;
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }


        public static CreditCard operator +(CreditCard card, decimal amount)
        {
            card.SetBalance(card.Balance + amount);
            return card;
        }

        public static CreditCard operator -(CreditCard card, decimal amount)
        {
            if (card.Balance - amount < 0)
            {
                throw new ArgumentException("Insufficient balance.");
            }
            card.SetBalance(card.Balance - amount);
            return card;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return card1.CVC == card2.CVC;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return card1.CVC != card2.CVC;
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Balance < card2.Balance;
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Balance > card2.Balance;
        }

        public override bool Equals(object obj)
        {
            if (obj is CreditCard card)
            {
                return this.CVC == card.CVC;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return CVC.GetHashCode();
        }

        public override string ToString()
        {
            return $"Card Number: {CardNumber}\n" +
                   $"Card Holder: {CardHolderName}\n" +
                   $"CVC: {CVC}\n" +
                   $"Expiration Date: {ExpirationDate.ToShortDateString()}\n" +
                   $"Balance: {Balance:C}";
        }
    }
}
