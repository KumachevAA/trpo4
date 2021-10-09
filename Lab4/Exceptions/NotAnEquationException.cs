using System;

namespace Lab2.Exceptions
{
    public class NotAnEquationException : KumachevException
    {
        public NotAnEquationException()
        {

        }

        public NotAnEquationException(string message) : base(message)
        {

        }
    }
}
