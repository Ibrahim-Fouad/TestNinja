using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(11, "11")]
        [TestCase(20, "Buzz")]
        public void GetOutput_WhenCall_ReturnOutput(int number, string expected)
        {
            var output = FizzBuzz.GetOutput(number);

            Assert.That(output, Is.EqualTo(expected));
        }
    }
}
