namespace JournalNamespace
{
    public class Journal
    {
        public string Name { get; private set; }
        public int YearFounded { get; private set; }
        public string Description { get; private set; }
        public string ContactPhone { get; private set; }
        public string Email { get; private set; }

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
                   $"Email: {Email}";
        }

        public string GetName() => Name;
        public int GetYearFounded() => YearFounded;
        public string GetDescription() => Description;
        public string GetContactPhone() => ContactPhone;
        public string GetEmail() => Email;
    }
}