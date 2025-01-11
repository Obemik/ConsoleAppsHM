[TestClass]
public class ArrayTests
{
    [TestMethod]
    public void TestMax()
    {
        var array = new Array(new[] { 1, 2, 3, 4, 5 });
        Assert.AreEqual(5, array.Max());
    }

    [TestMethod]
    public void TestMin()
    {
        var array = new Array(new[] { 1, 2, 3, 4, 5 });
        Assert.AreEqual(1, array.Min());
    }

    [TestMethod]
    public void TestAvg()
    {
        var array = new Array(new[] { 1, 2, 3, 4, 5 });
        Assert.AreEqual(3.0f, array.Avg());
    }

    [TestMethod]
    public void TestSearch_Found()
    {
        var array = new Array(new[] { 1, 2, 3, 4, 5 });
        Assert.IsTrue(array.Search(3));
    }

    [TestMethod]
    public void TestSearch_NotFound()
    {
        var array = new Array(new[] { 1, 2, 3, 4, 5 });
        Assert.IsFalse(array.Search(10));
    }

    [TestMethod]
    public void TestShow()
    {
        var array = new Array(new[] { 1, 2, 3 });
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            array.Show();
            Assert.AreEqual("Array elements: 1, 2, 3\r\n", sw.ToString());
        }
    }

    [TestMethod]
    public void TestShow_WithInfo()
    {
        var array = new Array(new[] { 1, 2, 3 });
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            array.Show("Test Info");
            Assert.AreEqual("Test Info: 1, 2, 3\r\n", sw.ToString());
        }
    }
}