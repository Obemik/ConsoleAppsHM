namespace LambdaExample.Tests
{
    [TestClass]
    public class LambdaTests
    {
        [TestMethod]
        public void TestContainsWord_ValidInput_ContainsWord()
        {
            string text = "This is an example of a simple text checking program.";
            string wordToFind = "example";
            Func<string, string, bool> containsWord = (inputText, word) =>
                !string.IsNullOrWhiteSpace(inputText) && inputText.Contains(word, StringComparison.OrdinalIgnoreCase);

            bool result = containsWord(text, wordToFind);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestContainsWord_ValidInput_DoesNotContainWord()
        {
            string text = "This is an example of a simple text checking program.";
            string wordToFind = "missing";
            Func<string, string, bool> containsWord = (inputText, word) =>
                !string.IsNullOrWhiteSpace(inputText) && inputText.Contains(word, StringComparison.OrdinalIgnoreCase);

            bool result = containsWord(text, wordToFind);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestContainsWord_EmptyText()
        {
            string text = "";
            string wordToFind = "example";
            Func<string, string, bool> containsWord = (inputText, word) =>
                !string.IsNullOrWhiteSpace(inputText) && inputText.Contains(word, StringComparison.OrdinalIgnoreCase);

            bool result = containsWord(text, wordToFind);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestContainsWord_NullText()
        {
            string text = null;
            string wordToFind = "example";
            Func<string, string, bool> containsWord = (inputText, word) =>
                !string.IsNullOrWhiteSpace(inputText) && inputText.Contains(word, StringComparison.OrdinalIgnoreCase);

            bool result = containsWord(text, wordToFind);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestContainsWord_CaseInsensitive()
        {
            string text = "This is an Example of a simple text checking program.";
            string wordToFind = "example";
            Func<string, string, bool> containsWord = (inputText, word) =>
                !string.IsNullOrWhiteSpace(inputText) && inputText.Contains(word, StringComparison.OrdinalIgnoreCase);

            bool result = containsWord(text, wordToFind);

            Assert.IsTrue(result);
        }
    }
}
