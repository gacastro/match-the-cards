using System;

namespace Code
{
    public class CardMatcher
    {
        private readonly Func<Card, Card, bool> _matchFunction;

        public CardMatcher(MatchCondition matchCondition)
        {
            switch (matchCondition)
            {
                case MatchCondition.Suit:
                    _matchFunction = (first, second) => first.CardSuit == second.CardSuit;
                    break;
                case MatchCondition.Value:
                    _matchFunction = (first, second) => first.CardValue == second.CardValue;
                    break;
                case MatchCondition.SuitAndValue :
                    _matchFunction = (first, second) =>
                        first.CardSuit == second.CardSuit &&
                        first.CardValue == second.CardValue;
                    break;
            }
        }

        public bool VerifyMatch(Card firstCard, Card secondCard) => _matchFunction(firstCard, secondCard);
    }
}