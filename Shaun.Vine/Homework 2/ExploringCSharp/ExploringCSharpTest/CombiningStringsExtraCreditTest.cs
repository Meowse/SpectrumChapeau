using ExploringCSharp;
using NUnit.Framework;

namespace ExploringCSharpTest
{
    [TestFixture]
    public class CombiningStringsExtraCreditTest
    {
        [Test]
        public void GreetsByCombiningStringsWithStringBuilderWorks()
        {
            Assert.That(new CombiningStrings().GreetsByCombiningStringsWithFormats("Mickey"), Is.EqualTo("Hello, Mickey"));
        }
    }
}
