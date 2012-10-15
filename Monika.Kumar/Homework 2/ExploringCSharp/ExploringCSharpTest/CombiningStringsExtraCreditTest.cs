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
            Assert.That(new CombiningStrings().GreetsByCombiningStringsWithStringBuilder("Mickey"), Is.EqualTo("Hello, Mickey"));
        }
    }
}
