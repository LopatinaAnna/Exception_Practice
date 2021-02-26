using System;

namespace Exception_Practice
{
    class DivideException : Exception
    {
        public DivideException() : base() {}

        public DivideException(string message) : base(message) {}
    }
}
