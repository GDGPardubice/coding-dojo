using System;
using NUnit.Framework;
using session_20171205;

namespace session_20171205Tests
{
    [TestFixture]
    public class PokerHandTest
    {
        [TestCase(new[]{
            Card.CardValue.Two,
            Card.CardValue.Three,
            Card.CardValue.Four,
            Card.CardValue.Five,
            Card.CardValue.Five
        }, Card.CardValue.Five)]
        [TestCase(new[]{
            Card.CardValue.Two,
            Card.CardValue.Three,
            Card.CardValue.Four,
            Card.CardValue.Five,
            Card.CardValue.Six
        }, Card.CardValue.Six)]
        public void ReturnHighestCardInHand(Card.CardValue[] sourceCardValues,
            Card.CardValue expectedValue)
        {
            Hand instance = new Hand(sourceCardValues);
            var highestCardValue = instance.GetHighestCardValue();
            Assert.AreEqual(highestCardValue,expectedValue);
        }

        [TestCase(new[]
        {
            Card.CardValue.Five,
            Card.CardValue.Ace,
            Card.CardValue.Eight,
            Card.CardValue.Four
        })]
        [TestCase(new[]
        {
            Card.CardValue.Five,
            Card.CardValue.Ace,
            Card.CardValue.Eight,
            Card.CardValue.Four,
            Card.CardValue.Jack,
            Card.CardValue.Nine
        })]
        public void CardCountIsntFive(Card.CardValue[] sourceCardValues)
        {
            bool wasThrown = false;
            try
            {
                var hand = new Hand(sourceCardValues);
            }
            catch (ArgumentException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        [Test]
        public void HandWithPairReturnsHasPair()
        {
            var hand = new Hand(new[]{
                Card.CardValue.Two,
                Card.CardValue.Two,
                Card.CardValue.Four,
                Card.CardValue.Five,
                Card.CardValue.Six
            });

            Assert.IsTrue(hand.HasPair());
        }

        [Test]
        public void HandWithoutPairReturnsHasNotPair()
        {
            var hand = new Hand(new[]{
                Card.CardValue.Jack,
                Card.CardValue.Two,
                Card.CardValue.Four,
                Card.CardValue.Five,
                Card.CardValue.Six
            });

            Assert.IsFalse(hand.HasPair());
        }

        [Test]
        public void HandWithMoreThanTwoSameValuesReturnsPair()
        {
            var hand = new Hand(new[]{
                Card.CardValue.Two,
                Card.CardValue.Two,
                Card.CardValue.Two,
                Card.CardValue.Five,
                Card.CardValue.Six
            });

            Assert.IsTrue(hand.HasPair());
        }

    }
    
}