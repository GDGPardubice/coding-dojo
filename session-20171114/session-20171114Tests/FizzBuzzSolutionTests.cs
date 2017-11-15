using NUnit.Framework;
using session_20171114;

namespace session_20171114Tests
{
    [TestFixture]
    public class FizzBuzzSolutionTests
    {
        [Test]
        public void NumberOneReturnsOneAsString()
        {
            string expected = "1";
            string actual = FizzBuzzSolution.FizzBuzz(1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NumberTwoReturnsTwoAsString()
        {
            string expected = "2";
            string actual = FizzBuzzSolution.FizzBuzz(2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NumberFourReturnsFourAsString()
        {
            string expected = "4";
            string actual = FizzBuzzSolution.FizzBuzz(4);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void MultiplyOfThreeReturnsFizz(int number)
        {
            string expected = FizzBuzzSolution.FIZZ;
            string actual = FizzBuzzSolution.FizzBuzz(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5)]
        [TestCase(10)]
        public void MultiplyOfFiveReturnsBuzz(int number)
        {
            string expected = FizzBuzzSolution.BUZZ;
            string actual = FizzBuzzSolution.FizzBuzz(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15)]
        [TestCase(30)]
        public void NumberFifteenReturnsFizzBuzz(int number)
        {
            string expected = "FizzBuzz";
            string actual = FizzBuzzSolution.FizzBuzz(number);
            Assert.AreEqual(expected, actual);
        }
    }
}