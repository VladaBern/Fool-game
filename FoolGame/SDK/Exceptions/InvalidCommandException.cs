using System;

namespace SDK.Exceptions
{
    public class InvalidCommandException : Exception
    {
        public InvalidCommandException(string message) : base(message) { }
    }
}
