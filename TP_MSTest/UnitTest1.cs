using ArithmeticOperationsApp;

namespace ArithmeticOperationsAppTests
{
    [TestClass]
    public class ArithmeticOperationsTests
    {
        [TestMethod]
        public void TestIsEven()
        {
            var arithmeticOperations = new ArithmeticOperations();
            Predicate<int> isEven = new Predicate<int>(arithmeticOperations.IsEven);

            Assert.IsTrue(arithmeticOperations.ExecutePredicate(isEven, 4));
            Assert.IsFalse(arithmeticOperations.ExecutePredicate(isEven, 5));
        }

        [TestMethod]
        public void TestIsOdd()
        {
            var arithmeticOperations = new ArithmeticOperations();
            Predicate<int> isOdd = new Predicate<int>(arithmeticOperations.IsOdd);

            Assert.IsTrue(arithmeticOperations.ExecutePredicate(isOdd, 5));
            Assert.IsFalse(arithmeticOperations.ExecutePredicate(isOdd, 4));
        }

        [TestMethod]
        public void TestIsPrime()
        {
            var arithmeticOperations = new ArithmeticOperations();
            Predicate<int> isPrime = new Predicate<int>(arithmeticOperations.IsPrime);

            Assert.IsTrue(arithmeticOperations.ExecutePredicate(isPrime, 7));
            Assert.IsFalse(arithmeticOperations.ExecutePredicate(isPrime, 8));
        }

        [TestMethod]
        public void TestIsFibonacci()
        {
            var arithmeticOperations = new ArithmeticOperations();
            Predicate<int> isFibonacci = new Predicate<int>(arithmeticOperations.IsFibonacci);

            Assert.IsTrue(arithmeticOperations.ExecutePredicate(isFibonacci, 13));
            Assert.IsFalse(arithmeticOperations.ExecutePredicate(isFibonacci, 10));
        }
    }
}