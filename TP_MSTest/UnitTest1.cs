using RangeProductCalculator;

namespace TP_MSTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestValidRange()
    {
        Assert.AreEqual(120, Calculator.GetProductInRange(1, 5)); 
    }

    [TestMethod]
    public void TestSingleNumberRange()
    {
        Assert.AreEqual(5, Calculator.GetProductInRange(5, 5)); 
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestInvalidRange()
    {
        Calculator.GetProductInRange(10, 5); 
    }

    [TestMethod]
    public void TestZeroInRange()
    {
        Assert.AreEqual(0, Calculator.GetProductInRange(0, 5)); 
    }
}