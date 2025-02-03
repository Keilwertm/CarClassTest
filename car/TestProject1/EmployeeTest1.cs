using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employee1;

namespace EmployeeTests

{
    [SetUp]
    public class EmployeeTestCases
    {
        [Test]
        public void EmployeeConstructor_SetsPropertiesCorrectly()
        {
            Employee newEmployee = new Employee("John", "Doe", 140);
            string expected = "John Doe";
            string actual = newEmployee.Name;
            Assert.AreEqual(expected, actual);
        }
    }
}

// Example: Testing a property that isn't fully defined yet.
        // Assuming you plan to use the 'jobHave' property in some meaningful way later,
        // you might write a test like this:
        