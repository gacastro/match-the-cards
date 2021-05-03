using System.Collections.Generic;
using Code;
using Code.Helpers;
using Xunit;

namespace Tests
{
    // a lot of the functionality is tested in the individual entities like
    // verifying matches or
    // ending a game because its not possible to do more sequences
    public class DealerTests
    {
        private const string Bob = "Bob";
        private const string Ray = "Ray";
        private readonly Queue<Player> _players;
        private readonly CardMatcher _cardMatcher;
        private readonly ICardCounter _cardCounter;

        public DealerTests()
        {
            _players = new Queue<Player>();
            _players.Enqueue(new Player(Bob));
            _players.Enqueue(new Player(Ray));
            
            const MatchCondition matchingCondition = MatchCondition.Suit;
            _cardMatcher = new CardMatcher(matchingCondition);
            _cardCounter = new CardCounterBuilder(matchingCondition, 1).Build();
        }

        [Fact]
        public void continues_to_play_when_deck_card_doesnt_match_card_in_pile()
        {
            var deck = new Stack<Card>();
            deck.Push(new Card(CardSuit.Clubs, CardValue.Ace));
            deck.Push(new Card(CardSuit.Diamonds, CardValue.Ace));
            deck.Push(new Card(CardSuit.Spades, CardValue.Ace));
            deck.Push(new Card(CardSuit.Hearts, CardValue.Ace));

            var dealer = new Dealer(deck, _players, _cardMatcher, _cardCounter);
            
            var play = dealer.Deals();
            Assert.Equal(3, dealer.DeckSize);
            Assert.Equal(1, dealer.PileSize);
            Assert.Null(play.Winner);
            Assert.True(play.Continue);
            Assert.Equal(0, play.Score);
            
            play = dealer.Deals();
            Assert.Equal(2, dealer.DeckSize);
            Assert.Equal(2, dealer.PileSize);
            Assert.Null(play.Winner);
            Assert.True(play.Continue);
            Assert.Equal(0, play.Score);
            
            play = dealer.Deals();
            Assert.Equal(1, dealer.DeckSize);
            Assert.Equal(3, dealer.PileSize);
            Assert.Null(play.Winner);
            Assert.True(play.Continue);
            Assert.Equal(0, play.Score);
        }

        [Fact]
        public void stops_playing_when_no_more_cards_in_deck()
        {
            var deck = new Stack<Card>();
            deck.Push(new Card(CardSuit.Clubs, CardValue.Ace));
            deck.Push(new Card(CardSuit.Diamonds, CardValue.Ace));

            var dealer = new Dealer(deck, _players, _cardMatcher, _cardCounter);
            
            dealer.Deals();
            var play = dealer.Deals();
            
            Assert.Equal(0, dealer.DeckSize);
            Assert.Equal(0, dealer.PileSize);
            Assert.False(play.Continue);
        }
        
        //todo: Tests on picking the winner
    }
}