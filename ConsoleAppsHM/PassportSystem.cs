namespace PassportSystem
{
    public class Passport
    {
        public string FullName { get; private set; }
        public string PassportNumber { get; private set; }
        public string Citizenship { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public DateTime ExpirationDate { get; private set; }

        public Passport(string fullName, string passportNumber, string citizenship, DateTime dateOfBirth, DateTime expirationDate)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Full name cannot be empty.");
            if (string.IsNullOrWhiteSpace(passportNumber))
                throw new ArgumentException("Passport number cannot be empty.");
            if (string.IsNullOrWhiteSpace(citizenship))
                throw new ArgumentException("Citizenship cannot be empty.");
            if (expirationDate <= dateOfBirth)
                throw new ArgumentException("Expiration date must be after date of birth.");

            FullName = fullName;
            PassportNumber = passportNumber;
            Citizenship = citizenship;
            DateOfBirth = dateOfBirth;
            ExpirationDate = expirationDate;
        }

        public virtual string GetInfo()
        {
            return $"Full Name: {FullName}, Passport Number: {PassportNumber}, Citizenship: {Citizenship}, " +
                   $"Date of Birth: {DateOfBirth.ToShortDateString()}, Expiration Date: {ExpirationDate.ToShortDateString()}";
        }
    }

    public class ForeignPassport : Passport
    {
        public string ForeignPassportNumber { get; private set; }
        public List<string> Visas { get; private set; } = new List<string>();

        public ForeignPassport(string fullName, string passportNumber, string citizenship, DateTime dateOfBirth, DateTime expirationDate, string foreignPassportNumber)
            : base(fullName, passportNumber, citizenship, dateOfBirth, expirationDate)
        {
            if (string.IsNullOrWhiteSpace(foreignPassportNumber))
                throw new ArgumentException("Foreign passport number cannot be empty.");

            ForeignPassportNumber = foreignPassportNumber;
        }

        public void AddVisa(string visa)
        {
            if (string.IsNullOrWhiteSpace(visa))
                throw new ArgumentException("Visa cannot be empty.");
            Visas.Add(visa);
        }

        public void RemoveVisa(string visa)
        {
            Visas.Remove(visa);
        }

        public override string GetInfo()
        {
            var visasInfo = Visas.Count > 0 ? string.Join(", ", Visas) : "No visas";
            return base.GetInfo() + $", Foreign Passport Number: {ForeignPassportNumber}, Visas: {visasInfo}";
        }
    }
}
