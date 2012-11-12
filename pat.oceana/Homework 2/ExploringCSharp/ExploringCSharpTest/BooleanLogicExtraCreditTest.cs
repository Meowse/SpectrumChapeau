 using ExploringCSharp;
using NUnit.Framework;

namespace ExploringCSharpTest
{
    [TestFixture]
    class BooleanLogicExtraCreditTest
    {
        [Test]
        public void MenUnder25MustPayExtraSurchargeToRentACar()
        {
            Assert.That(new BooleanLogic().MustPayExtraSurchargeToRentACar("M", 19), Is.True);
        }

        [Test]
        public void MenOver25AndWomenRegardlessOfAgeDoNotPayExtraSurchargeToRentACar()
        {
            Assert.That(new BooleanLogic().MustPayExtraSurchargeToRentACar("F", 19), Is.False);
            Assert.That(new BooleanLogic().MustPayExtraSurchargeToRentACar("F", 30), Is.False);
            Assert.That(new BooleanLogic().MustPayExtraSurchargeToRentACar("M", 25), Is.False);
        }

        [Test]
        public void PersonsOfNontraditionalGenderMustPayExtraSurchargeToRentACar()
        {
            Assert.That(new BooleanLogic().MustPayExtraSurchargeToRentACar("O", 19), Is.True);
            Assert.That(new BooleanLogic().MustPayExtraSurchargeToRentACar("O", 25), Is.True);
        }

        [Test]
        public void PersonsPreferringNotToStateAGenderMustPayExtraSurchargeToRentACar()
        {
            Assert.That(new BooleanLogic().MustPayExtraSurchargeToRentACar("P", 19), Is.True);
            Assert.That(new BooleanLogic().MustPayExtraSurchargeToRentACar("P", 25), Is.True);
        }
    }
}
