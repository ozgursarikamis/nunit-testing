using System.Linq;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class PlayCharacterTests
    {
        [Test]
        public void SouldIncreaseHealthAfterSleeping()
        {
            var sut = new PlayCharacter{ Health = 100 };
            sut.Sleep();

            Assert.That(sut.Health, Is.GreaterThan(100));
        }

        // Range Test
        [Test]
        public void ShouldIncreaseHealthInExpectedRangeAfterSleeping()
        {
            var sut = new PlayCharacter { Health = 100 };
            sut.Sleep();
            Assert.That(sut.Health, Is.InRange(101, 200));

            /* ALSO AVAILABLE
             * Is.GreaterThanOrEqualTo()
             * Is.LessThan()
             * Is.LessThanOrEqualTo()
             */
        }

        [Test]
        public void ShouldHaveDefaultRandomGeneratedName()
        {
            var sut = new PlayCharacter();
            Assert.That(sut.Name, Is.Not.Empty);
        }
        [Test]
        public void ShouldHaveANickName()
        {
            var sut = new PlayCharacter();
            // Assert.That(sut.Name, Is.Not.Empty);
            Assert.That(sut.NickName, Is.Null);
        }
        [Test]
        public void ShouldBeNewbie()
        {
            var sut = new PlayCharacter(); 
            Assert.That(sut.IsNoob, Is.True);
        }

        //[Test]
        //public void ShouldHaveNoEmptyDefaultWeapons()
        //{
        //    var sut = new PlayCharacter();
        //    Assert.That(sut.Weapons, Is.All.Not.Empty);
        //}
        [Test]
        public void ShouldHaveALongBow()
        {
            var sut = new PlayCharacter();
            Assert.That(sut.Weapons, Contains.Item("Long Bow"));
        }

        [Test]
        public void ShouldHaveTwoBows()
        {
            var sut = new PlayCharacter();
            Assert.That(sut.Weapons, Has.Exactly(2).EndsWith("Bow"));

            //TODO: Unit Testing for Collections
            //Assert.That(sut.Weapons, Has.Exactly(1).Items.Empty);
        }

        // Test Uniqueness:
        [Test]
        public void ShouldWeaponsBeUnique()
        {
            var sut = new PlayCharacter();
            Assert.That(sut.Weapons, Is.Unique);
        }

        // check a collection if does not have a specific item
        [Test]
        public void ShouldNotHaveAStaffOfWonder()
        {
            var sut = new PlayCharacter();
            Assert.That(sut.Weapons, Has.None.EqualTo("Staff of Wonder"));
        }

        // order tst
        [Test]
        public void ShouldBeOrderedAlphabetically()
        {
            var sut = new PlayCharacter();
            Assert.That(sut.Weapons.OrderBy(x => x), Is.Ordered);
        }

        // REFERENCE EQUALITY TESTS:
        [Test]
        public void ReferenceEqualityTest()
        {
            var p1 = new PlayCharacter();
            var p2 = new PlayCharacter();

            // Assert.That(p1, Is.SameAs(p2));

            //var somePlayer = p1;
            //Assert.That(p1, Is.SameAs(somePlayer));

            Assert.That(p1, Is.Not.SameAs(p2));
        }
    }
}
