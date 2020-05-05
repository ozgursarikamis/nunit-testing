using System;
using NUnit.Framework;

namespace Calculator.Tests.SomeNamespace
{
    [TestFixture]
    public class PlayerCharacterTests
    {
        private PlayCharacter _sut;

        [SetUp]
        public void BeforeEachTest()
        {
            Console.WriteLine("Before {0}", TestContext.CurrentContext.Test.Name);

            _sut = new PlayCharacter();
        }

        [TearDown]
        public void AfterEachTest()
        {
            Console.WriteLine("After {0}", TestContext.CurrentContext.Test.Name);
        }


        #region Fixture

        [OneTimeSetUp]
        public void BeforeAnyTestStarted()
        {
            Console.WriteLine("*** Before PlayerCharacterTests");
        }

        [OneTimeTearDown]
        public void AfterAllTestsFinished()
        {
            Console.WriteLine("*** After PlayerCharacterTests");
        } 

        #endregion


        [Test]
        public void ShouldHaveNoEmptyDefaultWeapons()
        {       
            Assert.That(_sut.Weapons, Is.All.Not.Empty);
        }


        [Test]
        public void ShouldHaveALongBow()
        {
            Assert.That(_sut.Weapons, Contains.Item("Long Bow"));
        }


        [Test]
        [Obsolete]
        public void ShouldHaveAtLeastOneKindOfSword()
        {
            Assert.That(_sut.Weapons, Has.Some.ContainsSubstring("Sword"));
        }


        [Test]
        public void ShouldHaveTwoBows()
        {
            Assert.That(_sut.Weapons, Has.Exactly(2).EndsWith("Bow"));
        }


        [Test]
        public void ShouldNotHaveMoreThanOneTypeOfAGivenWeapon()
        {            
            Assert.That(_sut.Weapons, Is.Unique);
        }


        [Test]
        public void ShouldNotHaveAStaffOfWonder()
        {
            Assert.That(_sut.Weapons, Has.None.EqualTo("Staff Of Wonder"));            
        }     


        [Test]
        public void ShouldHaveDefaultsWeaponsInAlphabeticalOrder()
        {           
            Assert.That(_sut.Weapons, Is.Ordered);
        }
    }
}
