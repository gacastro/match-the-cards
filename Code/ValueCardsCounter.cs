namespace Code
{
    public class ValueCardsCounter : ICardCounter
    {
        public int ValueCounter { get; private set; }
        public int AceCounter { get; private set; }
        public int TwoCounter { get; private set; }
        public int ThreeCounter { get; private set; }
        public int FourCounter { get; private set; }
        public int FiveCounter { get; private set; }
        public int SixCounter { get; private set; }
        public int SevenCounter { get; private set; }
        public int EightCounter { get; private set; }
        public int NineCounter { get; private set; }
        public int TenCounter { get; private set; }
        public int JackCounter { get; private set; }
        public int QueenCounter { get; private set; }
        public int KingCounter { get; private set; }
        
        private readonly int _maxValues;
        private readonly int _maxCardsPerValue;

        public ValueCardsCounter(int numberOfPacks)
        {
            _maxCardsPerValue = 3 * numberOfPacks;
            _maxValues = 13;
        }

        public bool IsGameOver(Card card)
        {
            switch (card.CardValue)
            {
                case CardValue.Ace:
                    CountAces();
                    break;
                case CardValue.Two:
                    CountTwo();
                    break;
                case CardValue.Three:
                    CountThree();
                    break;
                case CardValue.Four:
                    CountFour();
                    break;
                case CardValue.Five:
                    CountFive();
                    break;
                case CardValue.Six:
                    CountSix();
                    break;
                case CardValue.Seven:
                    CountSeven();
                    break;
                case CardValue.Eight:
                    CountEight();
                    break;
                case CardValue.Nine:
                    CountNine();
                    break;
                case CardValue.Ten:
                    CountTen();
                    break;
                case CardValue.Jack:
                    CountJack();
                    break;
                case CardValue.Queen:
                    CountQueen();
                    break;
                case CardValue.King:
                    CountKing();
                    break;
            }

            return ValueCounter == _maxValues;
        }
        
        private void CountAces()
        {
            AceCounter++;
            if (AceCounter == _maxCardsPerValue)
            {
                ValueCounter++;
            }
        }
        
        private void CountTwo()
        {
            TwoCounter++;
            if (TwoCounter == _maxCardsPerValue)
            {
                ValueCounter++;
            }
        }
        
        private void CountThree()
        {
            ThreeCounter++;
            if (ThreeCounter == _maxCardsPerValue)
            {
                ValueCounter++;
            }
        }
        
        private void CountFour()
        {
            FourCounter++;
            if (FourCounter == _maxCardsPerValue)
            {
                ValueCounter++;
            }
        }
        
        private void CountFive()
        {
            FiveCounter++;
            if (FiveCounter == _maxCardsPerValue)
            {
                ValueCounter++;
            }
        }
        
        private void CountSix()
        {
            SixCounter++;
            if (SixCounter == _maxCardsPerValue)
            {
                ValueCounter++;
            }
        }
        
        private void CountSeven()
        {
            SevenCounter++;
            if (SevenCounter == _maxCardsPerValue)
            {
                ValueCounter++;
            }
        }
        
        private void CountEight()
        {
            EightCounter++;
            if (EightCounter == _maxCardsPerValue)
            {
                ValueCounter++;
            }
        }
        
        private void CountNine()
        {
            NineCounter++;
            if (NineCounter == _maxCardsPerValue)
            {
                ValueCounter++;
            }
        }
        
        private void CountTen()
        {
            TenCounter++;
            if (TenCounter == _maxCardsPerValue)
            {
                ValueCounter++;
            }
        }
        
        private void CountJack()
        {
            JackCounter++;
            if (JackCounter == _maxCardsPerValue)
            {
                ValueCounter++;
            }
        }
        
        private void CountQueen()
        {
            QueenCounter++;
            if (QueenCounter == _maxCardsPerValue)
            {
                ValueCounter++;
            }
        }
        
        private void CountKing()
        {
            KingCounter++;
            if (KingCounter == _maxCardsPerValue)
            {
                ValueCounter++;
            }
        }
    }
}