namespace LambdaExample.Tests
{
    [TestClass]
    public class LambdaTests
    {
        [TestMethod]
        public void TestContainsWord_Found()
        {
            string text = "The quick brown fox jumps over the lazy dog";

            Func<string, bool> containsWord = word => text.Contains(word, StringComparison.OrdinalIgnoreCase);

            string wordToSearch = "fox";
            bool result = containsWord(wordToSearch);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestContainsWord_NotFound()
        {
            string text = "The quick brown fox jumps over the lazy dog";

            Func<string, bool> containsWord = word => text.Contains(word, StringComparison.OrdinalIgnoreCase);

            string wordToSearch = "cat";
            bool result = containsWord(wordToSearch);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestContainsWord_CaseInsensitive()
        {
            string text = "The quick brown fox jumps over the lazy dog";

            Func<string, bool> containsWord = word => text.Contains(word, StringComparison.OrdinalIgnoreCase);

            string wordToSearch = "FOX";
            bool result = containsWord(wordToSearch);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestContainsWord_EmptyText()
        {
            string text = "";

            Func<string, bool> containsWord = word => text.Contains(word, StringComparison.OrdinalIgnoreCase);

            string wordToSearch = "fox";
            bool result = containsWord(wordToSearch);

            Assert.IsFalse(result);
        }
    }
}
