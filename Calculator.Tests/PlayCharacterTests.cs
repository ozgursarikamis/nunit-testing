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
    }
}
