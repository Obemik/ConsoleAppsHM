using EmployeeManagement;

class Program
{
    static void Main()
    {
        var employee = new Employee();

        employee.SetFullName("John Doe");
        employee.SetDateOfBirth(new DateTime(1985, 7, 15));
        employee.SetPhone("123-456-7890");
        employee.SetEmail("john.doe@example.com");
        employee.SetPosition("Software Developer");
        employee.SetJobDescription("Responsible for developing backend services.");

        Console.WriteLine(employee.ToString());
    }
}