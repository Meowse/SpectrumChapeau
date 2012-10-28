using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExploringCSharp;
using NUnit.Framework;

namespace ExploringCSharpTest
{
    [TestFixture]
    public class CodeSamplesTest
    {
        [Test]
        public void SaysHelloShouldReturnHello()
        {
            Assert.That(new CodeSamples().SaysHello("Mickey"), Is.EqualTo("Hello, Mickey"));
        }

        [Test]
        public void SaysHello2ShouldReturnHello()
        {
            Assert.That(new CodeSamples().SaysHello2("Mickey"), Is.EqualTo("Hello, Mickey"));
        }

    }
}
