using System;

namespace Lab2.Exceptions
{
    public class KumachevException : Exception
    {
        public KumachevException()
        {

        }

        public KumachevException(string message) : base(message)
        {

        }
    }
}
