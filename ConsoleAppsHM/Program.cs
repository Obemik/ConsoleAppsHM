using EmployeeManagement;
using System;

namespace ConsoleAppsHM
{
    class Program
    {
        static void Main()
        {
            var employee1 = new Employee();
            employee1.SetFullName("John Doe");
            employee1.SetDateOfBirth(new DateTime(1990, 5, 20));
            employee1.SetPhone("123-456-7890");
            employee1.SetEmail("john.doe@example.com");
            employee1.SetPosition("Software Engineer");
            employee1.SetJobDescription("Develops software applications.");
            employee1.SetSalary(50000);

            var employee2 = new Employee();
            employee2.SetFullName("Jane Smith");
            employee2.SetDateOfBirth(new DateTime(1992, 8, 15));
            employee2.SetPhone("987-654-3210");
            employee2.SetEmail("jane.smith@example.com");
            employee2.SetPosition("Project Manager");
            employee2.SetJobDescription("Manages projects.");
            employee2.SetSalary(60000);

            Console.WriteLine("Employee 1 Details:");
            Console.WriteLine(employee1);
            Console.WriteLine();

            Console.WriteLine("Employee 2 Details:");
            Console.WriteLine(employee2);
            Console.WriteLine();

            Console.WriteLine($"Are salaries equal? {employee1 == employee2}");
            Console.WriteLine($"Is Employee 1's salary greater? {employee1 > employee2}");

            employee1 += 10000;  
            Console.WriteLine("\nAfter salary increase for Employee 1:");
            Console.WriteLine(employee1);
        }
    }
}