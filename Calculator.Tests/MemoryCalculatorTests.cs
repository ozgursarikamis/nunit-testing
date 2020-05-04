using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class MemoryCalculatorTests
    {
        private MemoryCalculator sut;

        [Test]
        public void ShouldAdd()
        {
            sut.Add(10);
            sut.Add(5);
            Assert.That(sut.CurrentValue, Is.EqualTo(15));
        }

        [Test]
        public void ShouldSubtract()
        {
            sut.Substract(5);
            Assert.That(sut.CurrentValue, Is.EqualTo(-5));
        }

        [SetUp]
        public void BeforeAllTests()
        {
            Console.WriteLine($"Before {TestContext.CurrentContext.Test.Name} ");
            sut = new MemoryCalculator();
        }

        [TearDown]
        public void AfterEachTest()
        {
            Console.WriteLine($"After {TestContext.CurrentContext.Test.Name}");
            sut = null;
        }
    }
}