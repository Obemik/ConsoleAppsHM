using System;

namespace JournalNamespace
{
    public class Journal
    {
        public string Name { get; private set; }
        public int YearFounded { get; private set; }
        public string Description { get; private set; }
        public string ContactPhone { get; private set; }
        public string Email { get; private set; }

        private int _employeeCount;
        public int EmployeeCount
        {
            get => _employeeCount;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Employee count cannot be negative.");
                _employeeCount = value;
            }
        }

        public void SetJournalData(string name, int yearFounded, string description, string contactPhone, string email)
        {
            if (string.IsNullOrWhiteSpace(name) || yearFounded <= 0 || string.IsNullOrWhiteSpace(contactPhone) || string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Name, year founded, contact phone, and email cannot be empty or invalid.");

            Name = name;
            YearFounded = yearFounded;
            Description = description;
            ContactPhone = contactPhone;
            Email = email;
        }

        public string GetJournalInfo()
        {
            return $"Journal Name: {Name}\n" +
                   $"Year Founded: {YearFounded}\n" +
                   $"Description: {Description}\n" +
                   $"Contact Phone: {ContactPhone}\n" +
                   $"Email: {Email}\n" +
                   $"Employee Count: {EmployeeCount}";
        }

        public static Journal operator +(Journal journal, int count)
        {
            journal.EmployeeCount += count;
            return journal;
        }

        public static Journal operator -(Journal journal, int count)
        {
            journal.EmployeeCount -= count;
            return journal;
        }

        public static bool operator ==(Journal a, Journal b)
        {
            return a?.EmployeeCount == b?.EmployeeCount;
        }

        public static bool operator !=(Journal a, Journal b)
        {
            return !(a == b);
        }

        public static bool operator >(Journal a, Journal b)
        {
            return a?.EmployeeCount > b?.EmployeeCount;
        }

        public static bool operator <(Journal a, Journal b)
        {
            return a?.EmployeeCount < b?.EmployeeCount;
        }

        public override bool Equals(object obj)
        {
            if (obj is Journal otherJournal)
            {
                return EmployeeCount == otherJournal.EmployeeCount;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return EmployeeCount.GetHashCode();
        }
    }
}
