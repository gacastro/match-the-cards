using System.Collections.Generic;

namespace Code
{
    public class Dealer
    {
        public int DeckSize => _deck.Count;
        public int PileSize => _pile.Count;

        private readonly Stack<Card> _deck;
        private readonly Stack<Card> _pile;
        private readonly Queue<Player> _players;
        private readonly CardMatcher _cardMatcher;
        private readonly ICardCounter _cardCounter;

        public Dealer(Stack<Card> deck, Queue<Player> players, CardMatcher cardMatcher, ICardCounter cardCounter)
        {
            _deck = deck;
            _players = players;
            _cardMatcher = cardMatcher;
            _cardCounter = cardCounter;

            _pile = new Stack<Card>();
        }
        
        public Play Deals()
        {
            var card = _deck.Pop();

            if (_pile.Count == 0)
            {
                _pile.Push(card);
                return new Play(true);
            }
            
            var previousCard = _pile.Peek();
            _pile.Push(card);
            
            var isAMatch = _cardMatcher.VerifyMatch(card, previousCard);

            if (isAMatch)
            {
                var winnings = _pile.Count;
                _pile.Clear();
                var winner = _players.Dequeue();
                winner.TakeWinnings(winnings);
                _players.Enqueue(winner);
            }

            var noMoreCardMatches = _cardCounter.IsGameOver(card);
            var emptyDeck = _deck.Count == 0;

            if (noMoreCardMatches || emptyDeck)
            {
                return GameOver();
            }
            
            return new Play(true);
        }

        private Play GameOver()
        {
            _pile.Clear();
            
            var firstPlayer = _players.Dequeue();
            var secondPlayer = _players.Dequeue();

            if (firstPlayer.Winnings > secondPlayer.Winnings)
            {
                return new Play(firstPlayer, false, firstPlayer.Winnings);
            }

            return secondPlayer.Winnings > firstPlayer.Winnings 
                ? new Play(secondPlayer, false, secondPlayer.Winnings) 
                : new Play(null, false, firstPlayer.Winnings);
        }
    }
}