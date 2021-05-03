namespace Code
{
    public class SuitAndValueCardCounter : ICardCounter
    {
        public int CardsCounter { get; private set; }
        
        public int AceClubsCounter { get; private set; }
        public int TwoClubsCounter { get; private set; }
        public int ThreeClubsCounter { get; private set; }
        public int FourClubsCounter { get; private set; }
        public int FiveClubsCounter { get; private set; }
        public int SixClubsCounter { get; private set; }
        public int SevenClubsCounter { get; private set; }
        public int EightClubsCounter { get; private set; }
        public int NineClubsCounter { get; private set; }
        public int TenClubsCounter { get; private set; }
        public int JackClubsCounter { get; private set; }
        public int QueenClubsCounter { get; private set; }
        public int KingClubsCounter { get; private set; }
        
        public int AceDiamondsCounter { get; private set; }
        public int TwoDiamondsCounter { get; private set; }
        public int ThreeDiamondsCounter { get; private set; }
        public int FourDiamondsCounter { get; private set; }
        public int FiveDiamondsCounter { get; private set; }
        public int SixDiamondsCounter { get; private set; }
        public int SevenDiamondsCounter { get; private set; }
        public int EightDiamondsCounter { get; private set; }
        public int NineDiamondsCounter { get; private set; }
        public int TenDiamondsCounter { get; private set; }
        public int JackDiamondsCounter { get; private set; }
        public int QueenDiamondsCounter { get; private set; }
        public int KingDiamondsCounter { get; private set; }
        
        public int AceHeartsCounter { get; private set; }
        public int TwoHeartsCounter { get; private set; }
        public int ThreeHeartsCounter { get; private set; }
        public int FourHeartsCounter { get; private set; }
        public int FiveHeartsCounter { get; private set; }
        public int SixHeartsCounter { get; private set; }
        public int SevenHeartsCounter { get; private set; }
        public int EightHeartsCounter { get; private set; }
        public int NineHeartsCounter { get; private set; }
        public int TenHeartsCounter { get; private set; }
        public int JackHeartsCounter { get; private set; }
        public int QueenHeartsCounter { get; private set; }
        public int KingHeartsCounter { get; private set; }
        
        public int AceSpadesCounter { get; private set; }
        public int TwoSpadesCounter { get; private set; }
        public int ThreeSpadesCounter { get; private set; }
        public int FourSpadesCounter { get; private set; }
        public int FiveSpadesCounter { get; private set; }
        public int SixSpadesCounter { get; private set; }
        public int SevenSpadesCounter { get; private set; }
        public int EightSpadesCounter { get; private set; }
        public int NineSpadesCounter { get; private set; }
        public int TenSpadesCounter { get; private set; }
        public int JackSpadesCounter { get; private set; }
        public int QueenSpadesCounter { get; private set; }
        public int KingSpadesCounter { get; private set; }

        private readonly int _maxCards;
        private readonly int _numberOfPacks;
        private readonly int _maxSuitAndValueCards;

        public SuitAndValueCardCounter(int numberOfPacks)
        {
            _maxCards = 52;
            _numberOfPacks = numberOfPacks;
            _maxSuitAndValueCards = --numberOfPacks;
        }
        
        public bool IsGameOver(Card card)
        {
            if (_numberOfPacks == 1)
            {
                return true;
            }
            
            switch (card.CardSuit)
            {
                case CardSuit.Clubs:
                    CountClubs(card.CardValue);
                    break;
                case CardSuit.Spades:
                    CountSpades(card.CardValue);
                    break;
                case CardSuit.Hearts:
                    CountHearts(card.CardValue);
                    break;
                case CardSuit.Diamonds:
                    CountDiamonds(card.CardValue);
                    break;
            }

            return CardsCounter == _maxCards;
        }
        
        private void CountClubs(CardValue value)
        {
            switch (value)
            {
                case CardValue.Ace:
                    CountAceClubs();
                    break;
                case CardValue.Two:
                    CountTwoClubs();
                    break;
                case CardValue.Three:
                    CountThreeClubs();
                    break;
                case CardValue.Four:
                    CountFourClubs();
                    break;
                case CardValue.Five:
                    CountFiveClubs();
                    break;
                case CardValue.Six:
                    CountSixClubs();
                    break;
                case CardValue.Seven:
                    CountSevenClubs();
                    break;
                case CardValue.Eight:
                    CountEightClubs();
                    break;
                case CardValue.Nine:
                    CountNineClubs();
                    break;
                case CardValue.Ten:
                    CountTenClubs();
                    break;
                case CardValue.Jack:
                    CountJackClubs();
                    break;
                case CardValue.Queen:
                    CountQueenClubs();
                    break;
                case CardValue.King:
                    CountKingClubs();
                    break;
            }
        }

        private void CountAceClubs()
        {
            AceClubsCounter++;
            if (AceClubsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountTwoClubs()
        {
            TwoClubsCounter++;
            if (TwoClubsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountThreeClubs()
        {
            ThreeClubsCounter++;
            if (ThreeClubsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountFourClubs()
        {
            FourClubsCounter++;
            if (FourClubsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountFiveClubs()
        {
            FiveClubsCounter++;
            if (FiveClubsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountSixClubs()
        {
            SixClubsCounter++;
            if (SixClubsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountSevenClubs()
        {
            SevenClubsCounter++;
            if (SevenClubsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountEightClubs()
        {
            EightClubsCounter++;
            if (EightClubsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountNineClubs()
        {
            NineClubsCounter++;
            if (NineClubsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountTenClubs()
        {
            TenClubsCounter++;
            if (TenClubsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountJackClubs()
        {
            JackClubsCounter++;
            if (JackClubsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountQueenClubs()
        {
            QueenClubsCounter++;
            if (QueenClubsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountKingClubs()
        {
            KingClubsCounter++;
            if (KingClubsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }
        
        private void CountSpades(CardValue value)
        {
            switch (value)
            {
                case CardValue.Ace:
                    CountAceSpades();
                    break;
                case CardValue.Two:
                    CountTwoSpades();
                    break;
                case CardValue.Three:
                    CountThreeSpades();
                    break;
                case CardValue.Four:
                    CountFourSpades();
                    break;
                case CardValue.Five:
                    CountFiveSpades();
                    break;
                case CardValue.Six:
                    CountSixSpades();
                    break;
                case CardValue.Seven:
                    CountSevenSpades();
                    break;
                case CardValue.Eight:
                    CountEightSpades();
                    break;
                case CardValue.Nine:
                    CountNineSpades();
                    break;
                case CardValue.Ten:
                    CountTenSpades();
                    break;
                case CardValue.Jack:
                    CountJackSpades();
                    break;
                case CardValue.Queen:
                    CountQueenSpades();
                    break;
                case CardValue.King:
                    CountKingSpades();
                    break;
            }
        }

        private void CountAceSpades()
        {
            AceSpadesCounter++;
            if (AceSpadesCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountTwoSpades()
        {
            TwoSpadesCounter++;
            if (TwoSpadesCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountThreeSpades()
        {
            ThreeSpadesCounter++;
            if (ThreeSpadesCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountFourSpades()
        {
            FourSpadesCounter++;
            if (FourSpadesCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountFiveSpades()
        {
            FiveSpadesCounter++;
            if (FiveSpadesCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountSixSpades()
        {
            SixSpadesCounter++;
            if (SixSpadesCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountSevenSpades()
        {
            SevenSpadesCounter++;
            if (SevenSpadesCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountEightSpades()
        {
            EightSpadesCounter++;
            if (EightSpadesCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountNineSpades()
        {
            NineSpadesCounter++;
            if (NineSpadesCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountTenSpades()
        {
            TenSpadesCounter++;
            if (TenSpadesCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountJackSpades()
        {
            JackSpadesCounter++;
            if (JackSpadesCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountQueenSpades()
        {
            QueenSpadesCounter++;
            if (QueenSpadesCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountKingSpades()
        {
            KingSpadesCounter++;
            if (KingSpadesCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }
        
        private void CountHearts(CardValue value)
        {
            switch (value)
            {
                case CardValue.Ace:
                    CountAceHearts();
                    break;
                case CardValue.Two:
                    CountTwoHearts();
                    break;
                case CardValue.Three:
                    CountThreeHearts();
                    break;
                case CardValue.Four:
                    CountFourHearts();
                    break;
                case CardValue.Five:
                    CountFiveHearts();
                    break;
                case CardValue.Six:
                    CountSixHearts();
                    break;
                case CardValue.Seven:
                    CountSevenHearts();
                    break;
                case CardValue.Eight:
                    CountEightHearts();
                    break;
                case CardValue.Nine:
                    CountNineHearts();
                    break;
                case CardValue.Ten:
                    CountTenHearts();
                    break;
                case CardValue.Jack:
                    CountJackHearts();
                    break;
                case CardValue.Queen:
                    CountQueenHearts();
                    break;
                case CardValue.King:
                    CountKingHearts();
                    break;
            }
        }

        private void CountAceHearts()
        {
            AceHeartsCounter++;
            if (AceHeartsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountTwoHearts()
        {
            TwoHeartsCounter++;
            if (TwoHeartsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountThreeHearts()
        {
            ThreeHeartsCounter++;
            if (ThreeHeartsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountFourHearts()
        {
            FourHeartsCounter++;
            if (FourHeartsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountFiveHearts()
        {
            FiveHeartsCounter++;
            if (FiveHeartsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountSixHearts()
        {
            SixHeartsCounter++;
            if (SixHeartsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountSevenHearts()
        {
            SevenHeartsCounter++;
            if (SevenHeartsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountEightHearts()
        {
            EightHeartsCounter++;
            if (EightHeartsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountNineHearts()
        {
            NineHeartsCounter++;
            if (NineHeartsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountTenHearts()
        {
            TenHeartsCounter++;
            if (TenHeartsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountJackHearts()
        {
            JackHeartsCounter++;
            if (JackHeartsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountQueenHearts()
        {
            QueenHeartsCounter++;
            if (QueenHeartsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountKingHearts()
        {
            KingHeartsCounter++;
            if (KingHeartsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }
        
        private void CountDiamonds(CardValue value)
        {
            switch (value)
            {
                case CardValue.Ace:
                    CountAceDiamonds();
                    break;
                case CardValue.Two:
                    CountTwoDiamonds();
                    break;
                case CardValue.Three:
                    CountThreeDiamonds();
                    break;
                case CardValue.Four:
                    CountFourDiamonds();
                    break;
                case CardValue.Five:
                    CountFiveDiamonds();
                    break;
                case CardValue.Six:
                    CountSixDiamonds();
                    break;
                case CardValue.Seven:
                    CountSevenDiamonds();
                    break;
                case CardValue.Eight:
                    CountEightDiamonds();
                    break;
                case CardValue.Nine:
                    CountNineDiamonds();
                    break;
                case CardValue.Ten:
                    CountTenDiamonds();
                    break;
                case CardValue.Jack:
                    CountJackDiamonds();
                    break;
                case CardValue.Queen:
                    CountQueenDiamonds();
                    break;
                case CardValue.King:
                    CountKingDiamonds();
                    break;
            }
        }

        private void CountAceDiamonds()
        {
            AceDiamondsCounter++;
            if (AceDiamondsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountTwoDiamonds()
        {
            TwoDiamondsCounter++;
            if (TwoDiamondsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountThreeDiamonds()
        {
            ThreeDiamondsCounter++;
            if (ThreeDiamondsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountFourDiamonds()
        {
            FourDiamondsCounter++;
            if (FourDiamondsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountFiveDiamonds()
        {
            FiveDiamondsCounter++;
            if (FiveDiamondsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountSixDiamonds()
        {
            SixDiamondsCounter++;
            if (SixDiamondsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountSevenDiamonds()
        {
            SevenDiamondsCounter++;
            if (SevenDiamondsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountEightDiamonds()
        {
            EightDiamondsCounter++;
            if (EightDiamondsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountNineDiamonds()
        {
            NineDiamondsCounter++;
            if (NineDiamondsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountTenDiamonds()
        {
            TenDiamondsCounter++;
            if (TenDiamondsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountJackDiamonds()
        {
            JackDiamondsCounter++;
            if (JackDiamondsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountQueenDiamonds()
        {
            QueenDiamondsCounter++;
            if (QueenDiamondsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }

        private void CountKingDiamonds()
        {
            KingDiamondsCounter++;
            if (KingDiamondsCounter == _maxSuitAndValueCards)
            {
                CardsCounter++;
            }
        }
    }
}