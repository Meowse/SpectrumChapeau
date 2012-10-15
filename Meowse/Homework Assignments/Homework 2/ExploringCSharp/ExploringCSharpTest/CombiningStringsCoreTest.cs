using ExploringCSharp;
using NUnit.Framework;

namespace ExploringCSharpTest
{
    [TestFixture]
    public class CombiningStringsCoreTest
    {
        [Test]
        public void GreetsByCombiningStringsWithPlusWorks()
        {
            Assert.That(new CombiningStrings().GreetsByCombiningStringsWithPlus("Mickey"), Is.EqualTo("Hello, Mickey"));
        }

        [Test]
        public void GreetsByCombiningStringsWithFormatsWorks()
        {
            Assert.That(new CombiningStrings().GreetsByCombiningStringsWithFormats("Mickey"), Is.EqualTo("Hello, Mickey"));
        }
    }
}
