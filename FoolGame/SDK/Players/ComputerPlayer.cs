using SDK.Cards;
using SDK.Commands;
using SDK.Results;
using SDK.Exceptions;

namespace SDK.Players
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(string name) : base(name) { }

        public override Result Handle(Command command)
        {
            switch (command)
            {
                case TakeCardCommand takeCardCommand:
                    return Handle(takeCardCommand);
                case GetCardCommand getCardCommand:
                    return Handle(getCardCommand);
                case SetTrumpCommand setTrumpCommand:
                    return Handle(setTrumpCommand);
                default:
                    throw new InvalidCommandException("Invalid command!");
            }
        }

        private TakeCardResult Handle(TakeCardCommand command)
        {
            Cards.AddRange(command.Cards);
            return new TakeCardResult();
        }

        private GetCardResult Handle(GetCardCommand command)
        {
            if (Cards.Count == 0)
                return new GetCardResult(null);

            Card minCard = Cards[0];

            for (int i = 1; i < Cards.Count; i++)
            {
                if (minCard.Compare(Cards[i], Trump) == 1)
                    minCard = Cards[i];
            }

            Cards.Remove(minCard);

            return new GetCardResult(minCard);
        }

        private SetTrumpResult Handle(SetTrumpCommand command)
        {
            Trump = command.Trump;
            return new SetTrumpResult();
        }
    }
}
