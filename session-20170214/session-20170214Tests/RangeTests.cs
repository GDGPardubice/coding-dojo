using NUnit.Framework;
using session_20170214;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_20170214.Tests
{
    [TestFixture]
    public class RangeTests
    {
        [Test]
        public void ClosedFromLeftIntervalStringIsValid()
        {
            Range range = new Range("[2,6)");
            Assert.IsTrue(range.IsValid());
        }

        [Test]
        public void NotIntervalStringIsNotValid()
        {
            Range range = new Range("[2,");
            Assert.IsFalse(range.IsValid());
        }

        [Test]
        public void ClosedIntervalFromBothSidesStringIsValid()
        {
            Range range = new Range("[2, 3]");
            Assert.IsTrue(range.IsValid());
        }

        [Test]
        public void ClosedIntervalFromRightSideStringIsValid()
        {
            Range range = new Range("(2, 3]");
            Assert.IsTrue(range.IsValid());
        }

        [Test]
        public void IntervalWithIncorectCharStringIsNotValid()
        {
            Range range = new Range("(2(, 3]");
            Assert.IsFalse(range.IsValid());
        }

        [Test]
        public void IntervalWithTwoSeparatorIsNotValid()
        {
            Range range = new Range("(2,, 3]");
            Assert.IsFalse(range.IsValid());
        }
        
        [Test]
        public void EmptyClosedIntervalIsNotValid()
        {
            Range range = new Range("[]");
            Assert.IsFalse(range.IsValid());
        }

        [Test]
        public void IntervalWithoutEndNumber()
        {
            Range range = new Range("[3]");
            Assert.IsFalse(range.IsValid());
        }

        [Test]
        public void IntervalWithThreeNumberIsNotValid()
        {
            Range range = new Range("[3,4,4]");
            Assert.IsFalse(range.IsValid());
        }

        [Test]
        public void IntervalStartWithDoubleDigitNumber()
        {
            Range range = new Range("[63,5]");
            Assert.IsTrue(range.IsValid());
        }

    }
}