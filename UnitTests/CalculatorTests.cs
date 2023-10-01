using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    // Here's an example that emphasizes the importance of writing comprehensive and maintainable unit tests in C#

    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_WhenGivenTwoNumbers_ReturnsSum()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(2, 3);

            // Assert
            Assert.AreEqual(5, result);
        }
    }

    // In this example, we have a  Calculator  class with an  Add  method that performs addition. The accompanying  CalculatorTests  class demonstrates a unit test for the  Add  method.
    // The Add_WhenGivenTwoNumbers_ReturnsSum  test method verifies that when two numbers are passed to the Add  method, it correctly returns the sum.The test uses the NUnit testing framework and the Assert.AreEqual  method to compare the expected result (5) with the actual result obtained from the Add  method.
    // By writing comprehensive and maintainable unit tests like this example, you can verify the functionality of individual units of code, catch bugs early, and ensure the reliability of your codebase.These tests act as a safety net during refactoring or code changes and provide documentation for how the code is intended to work.
}