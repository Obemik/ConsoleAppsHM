using LogicExpressionApp;

namespace LogicExpressionAppTests
{
    [TestClass]
    public class LogicEvaluatorTests
    {
        private LogicEvaluator _evaluator;

        [TestInitialize]
        public void Setup()
        {
            _evaluator = new LogicEvaluator();
        }

        [TestMethod]
        public void TestEvaluateExpression_GreaterThan()
        {
            var result = _evaluator.EvaluateExpression("5 > 3");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestEvaluateExpression_LessThan()
        {
            var result = _evaluator.EvaluateExpression("3 < 5");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestEvaluateExpression_Equal()
        {
            var result = _evaluator.EvaluateExpression("5 == 5");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestEvaluateExpression_NotEqual()
        {
            var result = _evaluator.EvaluateExpression("5 != 3");
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEvaluateExpression_InvalidOperator()
        {
            _evaluator.EvaluateExpression("5 # 3");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEvaluateExpression_InvalidFormat()
        {
            _evaluator.EvaluateExpression("5 3");
        }
    }
}