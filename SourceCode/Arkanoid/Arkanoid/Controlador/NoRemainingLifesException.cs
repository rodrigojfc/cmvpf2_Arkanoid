using System;

namespace Arkanoid
{
    public class NoRemainingLifesException : Exception
    {
        public NoRemainingLifesException(string Message) : base(Message) { }
    }
}