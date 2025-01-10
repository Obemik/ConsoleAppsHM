using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassportSystem;
using System;

namespace PassportTests
{
    [TestClass]
    public class PassportTests
    {
        [TestMethod]
        public void TestPassportCreation_ValidData()
        {
            var passport = new Passport("John Doe", "AB1234567", "CountryX", new DateTime(1990, 1, 1), new DateTime(2030, 1, 1));
            Assert.AreEqual("John Doe", passport.FullName);
            Assert.AreEqual("AB1234567", passport.PassportNumber);
            Assert.AreEqual("CountryX", passport.Citizenship);
            Assert.AreEqual(new DateTime(1990, 1, 1), passport.DateOfBirth);
            Assert.AreEqual(new DateTime(2030, 1, 1), passport.ExpirationDate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPassportCreation_InvalidDate()
        {
            var passport = new Passport("John Doe", "AB1234567", "CountryX", new DateTime(2030, 1, 1), new DateTime(2020, 1, 1));
        }

        [TestMethod]
        public void TestForeignPassportCreation_ValidData()
        {
            var foreignPassport = new ForeignPassport("John Doe", "AB1234567", "CountryX", new DateTime(1990, 1, 1), new DateTime(2030, 1, 1), "FP9876543");
            Assert.AreEqual("FP9876543", foreignPassport.ForeignPassportNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestForeignPassportCreation_EmptyForeignPassportNumber()
        {
            var foreignPassport = new ForeignPassport("John Doe", "AB1234567", "CountryX", new DateTime(1990, 1, 1), new DateTime(2030, 1, 1), "");
        }

        [TestMethod]
        public void TestForeignPassport_AddAndRemoveVisa()
        {
            var foreignPassport = new ForeignPassport("John Doe", "AB1234567", "CountryX", new DateTime(1990, 1, 1), new DateTime(2030, 1, 1), "FP9876543");
            foreignPassport.AddVisa("USA");
            foreignPassport.AddVisa("Canada");
            Assert.AreEqual(2, foreignPassport.Visas.Count);

            foreignPassport.RemoveVisa("USA");
            Assert.AreEqual(1, foreignPassport.Visas.Count);
            Assert.IsTrue(foreignPassport.Visas.Contains("Canada"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestForeignPassport_AddEmptyVisa()
        {
            var foreignPassport = new ForeignPassport("John Doe", "AB1234567", "CountryX", new DateTime(1990, 1, 1), new DateTime(2030, 1, 1), "FP9876543");
            foreignPassport.AddVisa("");
        }
    }
}
