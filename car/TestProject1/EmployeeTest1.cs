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
            // fix the errors with the first and last name not populating correclty. I also did work in CodeAcedemy today.
        }
    }
    
    public class GalacticTravelAgency { 
        public static void name(string[] args) {
            // Your code goes here
            string passengerName = "Zara";
            int passengerAge = 28;
            string ticketType = "First Class";
            string preferredPlanet = "Mars";
            string fullInformation = string.Concat(passengerName, " ", passengerAge, " ", ticketType, " ", preferredPlanet);

            Console.WriteLine(fullInformation);

            int correctAge = (passengerAge + 1);

            Console.WriteLine("The correct age is " + correctAge);

            double passengerAgeDouble = (double)passengerAge;

            Console.WriteLine(passengerAgeDouble);

            double implicintAge = passengerAge;

            Console.WriteLine(implicintAge);
      
            string passengerAgeString = Convert.ToString(passengerAge);

            Console.WriteLine(passengerAgeString);
            
            // just slapping in my Code Academy code showing string conversions and I can reference it 

        }
    }
}

// Example: Testing a property that isn't fully defined yet.
        // Assuming you plan to use the 'jobHave' property in some meaningful way later,
        // you might write a test like this:
        