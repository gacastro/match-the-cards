using Code;
using Xunit;

namespace Tests
{
    //in all of the tests we're inserting a ridiculous card suit but its just to prove it doesn't matter
    public class ValueCardsCounterTests
    {
        private readonly ValueCardsCounter _valueCardsCounter;

        public ValueCardsCounterTests()
        {
            _valueCardsCounter = new ValueCardsCounter(1);
        }
        
        [Fact]
        public void can_count_ace_cards()
        {
            var isGameOver = _valueCardsCounter.IsGameOver(new Card((CardSuit)28, CardValue.Ace));
            
            Assert.False(isGameOver);
            Assert.Equal(1, _valueCardsCounter.AceCounter);
            Assert.Equal(0, _valueCardsCounter.ValueCounter);
        }
        
        [Fact]
        public void can_maxout_ace_cards()
        {
            var isGameOver = true;
            for (var i = 0; i < 3; i++)
            {
                isGameOver = _valueCardsCounter.IsGameOver(new Card((CardSuit)28, CardValue.Ace));
            }
            
            Assert.False(isGameOver);
            Assert.Equal(3, _valueCardsCounter.AceCounter);
            Assert.Equal(1, _valueCardsCounter.ValueCounter);
        }
        
        [Fact]
        public void can_count_two_cards()
        {
            var isGameOver = _valueCardsCounter.IsGameOver(new Card((CardSuit)28, CardValue.Two));
            
            Assert.False(isGameOver);
            Assert.Equal(1, _valueCardsCounter.TwoCounter);
            Assert.Equal(0, _valueCardsCounter.ValueCounter);
        }
        
        [Fact]
        public void can_maxout_two_cards()
        {
            var isGameOver = true;
            for (var i = 0; i < 3; i++)
            {
                isGameOver = _valueCardsCounter.IsGameOver(new Card((CardSuit)28, CardValue.Two));
            }
            
            Assert.False(isGameOver);
            Assert.Equal(3, _valueCardsCounter.TwoCounter);
            Assert.Equal(1, _valueCardsCounter.ValueCounter);
        }
        
        [Fact]
        public void can_count_three_cards()
        {
            var isGameOver = _valueCardsCounter.IsGameOver(new Card((CardSuit)28, CardValue.Three));
            
            Assert.False(isGameOver);
            Assert.Equal(1, _valueCardsCounter.ThreeCounter);
            Assert.Equal(0, _valueCardsCounter.ValueCounter);
        }
        
        [Fact]
        public void can_maxout_three_cards()
        {
            var isGameOver = true;
            for (var i = 0; i < 3; i++)
            {
                isGameOver = _valueCardsCounter.IsGameOver(new Card((CardSuit)28, CardValue.Three));
            }
            
            Assert.False(isGameOver);
            Assert.Equal(3, _valueCardsCounter.ThreeCounter);
            Assert.Equal(1, _valueCardsCounter.ValueCounter);
        }
        
        [Fact]
        public void can_count_four_cards()
        {
            var isGameOver = _valueCardsCounter.IsGameOver(new Card((CardSuit)28, CardValue.Four));
            
            Assert.False(isGameOver);
            Assert.Equal(1, _valueCardsCounter.FourCounter);
            Assert.Equal(0, _valueCardsCounter.ValueCounter);
        }
        
        [Fact]
        public void can_maxout_four_cards()
        {
            var isGameOver = true;
            for (var i = 0; i < 3; i++)
            {
                isGameOver = _valueCardsCounter.IsGameOver(new Card((CardSuit)28, CardValue.Four));
            }
            
            Assert.False(isGameOver);
            Assert.Equal(3, _valueCardsCounter.FourCounter);
            Assert.Equal(1, _valueCardsCounter.ValueCounter);
        }
        
        [Fact]
        public void can_count_five_cards()
        {
            var isGameOver = _valueCardsCounter.IsGameOver(new Card((CardSuit)28, CardValue.Five));
            
            Assert.False(isGameOver);
            Assert.Equal(1, _valueCardsCounter.FiveCounter);
            Assert.Equal(0, _valueCardsCounter.ValueCounter);
        }
        
        [Fact]
        public void can_maxout_five_cards()
        {
            var isGameOver = true;
            for (var i = 0; i < 3; i++)
            {
                isGameOver = _valueCardsCounter.IsGameOver(new Card((CardSuit)28, CardValue.Five));
            }
            
            Assert.False(isGameOver);
            Assert.Equal(3, _valueCardsCounter.FiveCounter);
            Assert.Equal(1, _valueCardsCounter.ValueCounter);
        }
        
        [Fact]
        public void can_count_six_cards()
        {
            var isGameOver = _valueCardsCounter.IsGameOver(new Card((CardSuit)28, CardValue.Six));
            
            Assert.False(isGameOver);
            Assert.Equal(1, _valueCardsCounter.SixCounter);
            Assert.Equal(0, _valueCardsCounter.ValueCounter);
        }
        
        [Fact]
        public void can_maxout_six_cards()
        {
            var isGameOver = true;
            for (var i = 0; i < 3; i++)
            {
                isGameOver = _valueCardsCounter.IsGameOver(new Card((CardSuit)28, CardValue.Six));
            }
            
            Assert.False(isGameOver);
            Assert.Equal(3, _valueCardsCounter.SixCounter);
            Assert.Equal(1, _valueCardsCounter.ValueCounter);
        }
        
        //todo: later on continue with the above pattern for the rest of the values 7-king 
        
        [Fact]
        public void can_assert_game_over()
        {
            var isGameOver = false;
            for (var cardValue = 0; cardValue < 13; cardValue++)
            {
                for (var i = 0; i < 3; i++)
                {
                    isGameOver = _valueCardsCounter.IsGameOver(new Card((CardSuit)28, (CardValue)cardValue));
                }
            }

            Assert.True(isGameOver);
            Assert.Equal(3, _valueCardsCounter.AceCounter);
            Assert.Equal(3, _valueCardsCounter.TwoCounter);
            Assert.Equal(3, _valueCardsCounter.ThreeCounter);
            Assert.Equal(3, _valueCardsCounter.FourCounter);
            Assert.Equal(3, _valueCardsCounter.FiveCounter);
            Assert.Equal(3, _valueCardsCounter.SixCounter);
            Assert.Equal(3, _valueCardsCounter.SevenCounter);
            Assert.Equal(3, _valueCardsCounter.EightCounter);
            Assert.Equal(3, _valueCardsCounter.NineCounter);
            Assert.Equal(3, _valueCardsCounter.TenCounter);
            Assert.Equal(3, _valueCardsCounter.JackCounter);
            Assert.Equal(3, _valueCardsCounter.QueenCounter);
            Assert.Equal(3, _valueCardsCounter.KingCounter);
            Assert.Equal(13, _valueCardsCounter.ValueCounter);
        }
    }
}