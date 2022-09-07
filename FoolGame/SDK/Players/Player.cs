using System.Collections.Generic;
using SDK.Cards;

namespace SDK.Players
{
    public abstract class Player
    {
        private string name;
        protected List<Card> Cards = new List<Card>();

        public Player(string name)
        {
            this.name = name;
        }

        public abstract 
    }
}
