using Code;
using Code.Helpers;
using Xunit;

namespace Tests
{
    public class CardCounterBuilderTests
    {
        [Fact]
        public void can_build_suit_card_counter()
        {
            var cardCounter = new CardCounterBuilder(MatchCondition.Suit, 1).Build();

            Assert.IsType<SuitCardsCounter>(cardCounter);
        }
        
        [Fact]
        public void can_build_value_card_counter()
        {
            var cardCounter = new CardCounterBuilder(MatchCondition.Value, 1).Build();

            Assert.IsType<ValueCardsCounter>(cardCounter);
        }
        
        [Fact]
        public void can_build_suit_and_value_card_counter()
        {
            var cardCounter = new CardCounterBuilder(MatchCondition.SuitAndValue, 1).Build();

            Assert.IsType<SuitAndValueCardCounter>(cardCounter);
        }
        
        [Fact]
        public void returns_null_when_there_is_no_builder()
        {
            var cardCounter = new CardCounterBuilder((MatchCondition)7, 1).Build();

            Assert.Null(cardCounter);
        }
    }
}