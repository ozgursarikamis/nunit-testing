using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class EnemyTests
    {
        [Test]
        public void ShouldCreateNormalEnemy()
        {
            var sut = new EnemyFactory();
            var enemy = sut.Create(false);
            Assert.That(enemy, Is.TypeOf<NormalEnemy>());
        }

        [Test]
        public void ShouldBeOfBaseType()
        {
            var sut = new EnemyFactory();
            object enemy = sut.Create(true);
            Assert.That(enemy, Is.InstanceOf<Enemy>());
        }

        // Property Check:
        [Test]
        public void ShouldHaveExtraPower()
        {
            var sut = new EnemyFactory();
            var enemy = sut.Create(true);
            Assert.That(enemy, Has.Property("ExtraPower"));
        }
    }
}