using Code.Helpers;
using Xunit;

namespace Tests
{
    public class DeckOfCardsBuilderTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(7)]
        public void can_build_shuffled_deck_of_cards_of_any_size(int size)
        {
            var deckBuilder = new DeckOfCardsBuilder(size);

            var shuffledDeck = deckBuilder.BuildShuffledDeck();

            var expected = 13*4*size;
            Assert.Equal(expected, shuffledDeck.Count);
        }
    }
}