using WebsiteNamespace;

class Program
{
    static void Main()
    {
        var website = new Website();

        website.SetWebsiteData("Google", "https://www.google.com", "Search Engine", "8.8.8.8");

        Console.WriteLine(website.GetWebsiteInfo());
    }
}