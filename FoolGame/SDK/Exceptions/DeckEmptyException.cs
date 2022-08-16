using System;

namespace SDK.Exceptions
{
    internal class DeckEmptyException : Exception
    {
        public DeckEmptyException(string message) : base(message) { }
    }
}
