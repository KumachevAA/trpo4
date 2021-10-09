using System;

namespace Lab2.Exceptions
{
    public class NegativeDescriminantException : Exception
    {
        public NegativeDescriminantException()
        {

        }

        public NegativeDescriminantException(string message) : base(message)
        {

        }
    }
}
