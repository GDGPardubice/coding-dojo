using NUnit.Framework;
using session_20170307;

namespace session_20170307Tests
{
    [TestFixture]
    public class RangeTests
    {
        [Test]
        public void ValidRangeStringIsValid()
        {
            var range = new Range("[1;5]");
            Assert.IsTrue(range.IsValidRange());
        }

        [Test]
        public void InvalidRangeStringIsInvalid()
        {
            var range = new Range("[1;5");
            Assert.IsFalse(range.IsValidRange());
        }

        [Test]
        public void ValidRangeWithSpaceIsValid()
        {
            var range = new Range("[1; 5]");
            Assert.IsTrue(range.IsValidRange());
        }

        [Test]
        public void RangeWithoutSeparatorIsInvalid()
        {
            var range = new Range("[1 5]");
            Assert.IsFalse(range.IsValidRange());
        }

        [Test]
        public void RangeWithSpaceBeforeFirstNumber()
        {
            var range = new Range("[ 1; 5]");
            Assert.IsTrue(range.IsValidRange());
        }

        [Test]
        public void RangeWithoutLeftBoundaryIsInvalid()
        {
            var range = new Range(" 1; 5]");
            Assert.IsFalse(range.IsValidRange());
        }

        [Test]
        public void RangeWithSpaceAfterNumberIsValid()
        {
            var range = new Range("[1 ; 5 ]");
            Assert.IsTrue(range.IsValidRange());
        }

        [Test]
        public void TwoMultipleDigitNumberIsValidAs()
        {
            var range = new Range("[51 ; 52 ]");
            Assert.IsTrue(range.IsValidRange());
        }

        [Test]
        public void BoundaryWithSpaceInsideIsNotValidAsBoundaryValue()
        {
            var range = new Range("[51 ; 5 2 ]");
            Assert.IsFalse(range.IsValidRange());
        }

        [Test]
        public void NegativeBoundaryValuesAreValid()
        {
            var range = new Range("[-51 ; 2 ]");
            Assert.IsTrue(range.IsValidRange());
            range = new Range("[51 ; -2 ]");
            Assert.IsTrue(range.IsValidRange());
        }

        [Test]
        public void MultipleLeftBoundaryIsInvalid()
        {
            var range = new Range("[[ 51; 52 ]");
            Assert.IsFalse(range.IsValidRange());
        }

        [Test]
        public void DoubleRightBoundaryIsInvalid()
        {
            var range = new Range("< 51; 52 ]]");
            Assert.IsFalse(range.IsValidRange());
        }

        [Test]
        public void RangeWithTwoSeparatorIsInvalid()
        {
            var range = new Range("< 51; 52;5]");
            Assert.IsFalse(range.IsValidRange());
        }

        [Test]
        public void RangeIsOpenFromLeft()
        {
            var range = new Range("< 51; 52]");
            Assert.IsTrue(range.IsOpenFromLeft);
        }

        [Test]
        public void RangeIsOpenFromRight()
        {
            var range = new Range("< 51; 52>");
            Assert.IsTrue(range.IsOpenFromRight);
        }

        [Test]
        public void LeftBoundaryIsCorrect()
        {
            var range = new Range("< 51; 52>");
            Assert.AreEqual(51, range.LeftBoundary);
        }

        [Test]
        public void RightBoundaryIsCorrect()
        {
            var range = new Range("< 51; 52>");
            Assert.AreEqual(52, range.RightBoundary);
        }
    }
}