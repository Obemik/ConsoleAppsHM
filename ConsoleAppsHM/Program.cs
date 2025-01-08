using JournalNamespace; 

class Program
{
    static void Main()
    {
        var journal = new Journal();

        journal.SetJournalData("Tech Magazine", 2005, "A magazine about technology and innovation.", "123-456-7890", "contact@techmag.com");

        Console.WriteLine(journal.GetJournalInfo());
    }
}