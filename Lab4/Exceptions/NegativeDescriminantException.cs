using System;

namespace Lab2.Exceptions
{
    public class NegativeDescriminantException : KumachevException
    {
        public NegativeDescriminantException()
        {

        }

        public NegativeDescriminantException(string message) : base(message)
        {

        }
    }
}
