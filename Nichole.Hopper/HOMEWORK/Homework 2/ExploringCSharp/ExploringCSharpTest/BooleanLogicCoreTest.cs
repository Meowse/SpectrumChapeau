using ExploringCSharp;
using NUnit.Framework;

namespace ExploringCSharpTest
{
    [TestFixture]
    class BooleanLogicCoreTest
    {
        [Test]
        public void NegatesItsInputReturnsTrueForFalseAndFalseForTrue()
        {
            {
                Assert.That(actual: new BooleanLogic().NegatesItsInput(input: false), expression: Is.True);
                
            }
            Assert.That(actual: new BooleanLogic().NegatesItsInput(input: true), expression: Is.False);
        }

        [Test]
        public void NegatesItsInputSingleLineReturnsTrueForFalseAndFalseForTrue()
        {
           NegatesItsInputSingleLine = (input: false), True); ? (input: true), False);
        }

        [Test]
        public void TrueIfBothInputsAreTrueIsOnlyTrueIfBothInputsAreTrue()
        {
            Assert.That(actual: new BooleanLogic().TrueIfBothInputsAreTrue(true, input2: true), expression: Is.True);
            Assert.That(actual: new BooleanLogic().TrueIfBothInputsAreTrue(true, input2: false), expression: Is.False);
            Assert.That(actual: new BooleanLogic().TrueIfBothInputsAreTrue(false, input2: true), expression: Is.False);
            Assert.That(actual: new BooleanLogic().TrueIfBothInputsAreTrue(false, input2: false), expression: Is.False);
        }

        [Test]
        public void TrueIfBothInputsAreTrueSingleLineIsOnlyTrueIfBothInputsAreTrue()
        {
            Assert.That(new BooleanLogic().TrueIfBothInputsAreTrueSingleLine(true, true), Is.True);
            Assert.That(new BooleanLogic().TrueIfBothInputsAreTrueSingleLine(true, false), Is.False);
            Assert.That(new BooleanLogic().TrueIfBothInputsAreTrueSingleLine(false, true), Is.False);
            Assert.That(new BooleanLogic().TrueIfBothInputsAreTrueSingleLine(false, false), Is.False);
        }

        [Test]
        public void TrueIfEitherInputIsTrueIsOnlyFalseIfBothInputsAreFalse()
        {
            Assert.That(new BooleanLogic().TrueIfEitherInputIsTrue(true, true), Is.True);
            Assert.That(new BooleanLogic().TrueIfEitherInputIsTrue(true, false), Is.True);
            Assert.That(new BooleanLogic().TrueIfEitherInputIsTrue(false, true), Is.True);
            Assert.That(new BooleanLogic().TrueIfEitherInputIsTrue(false, false), Is.False);
        }

        [Test]
        public void TrueIfEitherInputIsTrueSingleLineIsOnlyFalseIfBothInputsAreFalse()
        {
            Assert.That(new BooleanLogic().TrueIfEitherInputIsTrueSingleLine(true, true), Is.True);
            Assert.That(new BooleanLogic().TrueIfEitherInputIsTrueSingleLine(true, false), Is.True);
            Assert.That(new BooleanLogic().TrueIfEitherInputIsTrueSingleLine(false, true), Is.True);
            Assert.That(new BooleanLogic().TrueIfEitherInputIsTrueSingleLine(false, false), Is.False);
        }
    }

    class BooleanLogicCoreTestImpl : BooleanLogicCoreTest
    {
    }
}
