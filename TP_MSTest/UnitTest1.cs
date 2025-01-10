using AnimalKingdom;
using System;

namespace AnimalTests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void TestAnimalCreation_ValidData()
        {
            var animal = new Animal("Generic Animal", "Savanna", "Omnivore");
            Assert.AreEqual("Generic Animal", animal.Name);
            Assert.AreEqual("Savanna", animal.Habitat);
            Assert.AreEqual("Omnivore", animal.Diet);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAnimalCreation_EmptyName()
        {
            var animal = new Animal("", "Savanna", "Omnivore");
        }

        [TestMethod]
        public void TestTigerCreation_ValidData()
        {
            var tiger = new Tiger("Bengal Tiger", "Forests", "Carnivore", "Orange with Black Stripes");
            Assert.AreEqual("Orange with Black Stripes", tiger.StripeColor);
            Assert.AreEqual("Bengal Tiger lets out a powerful roar!", tiger.Roar());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTigerCreation_EmptyStripeColor()
        {
            var tiger = new Tiger("Bengal Tiger", "Forests", "Carnivore", "");
        }

        [TestMethod]
        public void TestCrocodileCreation_ValidData()
        {
            var crocodile = new Crocodile("Nile Crocodile", "Rivers and Swamps", "Carnivore", 5.5);
            Assert.AreEqual(5.5, crocodile.Length);
            Assert.AreEqual("Nile Crocodile swims stealthily through the water.", crocodile.Swim());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCrocodileCreation_InvalidLength()
        {
            var crocodile = new Crocodile("Nile Crocodile", "Rivers and Swamps", "Carnivore", -1.0);
        }

        [TestMethod]
        public void TestKangarooCreation_ValidData()
        {
            var kangaroo = new Kangaroo("Red Kangaroo", "Grasslands", "Herbivore", 3.0);
            Assert.AreEqual(3.0, kangaroo.JumpHeight);
            Assert.AreEqual("Red Kangaroo jumps 3 meters high!", kangaroo.Jump());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestKangarooCreation_InvalidJumpHeight()
        {
            var kangaroo = new Kangaroo("Red Kangaroo", "Grasslands", "Herbivore", 0);
        }
    }
}
