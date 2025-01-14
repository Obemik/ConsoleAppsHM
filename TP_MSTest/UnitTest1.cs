namespace BackpackApp.Tests
{
    [TestClass]
    public class BackpackTests
    {
        [TestMethod]
        public void TestAddItem_Success()
        {
            var backpack = new Backpack("Blue", "BrandZ", "ManufacturerX", "FabricB", 2.0, 10);

            bool itemAdded = false;
            backpack.ItemAdded += (sender, e) => { itemAdded = true; };

            backpack.AddItem(new BackpackItem("Laptop", 3));

            Assert.IsTrue(itemAdded);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestAddItem_ExceedsCapacity()
        {
            var backpack = new Backpack("Green", "BrandA", "ManufacturerB", "FabricC", 1.5, 5);

            backpack.AddItem(new BackpackItem("Laptop", 6));
        }
    }
}