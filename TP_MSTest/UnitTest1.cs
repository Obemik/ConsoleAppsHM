
using System;
using EmployeeManagement;

namespace EmployeeManagementTests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void TestSetFullName_ValidName()
        {
            var employee = new Employee();
            employee.SetFullName("John Doe");
            Assert.AreEqual("John Doe", employee.FullName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetFullName_EmptyName_ThrowsException()
        {
            var employee = new Employee();
            employee.SetFullName("");
        }

        [TestMethod]
        public void TestSetDateOfBirth_ValidDate()
        {
            var employee = new Employee();
            var validDate = new DateTime(1990, 5, 20);
            employee.SetDateOfBirth(validDate);
            Assert.AreEqual(validDate, employee.DateOfBirth);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetDateOfBirth_FutureDate_ThrowsException()
        {
            var employee = new Employee();
            employee.SetDateOfBirth(DateTime.Now.AddDays(1));
        }

        [TestMethod]
        public void TestSetPhone_ValidPhone()
        {
            var employee = new Employee();
            employee.SetPhone("123-456-7890");
            Assert.AreEqual("123-456-7890", employee.Phone);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetPhone_EmptyPhone_ThrowsException()
        {
            var employee = new Employee();
            employee.SetPhone("");
        }

        [TestMethod]
        public void TestSetEmail_ValidEmail()
        {
            var employee = new Employee();
            employee.SetEmail("john.doe@example.com");
            Assert.AreEqual("john.doe@example.com", employee.Email);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetEmail_InvalidEmail_ThrowsException()
        {
            var employee = new Employee();
            employee.SetEmail("invalid-email");
        }

        [TestMethod]
        public void TestSetPosition_ValidPosition()
        {
            var employee = new Employee();
            employee.SetPosition("Software Engineer");
            Assert.AreEqual("Software Engineer", employee.Position);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetPosition_EmptyPosition_ThrowsException()
        {
            var employee = new Employee();
            employee.SetPosition("");
        }

        [TestMethod]
        public void TestSetJobDescription_ValidDescription()
        {
            var employee = new Employee();
            employee.SetJobDescription("Develop and maintain software applications.");
            Assert.AreEqual("Develop and maintain software applications.", employee.JobDescription);
        }
    }
}
