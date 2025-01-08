using System;

namespace CreditCardExample
{
    public class CreditCard
    {
        public string CardNumber { get; private set; }
        public string CardHolderName { get; private set; }
        public string CVC { get; private set; }
        public DateTime ExpirationDate { get; private set; }

        public CreditCard(string cardNumber, string cardHolderName, string cvc, DateTime expirationDate)
        {
            SetCardNumber(cardNumber);
            SetCardHolderName(cardHolderName);
            SetCVC(cvc);
            SetExpirationDate(expirationDate);
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

        public override string ToString()
        {
            return $"Card Number: {CardNumber}\n" +
                   $"Card Holder: {CardHolderName}\n" +
                   $"CVC: {CVC}\n" +
                   $"Expiration Date: {ExpirationDate.ToShortDateString()}";
        }
    }
}
