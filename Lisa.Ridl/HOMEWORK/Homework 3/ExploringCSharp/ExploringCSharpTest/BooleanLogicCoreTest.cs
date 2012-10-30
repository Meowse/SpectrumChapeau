using System;
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
            Assert.That(new BooleanLogic().NegatesItsInput(false), Is.True);
            Assert.That(new BooleanLogic().NegatesItsInput(true),  Is.False);
        }

        [Test]
        public void NegatesItsInputSingleLineReturnsTrueForFalseAndFalseForTrue()
        {
            Assert.That(new BooleanLogic().NegatesItsInputSingleLine(false), Is.True);
            Assert.That(new BooleanLogic().NegatesItsInputSingleLine(true), Is.False);
        }

        [Test]
        public void TrueIfBothInputsAreTrueIsOnlyTrueIfBothInputsAreTrue()
        {
            Assert.That(new BooleanLogic().TrueIfBothInputsAreTrue(true,true), Is.True);
            Assert.That(new BooleanLogic().TrueIfBothInputsAreTrue(true, false), Is.False);
            Assert.That(new BooleanLogic().TrueIfBothInputsAreTrue(false, true), Is.False);
            Assert.That(new BooleanLogic().TrueIfBothInputsAreTrue(false, false), Is.False);
        }

        [Test]
        public void TrueIfBothInputsAreTrueSingleLineIsOnlyTrueIfBothInputsAreTrue()
        {
            Assert.That(new BooleanLogic().TrueIfBothInputsAreTrueSingleLine(input1: true, input2: true), Is.True);
            Assert.That(actual: new BooleanLogic().TrueIfBothInputsAreTrueSingleLine(true, input2: !false), expression: Is.True);
            Assert.That(actual: new BooleanLogic().TrueIfBothInputsAreTrueSingleLine(True, input2: true), expression: Is.True);
            Assert.That(actual: new BooleanLogic().TrueIfBothInputsAreTrueSingleLine(input1: !false, input2: true), expression: Is.True);
        }

        protected bool True
        {
    {
        get
        {
            throw new NotImplementedException();
        }
    }
        set { throw new System.NotImplementedException(); }
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




