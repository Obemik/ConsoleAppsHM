using System;

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
        public decimal Salary { get; private set; } 

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

        public void SetSalary(decimal salary)
        {
            if (salary < 0)
                throw new ArgumentException("Salary cannot be negative.");
            Salary = salary;
        }

        public static Employee operator +(Employee employee, decimal increase)
        {
            employee.SetSalary(employee.Salary + increase);
            return employee;
        }

        public static Employee operator -(Employee employee, decimal decrease)
        {
            if (employee.Salary - decrease < 0)
                throw new ArgumentException("Salary cannot be negative after decrease.");
            employee.SetSalary(employee.Salary - decrease);
            return employee;
        }

        public static bool operator ==(Employee e1, Employee e2) => e1?.Salary == e2?.Salary;
        public static bool operator !=(Employee e1, Employee e2) => !(e1 == e2);
        public static bool operator >(Employee e1, Employee e2) => e1?.Salary > e2?.Salary;
        public static bool operator <(Employee e1, Employee e2) => e1?.Salary < e2?.Salary;

        public override bool Equals(object obj)
        {
            if (obj is Employee otherEmployee)
            {
                return Salary == otherEmployee.Salary;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Salary.GetHashCode();
        }

        public override string ToString()
        {
            return $"Full Name: {FullName}\n" +
                   $"Date of Birth: {DateOfBirth.ToShortDateString()}\n" +
                   $"Phone: {Phone}\n" +
                   $"Email: {Email}\n" +
                   $"Position: {Position}\n" +
                   $"Job Description: {JobDescription}\n" +
                   $"Salary: {Salary:C}";
        }
    }
}
