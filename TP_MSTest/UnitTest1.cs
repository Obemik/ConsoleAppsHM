using System;

namespace BackpackApp.Tests
{
    [TestClass]
    public class BackpackTests
    {
        [TestMethod]
        public void TestAddItemWithinCapacity()
        {
            var backpack = new Backpack("Blue", "Adidas", "Adidas Ltd.", "Nylon", 1.5, 20);

            backpack.AddItem("Notebook", 5);
            backpack.AddItem("Pen", 1);

            Assert.AreEqual(2, backpack.Contents.Count);
            Assert.AreEqual(6, backpack.Contents[0].ItemVolume + backpack.Contents[1].ItemVolume);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestAddItemExceedsCapacity()
        {
            var backpack = new Backpack("Red", "Puma", "Puma AG", "Canvas", 1.3, 15);

            backpack.AddItem("Sleeping Bag", 10);
            backpack.AddItem("Clothes", 8);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAddItemWithInvalidVolume()
        {
            var backpack = new Backpack("Green", "Under Armour", "UA Inc.", "Leather", 2, 30);

            backpack.AddItem("Tablet", -5); 
        }

        [TestMethod]
        public void TestBackpackDetails()
        {
            var backpack = new Backpack("Yellow", "Reebok", "Reebok Ltd.", "Cotton", 1.8, 22);

            Assert.AreEqual("Yellow", backpack.Color);
            Assert.AreEqual("Reebok", backpack.Brand);
            Assert.AreEqual(22, backpack.Volume);
        }
    }
}