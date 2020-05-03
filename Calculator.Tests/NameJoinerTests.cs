using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class SpecialDateStoreTests
    {
        [Test]
        public void ShouldHaveCorrectMilleniumDate()
        {
            var sut = new SpecialDateStore();
            var result = sut.DateOf(SpecialDates.NewMillenium);

            Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 0)));
        }

        [Test]
        public void ShouldHaveCorrectMilleniumDate_WithTolerance()
        {
            var sut = new SpecialDateStore();
            var result = sut.DateOf(SpecialDates.NewMillenium);

            //Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 1)));
            Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 1)).Within(TimeSpan.FromMilliseconds(1)));
            Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 1)).Within(1).Milliseconds);
        }
    }
    [TestFixture]
    public class NameJoinerTests
    {
        [Test]
        public void ShouldJoinNames()
        {
            var sut = new NameJoiner();
            var fullName = sut.Join("Sarah", "Smith");

            Assert.That(fullName, Is.EqualTo("Sarah Smith"));
        }

        [Test]
        public void ShouldJoinNames_CaseInsensitiveAssert()
        {
            var sut = new NameJoiner();
            var fullName = sut.Join("sarah", "smith");

            Assert.That(fullName, Is.EqualTo("SARAH SMITH").IgnoreCase);
        }

        [Test]
        public void ShouldJoinNames_NotEqualDemo()
        {
            var sut = new NameJoiner();
            var fullName = sut.Join("Sarah", "Smith");

            Assert.That(fullName, Is.Not.EqualTo("Gentry Smith"));
        }
    }
}