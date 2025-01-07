namespace EmployeeManagement
{
    public class Employee
    {
        public string FullName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Position { get; private set; }
        public string JobDescription { get; private set; }

        public void SetFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Full Name cannot be empty.");
            FullName = fullName;
        }

        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            if (dateOfBirth >= DateTime.Now)
                throw new ArgumentException("Date of birth must be in the past.");
            DateOfBirth = dateOfBirth;
        }

        public void SetPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Phone number cannot be empty.");
            Phone = phone;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                throw new ArgumentException("Invalid email.");
            Email = email;
        }

        public void SetPosition(string position)
        {
            if (string.IsNullOrWhiteSpace(position))
                throw new ArgumentException("Position cannot be empty.");
            Position = position;
        }

        public void SetJobDescription(string jobDescription)
        {
            JobDescription = jobDescription;
        }

        public override string ToString()
        {
            return $"Full Name: {FullName}\n" +
                   $"Date of Birth: {DateOfBirth.ToShortDateString()}\n" +
                   $"Phone: {Phone}\n" +
                   $"Email: {Email}\n" +
                   $"Position: {Position}\n" +
                   $"Job Description: {JobDescription}";
        }
    }
}
