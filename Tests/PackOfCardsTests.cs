using Code;
using Xunit;

namespace Tests
{
    public class PackOfCardsTests
    {
        [Fact]
        public void can_create_pack_cards()
        {
            var packOfCards = new PackOfCards();
            
            Assert.Equal(13, packOfCards.Clubs.Count);
            Assert.Equal(13, packOfCards.Diamonds.Count);
            Assert.Equal(13, packOfCards.Hearts.Count);
            Assert.Equal(13, packOfCards.Spades.Count);

            for (var index = 0; index < 13; index++)
            {
                Assert.Equal(CardSuit.Clubs, packOfCards.Clubs[index].CardSuit);
                Assert.Equal((CardValue)index, packOfCards.Clubs[index].CardValue);
                Assert.Equal(CardSuit.Diamonds, packOfCards.Diamonds[index].CardSuit);
                Assert.Equal((CardValue)index, packOfCards.Diamonds[index].CardValue);
                Assert.Equal(CardSuit.Hearts, packOfCards.Hearts[index].CardSuit);
                Assert.Equal((CardValue)index, packOfCards.Hearts[index].CardValue);
                Assert.Equal(CardSuit.Spades, packOfCards.Spades[index].CardSuit);
                Assert.Equal((CardValue)index, packOfCards.Spades[index].CardValue);
            }
        }
    }
}