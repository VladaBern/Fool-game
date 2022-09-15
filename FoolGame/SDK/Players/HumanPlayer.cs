using SDK.Commands;
using SDK.Results;

namespace SDK.Players
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name) { }

        public override Result Handle(Command command)
        {
            throw new System.NotImplementedException();
        }
    }
}
