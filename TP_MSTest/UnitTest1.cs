using ArithmeticOperationsApp;

namespace ArithmeticOperationsAppTests
{
    [TestClass]
    public class ArithmeticOperationsTests
    {
        [TestMethod]
        public void TestAddOperation()
        {
            var arithmeticOperations = new ArithmeticOperations();

            ArithmeticOperation addOperation = new ArithmeticOperation(arithmeticOperations.Add);
            double result = arithmeticOperations.ExecuteOperation(addOperation, 5, 3);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestSubtractOperation()
        {
            var arithmeticOperations = new ArithmeticOperations();

            ArithmeticOperation subtractOperation = new ArithmeticOperation(arithmeticOperations.Subtract);
            double result = arithmeticOperations.ExecuteOperation(subtractOperation, 5, 3);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMultiplyOperation()
        {
            var arithmeticOperations = new ArithmeticOperations();

            ArithmeticOperation multiplyOperation = new ArithmeticOperation(arithmeticOperations.Multiply);
            double result = arithmeticOperations.ExecuteOperation(multiplyOperation, 5, 3);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestAddNegativeNumbers()
        {
            var arithmeticOperations = new ArithmeticOperations();

            ArithmeticOperation addOperation = new ArithmeticOperation(arithmeticOperations.Add);
            double result = arithmeticOperations.ExecuteOperation(addOperation, -5, -3);

            Assert.AreEqual(-8, result);
        }

        [TestMethod]
        public void TestSubtractNegativeNumbers()
        {
            var arithmeticOperations = new ArithmeticOperations();

            ArithmeticOperation subtractOperation = new ArithmeticOperation(arithmeticOperations.Subtract);
            double result = arithmeticOperations.ExecuteOperation(subtractOperation, -5, -3);

            Assert.AreEqual(-2, result);
        }
    }
}
