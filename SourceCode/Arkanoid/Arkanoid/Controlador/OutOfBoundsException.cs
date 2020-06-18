using System;

namespace Arkanoid
{
    public class OutOfBoundsException : Exception
    {
        public OutOfBoundsException(string Message) : base(Message) { }
    }
}