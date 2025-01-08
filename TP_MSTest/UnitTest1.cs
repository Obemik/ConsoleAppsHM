using PalindromeChecker;

namespace PalindromeCheckerTests
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]
        public void TestIsPalindrome_ValidPalindrome()
        {
            Assert.IsTrue(Palindrome.IsPalindrome(1221));
            Assert.IsTrue(Palindrome.IsPalindrome(3443));
            Assert.IsTrue(Palindrome.IsPalindrome(5));
        }

        [TestMethod]
        public void TestIsPalindrome_NotPalindrome()
        {
            Assert.IsFalse(Palindrome.IsPalindrome(7854));
            Assert.IsFalse(Palindrome.IsPalindrome(1234));
        }

        [TestMethod]
        public void TestIsPalindrome_SingleDigit()
        {
            Assert.IsTrue(Palindrome.IsPalindrome(0));
            Assert.IsTrue(Palindrome.IsPalindrome(7));
        }

        [TestMethod]
        public void TestIsPalindrome_NegativeNumber()
        {
            Assert.IsTrue(Palindrome.IsPalindrome(-121));
            Assert.IsFalse(Palindrome.IsPalindrome(-123));
        }
    }
}