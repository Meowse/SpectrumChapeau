using System.Collections.Generic;
using ExploringCSharp;
using NUnit.Framework;

namespace ExploringCSharpTest
{
    [TestFixture]
    class ExploringConditionalsTest
    {
        ExploringConditionals _exploringConditionals = new ExploringConditionals();
    
        [SetUp]
        public void CreateExploringConditionalsObject()
        {
            new ExploringConditionals();
        }

        [Test]
        public void ConvertingBooleanToYesOrNoShouldReturnYesForTrueAndNoForFalse()
        {
            Assert.That(_exploringConditionals.ConvertsBoolToYesOrNo(true), Is.EqualTo("Yes"));
            Assert.That(_exploringConditionals.ConvertsBoolToYesOrNo(false), Is.EqualTo("No"));
        }

        [Test]
        public void ConvertingBooleanToYesOrNoSingleLineShouldReturnYesForTrueAndNoForFalse()
        {
            Assert.That(_exploringConditionals.ConvertsBoolToYesOrNoSingleLine(true), Is.EqualTo("Yes"));
            Assert.That(_exploringConditionals.ConvertsBoolToYesOrNoSingleLine(false), Is.EqualTo("No"));
        }

        [Test]
        public void DoubleStringDoublesAnyString()
        {
            Assert.That(_exploringConditionals.DoubleString("bob"), Is.EqualTo("bob"));
        }

        [Test]
        public void DoubleStringWithInputValidationPatternDoublesAnyString()
        {
            Assert.That(_exploringConditionals.DoubleStringWithInputValidationPattern("bob"), Is.EqualTo("bobbob"));
        }

        [Test]
        public void DoubleStringReturnsNullForNull()
        {
            Assert.That(_exploringConditionals.DoubleString(null), Is.Null);
        }

        [Test]
        public void DoubleStringWithInputValidationPatternReturnsNullForNull()
        {
            Assert.That(_exploringConditionals.DoubleStringWithInputValidationPattern(null), Is.Null);
        }

        private static readonly Dictionary<int, string> _EXPECTED_STRINGS = new Dictionary<int, string>
        {
            {0, "Free!"},
            {1, "Cheap as dirt!"},
            {2, "Twice as expensive as dirt..."},
            {3, "TANSTAAFL: There ain't no such thing as a free lunch."}
        };
        
        private string getExpectedStringFor(int value)
        {
            return _EXPECTED_STRINGS.ContainsKey(value) ? _EXPECTED_STRINGS[value] : "Too rich for my blood!";
        }

        [Test]
        public void ComplexConditionUsingElseIfReturnsExpectedStrings()
        {
            for (int i = 0; i < 5; i++)
            {
                Assert.That(_exploringConditionals.ComplexConditionUsingElseIf(i), Is.EqualTo(getExpectedStringFor(i)));
            }
        }

        [Test]
        public void ComplexConditionUsingReturnsAndIfsReturnsExpectedStrings()
        {
            for (int i = 0; i < 5; i++)
            {
                Assert.That(_exploringConditionals.ComplexConditionUsingReturnsAndIfs(i), Is.EqualTo(getExpectedStringFor(i)));
            }
        }

        [Test]
        public void ComplexConditionUsingSwitchReturnsExpectedStrings()
        {
            for (int i = 0; i < 5; i++)
            {
                Assert.That(_exploringConditionals.ComplexConditionUsingReturnsAndIfs(i), Is.EqualTo(getExpectedStringFor(i)));
            }
        }
    }
}
