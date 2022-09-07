using System.Collections.Generic;

namespace SDK
{
    public class Player
    {
        private string name;
        private List<Card> cards = new List<Card>();

        public Player(string name)
        {
            this.name = name;
        }
    }
}
