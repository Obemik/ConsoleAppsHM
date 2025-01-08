using System;

namespace PassportApp
{
    public class ForeignPassport
    {
        public string PassportNumber { get; private set; }
        public string FullName { get; private set; }
        public DateTime IssueDate { get; private set; }
        public DateTime ExpiryDate { get; private set; }
        public string Nationality { get; private set; }

        public ForeignPassport(string passportNumber, string fullName, DateTime issueDate, DateTime expiryDate, string nationality)
        {
            SetPassportNumber(passportNumber);
            SetFullName(fullName);
            SetIssueDate(issueDate);
            SetExpiryDate(expiryDate);
            SetNationality(nationality);
        }

        public void SetPassportNumber(string passportNumber)
        {
            if (string.IsNullOrWhiteSpace(passportNumber) || passportNumber.Length != 9)
                throw new ArgumentException("Invalid passport number. It must be 9 characters long.");
            PassportNumber = passportNumber;
        }

        public void SetFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Full name cannot be empty.");
            FullName = fullName;
        }

        public void SetIssueDate(DateTime issueDate)
        {
            if (issueDate >= DateTime.Now)
                throw new ArgumentException("Issue date cannot be in the future.");
            IssueDate = issueDate;
        }

        public void SetExpiryDate(DateTime expiryDate)
        {
            if (expiryDate <= IssueDate)
                throw new ArgumentException("Expiry date must be later than the issue date.");
            ExpiryDate = expiryDate;
        }

        public void SetNationality(string nationality)
        {
            if (string.IsNullOrWhiteSpace(nationality))
                throw new ArgumentException("Nationality cannot be empty.");
            Nationality = nationality;
        }

        public override string ToString()
        {
            return $"Passport Number: {PassportNumber}\n" +
                   $"Full Name: {FullName}\n" +
                   $"Issue Date: {IssueDate.ToShortDateString()}\n" +
                   $"Expiry Date: {ExpiryDate.ToShortDateString()}\n" +
                   $"Nationality: {Nationality}";
        }
    }
}
