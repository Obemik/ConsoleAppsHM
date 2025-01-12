using System;
using System.Collections.Generic;
using ArrayOperationsApp;

namespace ArrayOperationsAppTests
{
    [TestClass]
    public class ArrayOperationsTests
    {
        private ArrayOperations _arrayOperations;

        [TestInitialize]
        public void Setup()
        {
            _arrayOperations = new ArrayOperations();
        }

        [TestMethod]
        public void TestGetEvenNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> result = _arrayOperations.GetEvenNumbers(numbers);
            CollectionAssert.AreEqual(new List<int> { 2, 4, 6, 8, 10 }, result);
        }

        [TestMethod]
        public void TestGetOddNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> result = _arrayOperations.GetOddNumbers(numbers);
            CollectionAssert.AreEqual(new List<int> { 1, 3, 5, 7, 9 }, result);
        }

        [TestMethod]
        public void TestGetPrimeNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            List<int> result = _arrayOperations.GetPrimeNumbers(numbers);
            CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 7, 11 }, result);
        }

        [TestMethod]
        public void TestGetFibonacciNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 13, 21, 34 };
            List<int> result = _arrayOperations.GetFibonacciNumbers(numbers);
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 5, 8, 13, 21, 34 }, result);
        }

        [TestMethod]
        public void TestGetFibonacciNumbersEmptyArray()
        {
            int[] numbers = { 0, 4, 6, 10, 20 };
            List<int> result = _arrayOperations.GetFibonacciNumbers(numbers);
            CollectionAssert.AreEqual(new List<int> { 0 }, result);
        }
    }
}