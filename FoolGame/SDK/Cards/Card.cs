namespace SDK.Cards
{
    public class Card
    {
        public CardSuit Suit { get; }
        public CardValue Value { get; }

        public Card(CardSuit suit, CardValue value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public bool CanFight(Card card, CardSuit trump)
        {
            if (this.Suit == card.Suit)
            {
                return (int)this.Value > (int)card.Value;
            }
            else if (card.Suit == trump)
            {
                return false;
            }
            else if (this.Suit == trump)
            {
                return true;
            }

            return false;
        }

        public int Compare(Card card, CardSuit trump)
        {
            if ((this.Suit != trump && card.Suit != trump) || (this.Suit == trump && card.Suit == trump))
            {
                if (this.Value < card.Value)
                    return -1;
                if (this.Value > card.Value)
                    return 1;
                if (this.Value == card.Value)
                    return 0;
            }
            if (this.Suit == trump && card.Suit != trump)
            {
                return 1;
            }

            return -1;
        }
    }
}
