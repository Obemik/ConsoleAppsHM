using System;
using ReadingListApp;

class Program
{
    static void Main()
    {
        var readingList = new ReadingList();

        readingList += "The Great Gatsby";
        readingList += "To Kill a Mockingbird";
        readingList.AddBook("1984");

        Console.WriteLine("Books in reading list:");
        Console.WriteLine(readingList.GetAllBooks());

        readingList -= "1984";
        Console.WriteLine("\nAfter removing '1984':");
        Console.WriteLine(readingList.GetAllBooks());

        Console.WriteLine("\nContains 'To Kill a Mockingbird': " + readingList.ContainsBook("To Kill a Mockingbird"));

        Console.WriteLine("\nBook at index 0: " + readingList[0]);

        var anotherList = new ReadingList();
        anotherList += "The Great Gatsby";
        anotherList += "To Kill a Mockingbird";

        Console.WriteLine("\nLists are equal: " + (readingList == anotherList));
    }
}