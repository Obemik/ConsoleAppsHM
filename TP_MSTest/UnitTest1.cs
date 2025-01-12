using ArithmeticOperationsApp;

namespace ArithmeticOperationsAppTests
{
    [TestClass]
    public class ArithmeticOperationsTests
    {
        [TestMethod]
        public void TestAddition()
        {
            var arithmeticOperations = new ArithmeticOperations();
            ArithmeticOperations.Operation add = new ArithmeticOperations.Operation(arithmeticOperations.Add);

            Assert.AreEqual(15, arithmeticOperations.ExecuteOperation(add, 10, 5));
            Assert.AreEqual(0, arithmeticOperations.ExecuteOperation(add, -5, 5));
        }

        [TestMethod]
        public void TestSubtraction()
        {
            var arithmeticOperations = new ArithmeticOperations();
            ArithmeticOperations.Operation subtract = new ArithmeticOperations.Operation(arithmeticOperations.Subtract);

            Assert.AreEqual(5, arithmeticOperations.ExecuteOperation(subtract, 10, 5));
            Assert.AreEqual(-10, arithmeticOperations.ExecuteOperation(subtract, -5, 5));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            var arithmeticOperations = new ArithmeticOperations();
            ArithmeticOperations.Operation multiply = new ArithmeticOperations.Operation(arithmeticOperations.Multiply);

            Assert.AreEqual(50, arithmeticOperations.ExecuteOperation(multiply, 10, 5));
            Assert.AreEqual(-25, arithmeticOperations.ExecuteOperation(multiply, -5, 5));
        }

        [TestMethod]
        public void TestAdditionInvoke()
        {
            var arithmeticOperations = new ArithmeticOperations();
            ArithmeticOperations.Operation add = new ArithmeticOperations.Operation(arithmeticOperations.Add);

            Assert.AreEqual(15, add.Invoke(10, 5));
            Assert.AreEqual(0, add.Invoke(-5, 5));
        }

        [TestMethod]
        public void TestSubtractionInvoke()
        {
            var arithmeticOperations = new ArithmeticOperations();
            ArithmeticOperations.Operation subtract = new ArithmeticOperations.Operation(arithmeticOperations.Subtract);

            Assert.AreEqual(5, subtract.Invoke(10, 5));
            Assert.AreEqual(-10, subtract.Invoke(-5, 5));
        }

        [TestMethod]
        public void TestMultiplicationInvoke()
        {
            var arithmeticOperations = new ArithmeticOperations();
            ArithmeticOperations.Operation multiply = new ArithmeticOperations.Operation(arithmeticOperations.Multiply);

            Assert.AreEqual(50, multiply.Invoke(10, 5));
            Assert.AreEqual(-25, multiply.Invoke(-5, 5));
        }
    }
}
