using Code;
using Xunit;

namespace Tests
{
    public class CardMatcherTests
    {
        [Theory]
        [InlineData(CardSuit.Clubs, CardSuit.Clubs, true)]
        [InlineData(CardSuit.Clubs, CardSuit.Diamonds, false)]
        public void can_match_on_suit(CardSuit firstCardSuit, CardSuit secondCardSuit, bool expected)
        {
            var firstCard = new Card(firstCardSuit, CardValue.Ace);
            var secondCard = new Card(secondCardSuit, CardValue.Ace);

            var cardMatcher = new CardMatcher(MatchCondition.Suit);
            var result = cardMatcher.VerifyMatch(firstCard, secondCard);
            
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(CardValue.Ace, CardValue.Ace, true)]
        [InlineData(CardValue.Ace, CardValue.Jack, false)]
        public void can_match_on_value(CardValue firstCardValue, CardValue secondCardValue, bool expected)
        {
            var firstCard = new Card(CardSuit.Hearts, firstCardValue);
            var secondCard = new Card(CardSuit.Hearts, secondCardValue);

            var cardMatcher = new CardMatcher(MatchCondition.Value);
            var result = cardMatcher.VerifyMatch(firstCard, secondCard);
            
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(CardSuit.Clubs, CardValue.Ace, CardSuit.Clubs, CardValue.Ace, true)]
        [InlineData(CardSuit.Clubs, CardValue.Ace, CardSuit.Clubs, CardValue.Jack, false)]
        [InlineData(CardSuit.Clubs, CardValue.Ace, CardSuit.Hearts, CardValue.Ace, false)]
        public void can_match_on_suit_and_value(
            CardSuit firstCardSuit, CardValue firstCardValue,
            CardSuit secondCardSuit, CardValue secondCardValue, 
            bool expected)
        {
            var firstCard = new Card(firstCardSuit, firstCardValue);
            var secondCard = new Card(secondCardSuit, secondCardValue);

            var cardMatcher = new CardMatcher(MatchCondition.SuitAndValue);
            var result = cardMatcher.VerifyMatch(firstCard, secondCard);
            
            Assert.Equal(expected, result);
        }
    }
}