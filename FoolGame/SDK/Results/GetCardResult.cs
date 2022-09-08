using SDK.Cards;

namespace SDK.Results
{
    public class GetCardResult : Result
    {
        public Card Card { get; }

        public GetCardResult(Card card)
        {
            Card = card;
        }
    }
}
