namespace Code
{
    public class Card
    {
        public CardSuit CardSuit { get; }
        public CardValue CardValue { get; }

        public Card(CardSuit cardSuit, CardValue cardValue)
        {
            CardSuit = cardSuit;
            CardValue = cardValue;
        }
    }
}