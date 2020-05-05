using System;
using NUnit.Framework;

namespace Calculator.Tests.SomeNamespace
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
        public void BeforeEachTest()
        {
            Console.WriteLine("Before {0}", TestContext.CurrentContext.Test.Name);

            _sut = new MemoryCalculator();
        }

        [TearDown]
        public void AfterEachTest()
        {
            Console.WriteLine("After {0}", TestContext.CurrentContext.Test.Name); 
            _sut = null;
        } 
    }
}
