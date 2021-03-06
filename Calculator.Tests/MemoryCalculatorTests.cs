﻿using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class MemoryCalculatorTests
    {
        private MemoryCalculator _sut;

        [Test]
        public void ShouldAdd()
        {
            _sut.Add(10);
            _sut.Add(5);
            Assert.That(_sut.CurrentValue, Is.EqualTo(15));
        }

        [Test]
        public void ShouldSubtract()
        {
            _sut.Subtract(5);
            Assert.That(_sut.CurrentValue, Is.EqualTo(-5));
        }

        [SetUp]
        public void BeforeAllTests()
        {
            Console.WriteLine($"Before {TestContext.CurrentContext.Test.Name} ");
            _sut = new MemoryCalculator();
        }

        [TearDown]
        public void AfterEachTest()
        {
            Console.WriteLine($"After {TestContext.CurrentContext.Test.Name}");
            _sut = null;
        }
    }
}