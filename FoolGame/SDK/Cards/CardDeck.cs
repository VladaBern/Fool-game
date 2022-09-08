using SDK.Exceptions;
using System;
using System.Collections.Generic;

namespace SDK.Cards
{
    public class CardDeck
    {
        private Stack<Card> cardDeck;
        private static Random rng = new Random();
        private CardSuit trump;

        public CardDeck(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException("Count should be more than zero");
            }

            var deck = Create();
            for (int i = 0; i < count; i++)
            {
                Shuffle(deck);
            }
            trump = deck[0].Suit;
            cardDeck = new Stack<Card>(deck);
        }

        private void Shuffle(List<Card> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public List<Card> GetCard(int count)
        {
            List<Card> result = new List<Card>();

            for (int i = 0; i < count; i++)
            {
                if (cardDeck.Count != 0)
                {                    
                    result.Add(cardDeck.Pop());
                }
                else
                {
                    throw new DeckEmptyException("Deck is empty");
                }
            }

            return result;
        }
                
        public CardSuit TrumpChoice
        {
            get
            {
                return trump;
            }
        }

        private List<Card> Create()
        {
            var list = new List<Card>();

            foreach (var suit in (CardSuit[])Enum.GetValues(typeof(CardSuit)))
            {
                foreach (var value in (CardValue[])Enum.GetValues(typeof(CardValue)))
                {
                    list.Add(new Card(suit, value));
                }
            }

            return list;
        }
    }
}
