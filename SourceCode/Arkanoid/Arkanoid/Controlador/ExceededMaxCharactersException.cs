﻿using System;

namespace Arkanoid
{
    public class ExceededMaxCharactersException : Exception
    {
        public ExceededMaxCharactersException(string Message) : base(Message) { }
    }
}