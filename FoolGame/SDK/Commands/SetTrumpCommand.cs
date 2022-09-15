using SDK.Cards;

namespace SDK.Commands
{
    public class SetTrumpCommand : Command
    {
        public CardSuit Trump { get; }

        public SetTrumpCommand(CardSuit trump)
        {
            Trump = trump;
        }
    }
}
