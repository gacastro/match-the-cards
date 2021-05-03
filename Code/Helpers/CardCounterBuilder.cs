namespace Code.Helpers
{
    public class CardCounterBuilder
    {
        private readonly ICardCounter _cardCounter;
        
        public CardCounterBuilder(MatchCondition matchCondition, int numberOfPacks)
        {
            switch (matchCondition)
            {
                case MatchCondition.Suit:
                    _cardCounter = new SuitCardsCounter(numberOfPacks);
                    break;
                case MatchCondition.Value:
                    _cardCounter = new ValueCardsCounter(numberOfPacks);
                    break;
                case MatchCondition.SuitAndValue:
                    _cardCounter = new SuitAndValueCardCounter(numberOfPacks);
                    break;
            }
        }

        public ICardCounter Build()
        {
            return _cardCounter;
        }
    }
}