using ReadingListApp;

namespace ReadingListTests
{
    [TestClass]
    public class ReadingListTests
    {
        [TestMethod]
        public void TestAddBook()
        {
            var list = new ReadingList();
            list.AddBook("The Great Gatsby");
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void TestRemoveBook()
        {
            var list = new ReadingList();
            list.AddBook("1984");
            Assert.IsTrue(list.RemoveBook("1984"));
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void TestContainsBook()
        {
            var list = new ReadingList();
            list.AddBook("To Kill a Mockingbird");
            Assert.IsTrue(list.ContainsBook("To Kill a Mockingbird"));
            Assert.IsFalse(list.ContainsBook("1984"));
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestIndexer_OutOfRange()
        {
            var list = new ReadingList();
            var book = list[0];
        }

        [TestMethod]
        public void TestEqualsOperator()
        {
            var list1 = new ReadingList();
            var list2 = new ReadingList();

            list1.AddBook("The Great Gatsby");
            list2.AddBook("The Great Gatsby");

            Assert.IsTrue(list1 == list2);
            Assert.IsFalse(list1 != list2);
        }

        [TestMethod]
        public void TestGetAllBooks()
        {
            var list = new ReadingList();
            list.AddBook("1984");
            list.AddBook("The Great Gatsby");
            Assert.AreEqual("1984, The Great Gatsby", list.GetAllBooks());
        }
    }
}