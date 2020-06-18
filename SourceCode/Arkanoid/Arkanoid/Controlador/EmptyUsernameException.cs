using System;

namespace Arkanoid
{
    public class EmptyUsernameException : Exception
    {
        public EmptyUsernameException(string Message) : base(Message) { }
    }
}