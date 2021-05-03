namespace Code
{
    public class SuitCardsCounter: ICardCounter
    {
        public int SuitsCounter { get; private set; }
        public int ClubsCounter { get; private set; }
        public int SpadesCounter { get; private set; }
        public int HeartsCounter { get; private set; }
        public int DiamondsCounter { get; private set; }

        private readonly int _maxSuits;
        private readonly int _maxCards;

        public SuitCardsCounter(int numberOfPacks)
        {
            _maxCards = 12 * numberOfPacks;
            _maxSuits = 4;
        }
        
        public bool IsGameOver(Card card)
        {
            switch (card.CardSuit)
            {
                case CardSuit.Clubs:
                    CountClubs();
                    break;
                case CardSuit.Spades:
                    CountSpades();
                    break;
                case CardSuit.Hearts:
                    CountHearts();
                    break;
                case CardSuit.Diamonds:
                    CountDiamonds();
                    break;
            }

            return SuitsCounter == _maxSuits;
        }

        private void CountClubs()
        {
            ClubsCounter++;
            if (ClubsCounter == _maxCards)
            {
                SuitsCounter++;
            }
        }
        
        private void CountSpades()
        {
            SpadesCounter++;
            if (SpadesCounter == _maxCards)
            {
                SuitsCounter++;
            }
        }
        
        private void CountHearts()
        {
            HeartsCounter++;
            if (HeartsCounter == _maxCards)
            {
                SuitsCounter++;
            }
        }
        
        private void CountDiamonds()
        {
            DiamondsCounter++;
            if (DiamondsCounter == _maxCards)
            {
                SuitsCounter++;
            }
        }
    }
}