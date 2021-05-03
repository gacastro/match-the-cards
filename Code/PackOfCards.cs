using System.Collections.Generic;

namespace Code
{
    public class PackOfCards
    {
        public IList<Card> Clubs { get; }
        public IList<Card> Spades { get; }
        public IList<Card> Hearts { get; }
        public IList<Card> Diamonds { get; }

        public PackOfCards()
        {
            Clubs = new List<Card>();
            Diamonds = new List<Card>();
            Hearts = new List<Card>();
            Spades = new List<Card>();

            for (var i = 0; i < 13; i++)
            {
                var clubsCard = new Card(CardSuit.Clubs, (CardValue)i);
                Clubs.Add(clubsCard);
                
                var diamondsCard = new Card(CardSuit.Diamonds, (CardValue)i);
                Diamonds.Add(diamondsCard);
                
                var heartsCard = new Card(CardSuit.Hearts, (CardValue)i);
                Hearts.Add(heartsCard);
               
                var spadesCard = new Card(CardSuit.Spades, (CardValue)i);
                Spades.Add(spadesCard);
            }
        }
    }
}