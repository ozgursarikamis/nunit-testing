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
    }
}
