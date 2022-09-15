using SDK.Cards;
using System.Collections.Generic;

namespace SDK.Commands
{
    public class TakeCardCommand : Command
    {
        public List<Card> Cards { get; }

        public TakeCardCommand(List<Card> cards)
        {
            Cards = cards;
        }
    }
}
