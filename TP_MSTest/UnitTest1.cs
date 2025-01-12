using EmployeeManagement;
using System;

namespace EmployeeManagementTests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void TestSetSalary_ValidValue()
        {
            var employee = new Employee();
            employee.SetSalary(50000);
            Assert.AreEqual(50000, employee.Salary);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetSalary_NegativeValue_ThrowsException()
        {
            var employee = new Employee();
            employee.SetSalary(-5000);
        }

        [TestMethod]
        public void TestSalaryIncrease()
        {
            var employee = new Employee();
            employee.SetSalary(50000);
            employee += 10000;
            Assert.AreEqual(60000, employee.Salary);
        }

        [TestMethod]
        public void TestSalaryDecrease()
        {
            var employee = new Employee();
            employee.SetSalary(50000);
            employee -= 10000;
            Assert.AreEqual(40000, employee.Salary);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSalaryDecreaseBelowZero_ThrowsException()
        {
            var employee = new Employee();
            employee.SetSalary(50000);
            employee -= 60000;  
        }

        [TestMethod]
        public void TestEqualityOperator()
        {
            var employee1 = new Employee();
            var employee2 = new Employee();
            employee1.SetSalary(50000);
            employee2.SetSalary(50000);

            Assert.IsTrue(employee1 == employee2);
            Assert.IsFalse(employee1 != employee2);
        }

        [TestMethod]
        public void TestComparisonOperators()
        {
            var employee1 = new Employee();
            var employee2 = new Employee();
            employee1.SetSalary(50000);
            employee2.SetSalary(60000);

            Assert.IsTrue(employee1 < employee2);
            Assert.IsFalse(employee1 > employee2);
        }
    }
}
