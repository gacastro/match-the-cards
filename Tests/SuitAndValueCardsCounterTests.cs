using Code;
using Xunit;

namespace Tests
{
    public class SuitAndValueCardsCounterTests
    {
        private readonly SuitAndValueCardCounter _suitAndValueCardCounter;

        public SuitAndValueCardsCounterTests()
        {
            _suitAndValueCardCounter = new SuitAndValueCardCounter(4);
        }

        [Fact]
        public void game_over_when_one_pack()
        {
            var suitAndValueCardCounter = new SuitAndValueCardCounter(1);
            var isGameOver = suitAndValueCardCounter.IsGameOver(new Card(CardSuit.Clubs, CardValue.Five));
            
            Assert.True(isGameOver);
        }
        
        [Fact]
        public void can_count_ace_clubs()
        {
            var isGameOver = _suitAndValueCardCounter.IsGameOver(new Card(CardSuit.Clubs, CardValue.Ace));
            
            Assert.False(isGameOver);
            Assert.Equal(1, _suitAndValueCardCounter.AceClubsCounter);
            Assert.Equal(0, _suitAndValueCardCounter.CardsCounter);
        }
        
        [Fact]
        public void can_maxout_ace_clubs()
        {
            var isGameOver = true;
            for (var i = 0; i < 3; i++)
            {
                isGameOver = _suitAndValueCardCounter.IsGameOver(new Card(CardSuit.Clubs, CardValue.Ace));
            }
            
            Assert.False(isGameOver);
            Assert.Equal(3, _suitAndValueCardCounter.AceClubsCounter);
            Assert.Equal(1, _suitAndValueCardCounter.CardsCounter);
        }
        
        //todo: later on continue with the above pattern for the rest of the cards in the pack 
        
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(10)]
        public void can_assert_game_over(int numberOfPacks)
        {
            var suitAndValueCardCounter = new SuitAndValueCardCounter(numberOfPacks);
            var isGameOver = false;
            for (var numberPacks = 0; numberPacks < numberOfPacks; numberPacks++)
            {
                for (var cardSuit = 0; cardSuit < 4; cardSuit++)
                {
                    for (var cardValue = 0; cardValue < 13; cardValue++)
                    {
                        isGameOver =
                            suitAndValueCardCounter.IsGameOver(
                                new Card((CardSuit)cardSuit, (CardValue)cardValue));
                    }
                }
            }

            Assert.True(isGameOver);
            Assert.Equal(52, suitAndValueCardCounter.CardsCounter);
        }
    }
}