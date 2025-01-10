using JournalNamespace;

class Program
{
    static void Main()
    {
        var journal1 = new Journal();
        journal1.SetJournalData("Tech Magazine", 2005, "A magazine about technology.", "123-456-7890", "contact@techmag.com");
        var journal2 = new Journal();
        journal2.SetJournalData("Science Weekly", 2010, "A science-focused magazine.", "987-654-3210", "info@scienceweekly.com");

        journal1 += 10; 
        journal2 += 5;  

        Console.WriteLine(journal1 > journal2); 
        Console.WriteLine(journal1 == journal2); 
    }
}