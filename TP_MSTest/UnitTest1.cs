using FibonacciChecker;

namespace TP_MSTest;

[TestClass]
public class FibonacciTests
{
    [TestMethod]
    public void TestFibonacciNumber()
    {
        Assert.IsTrue(FibonacciUtils.IsFibonacciNumber(5)); 
        Assert.IsTrue(FibonacciUtils.IsFibonacciNumber(21)); 
        Assert.IsTrue(FibonacciUtils.IsFibonacciNumber(144)); 
    }

    [TestMethod]
    public void TestNonFibonacciNumber()
    {
        Assert.IsFalse(FibonacciUtils.IsFibonacciNumber(4));  
        Assert.IsFalse(FibonacciUtils.IsFibonacciNumber(6)); 
        Assert.IsFalse(FibonacciUtils.IsFibonacciNumber(50)); 
    }

    [TestMethod]
    public void TestNegativeNumber()
    {
        Assert.IsFalse(FibonacciUtils.IsFibonacciNumber(-5)); 
    }

    [TestMethod]
    public void TestZeroAndOne()
    {
        Assert.IsTrue(FibonacciUtils.IsFibonacciNumber(0));  
        Assert.IsTrue(FibonacciUtils.IsFibonacciNumber(1)); 
    }
}