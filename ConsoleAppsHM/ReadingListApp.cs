using System;
using System.Collections.Generic;

namespace ReadingListApp
{
    public class ReadingList
    {
        private List<string> books = new List<string>();

        public int Count => books.Count;

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= books.Count)
                    throw new IndexOutOfRangeException("Invalid index.");
                return books[index];
            }
        }

        public void AddBook(string book)
        {
            if (string.IsNullOrWhiteSpace(book))
                throw new ArgumentException("Book name cannot be empty.");
            books.Add(book);
        }

        public bool RemoveBook(string book) => books.Remove(book);

        public bool ContainsBook(string book) => books.Contains(book);

        public static ReadingList operator +(ReadingList list, string book)
        {
            list.AddBook(book);
            return list;
        }

        public static ReadingList operator -(ReadingList list, string book)
        {
            list.RemoveBook(book);
            return list;
        }

        public override bool Equals(object obj)
        {
            if (obj is ReadingList otherList)
            {
                if (this.Count != otherList.Count)
                    return false;

                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i] != otherList.books[i])
                        return false;
                }
                return true;
            }
            return false;
        }

        public override int GetHashCode() => books.GetHashCode();

        public static bool operator ==(ReadingList list1, ReadingList list2) => list1.Equals(list2);

        public static bool operator !=(ReadingList list1, ReadingList list2) => !list1.Equals(list2);

        public string GetAllBooks()
        {
            return books.Count == 0 ? "No books in the list." : string.Join(", ", books);
        }
    }
}
