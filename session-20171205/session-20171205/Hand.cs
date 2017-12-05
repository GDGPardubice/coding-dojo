using System;
using System.Collections.Generic;
using System.Linq;

namespace session_20171205
{
    public class Hand
    {
        private Card.CardValue[] _cardValues;

        public Hand(Card.CardValue[] cardValues)
        {
            if (cardValues.Length != 5)
            {
                throw  new ArgumentException("Count of cards isn't five.");
            }
            _cardValues = cardValues;
        }

        public Card.CardValue GetHighestCardValue()
        {
            var sortedCardValues = _cardValues.ToList();
            sortedCardValues.Sort();
            return sortedCardValues.Last();
        }

        public bool HasPair()
        {
            var dictionary = new Dictionary<Card.CardValue, int>();
            
            foreach (var cardValue in _cardValues){
                if (dictionary.ContainsKey(cardValue))
                {
                    dictionary[cardValue]++;
                }
                else
                {
                    dictionary[cardValue] = 1;
                }
            }

            return dictionary.Any(entry => entry.Value >= 2);
        }
    }


}