using Code;
using Xunit;

namespace Tests
{
    //in all of the tests we're inserting a ridiculous card value but its just to prove it doesn't matter
    public class SuitCardsCounterTests
    {
        private readonly SuitCardsCounter _suitCardsCounter;

        public SuitCardsCounterTests()
        {
            _suitCardsCounter = new SuitCardsCounter(1);
        }
        
        [Fact]
        public void can_count_clubs_suit()
        {
            var isGameOver = _suitCardsCounter.IsGameOver(new Card(CardSuit.Clubs, (CardValue)7));
            
            Assert.False(isGameOver);
            Assert.Equal(1, _suitCardsCounter.ClubsCounter);
            Assert.Equal(0, _suitCardsCounter.SuitsCounter);
        }
        
        [Fact]
        public void can_maxout_clubs_suit()
        {
            var isGameOver = true;
            for (var i = 0; i < 12; i++)
            {
                isGameOver = _suitCardsCounter.IsGameOver(new Card(CardSuit.Clubs, (CardValue)7));
            }
            
            Assert.False(isGameOver);
            Assert.Equal(12, _suitCardsCounter.ClubsCounter);
            Assert.Equal(1, _suitCardsCounter.SuitsCounter);
        }
        
        [Fact]
        public void can_count_spades_suit()
        {
            var isGameOver = _suitCardsCounter.IsGameOver(new Card(CardSuit.Spades, (CardValue)7));
            
            Assert.False(isGameOver);
            Assert.Equal(1, _suitCardsCounter.SpadesCounter);
            Assert.Equal(0, _suitCardsCounter.SuitsCounter);
        }
        
        [Fact]
        public void can_maxout_spades_suit()
        {
            var isGameOver = true;
            for (var i = 0; i < 12; i++)
            {
                isGameOver = _suitCardsCounter.IsGameOver(new Card(CardSuit.Spades, (CardValue)7));
            }
            
            Assert.False(isGameOver);
            Assert.Equal(12, _suitCardsCounter.SpadesCounter);
            Assert.Equal(1, _suitCardsCounter.SuitsCounter);
        }

        [Fact]
        public void can_count_hearts_suit()
        {
            var isGameOver = _suitCardsCounter.IsGameOver(new Card(CardSuit.Hearts, (CardValue)7));
            
            Assert.False(isGameOver);
            Assert.Equal(1, _suitCardsCounter.HeartsCounter);
            Assert.Equal(0, _suitCardsCounter.SuitsCounter);
        }
        
        [Fact]
        public void can_maxout_hearts_suit()
        {
            var isGameOver = true;
            for (var i = 0; i < 12; i++)
            {
                isGameOver = _suitCardsCounter.IsGameOver(new Card(CardSuit.Hearts, (CardValue)7));
            }
            
            Assert.False(isGameOver);
            Assert.Equal(12, _suitCardsCounter.HeartsCounter);
            Assert.Equal(1, _suitCardsCounter.SuitsCounter);
        }

        [Fact]
        public void can_count_diamonds_suit()
        {
            var isGameOver = _suitCardsCounter.IsGameOver(new Card(CardSuit.Diamonds, (CardValue)7));
            
            Assert.False(isGameOver);
            Assert.Equal(1, _suitCardsCounter.DiamondsCounter);
            Assert.Equal(0, _suitCardsCounter.SuitsCounter);
        }
        
        [Fact]
        public void can_maxout_diamonds_suit()
        {
            var isGameOver = true;
            for (var i = 0; i < 12; i++)
            {
                isGameOver = _suitCardsCounter.IsGameOver(new Card(CardSuit.Diamonds, (CardValue)7));
            }
            
            Assert.False(isGameOver);
            Assert.Equal(12, _suitCardsCounter.DiamondsCounter);
            Assert.Equal(1, _suitCardsCounter.SuitsCounter);
        }

        [Fact]
        public void can_assert_game_over()
        {
            var isGameOver = false;
            for (var cardSuit = 0; cardSuit < 4; cardSuit++)
            {
                for (var i = 0; i < 12; i++)
                {
                    isGameOver = _suitCardsCounter.IsGameOver(new Card((CardSuit)cardSuit, (CardValue)7));
                }
            }

            Assert.True(isGameOver);
            Assert.Equal(12, _suitCardsCounter.DiamondsCounter);
            Assert.Equal(12, _suitCardsCounter.ClubsCounter);
            Assert.Equal(12, _suitCardsCounter.HeartsCounter);
            Assert.Equal(12, _suitCardsCounter.SpadesCounter);
            Assert.Equal(4, _suitCardsCounter.SuitsCounter);
        }
    }
}