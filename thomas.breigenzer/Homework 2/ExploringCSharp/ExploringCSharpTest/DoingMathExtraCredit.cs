using ExploringCSharp;
using NUnit.Framework;

namespace ExploringCSharpTest
{
    [TestFixture]
    class DoingMathExtraCredit
    {
        private DoingMath _doingMath;

        [SetUp]
        public void CreateDoingMathObject()
        {
            _doingMath = new DoingMath();
        }
    
        [Test]
        public void ReturnTheLargerNumberShouldReturnTheLargerNumber()
        {
            Assert.That(_doingMath.ReturnTheLargerNumber(1, 3), Is.EqualTo(3));
            Assert.That(_doingMath.ReturnTheLargerNumber(3, 1), Is.EqualTo(3));
        }

        [Test]
        public void ReturnTheLargerNumberWorksWithNegativeNumbers()
        {
            Assert.That(_doingMath.ReturnTheLargerNumber(-3, -1), Is.EqualTo(-1));
        }

        [Test]
        public void ReturnTheLargerNumberReturnsPositiveOverNegativeNumbers()
        {
            Assert.That(_doingMath.ReturnTheLargerNumber(-3, 1), Is.EqualTo(1));
            Assert.That(_doingMath.ReturnTheLargerNumber(3, -1), Is.EqualTo(3));
        }

        [Test]
        public void ReturnTheLargerNumberWorksWithIdenticalNumbers()
        {
            Assert.That(_doingMath.ReturnTheLargerNumber(2, 2), Is.EqualTo(2));
            Assert.That(_doingMath.ReturnTheLargerNumber(-2, -2), Is.EqualTo(-2));
        }

        [Test]
        public void GetBiggestMagnitudeReturnsTheNumberWithTheLargerMagnitude()
        {
            Assert.That(_doingMath.GetBiggestMagnitude(-3, 1), Is.EqualTo(-3));
            Assert.That(_doingMath.GetBiggestMagnitude(1, 14), Is.EqualTo(14));
        }

        [Test]
        public void ShouldMultiplyNumbersByTheirPowerOfTen()
        {
            Assert.That(_doingMath.MultiplyByTheNextLargerPowerOfTen(9), Is.EqualTo(90));
            Assert.That(_doingMath.MultiplyByTheNextLargerPowerOfTen(88), Is.EqualTo(8800));
            Assert.That(_doingMath.MultiplyByTheNextLargerPowerOfTen(101), Is.EqualTo(101000));
        }

        [Test]
        public void ShouldMultiplyPowersOfTenByThemselves()
        {
            Assert.That(_doingMath.MultiplyByTheNextLargerPowerOfTen(10), Is.EqualTo(100));
            Assert.That(_doingMath.MultiplyByTheNextLargerPowerOfTen(100), Is.EqualTo(1000));
            Assert.That(_doingMath.MultiplyByTheNextLargerPowerOfTen(1000), Is.EqualTo(10000));
        }

        [Test]
        public void OneShouldReturnOneSinceOneIsTheNextLargerPowerOfTen()
        {
            Assert.That(_doingMath.MultiplyByTheNextLargerPowerOfTen(1), Is.EqualTo(1));
        }
    }
}
