using System.Collections.Generic;
using SDK.Cards;
using SDK.Commands;
using SDK.Results;

namespace SDK.Players
{
    public abstract class Player
    {
        private string name;
        protected List<Card> Cards = new List<Card>();
        protected CardSuit Trump;
        public Player(string name)
        {
            this.name = name;
        }

        public abstract Result Handle(Command command);
    }
}
