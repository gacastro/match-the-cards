using System;
using System.Collections.Generic;

namespace Code.Helpers
{
    public class DeckOfCardsBuilder
    {
        private readonly List<Card> _cards;

        public DeckOfCardsBuilder(int numberOfPacks)
        {
            _cards = new List<Card>();
            
            for (var i = 0; i < numberOfPacks; i++)
            {
                var packOfCards = new PackOfCards();
                _cards.AddRange(packOfCards.Clubs);
                _cards.AddRange(packOfCards.Diamonds);
                _cards.AddRange(packOfCards.Hearts);
                _cards.AddRange(packOfCards.Spades);
            }
        }

        public Stack<Card> BuildShuffledDeck()
        {
            var deck = new Stack<Card>();
            var indexGenerator = new Random();
            var amountOfCards = _cards.Count;

            while (amountOfCards > 0)
            {
                // accomodate for the zero indexing of the list and that maxValue is not inclusive
                var maxValue = --amountOfCards + 1;
                var index = indexGenerator.Next(maxValue);
                deck.Push(_cards[index]);
                _cards.RemoveAt(index);
            }

            return deck;
        }
    }
}