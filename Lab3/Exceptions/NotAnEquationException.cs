using System;

namespace Lab2.Exceptions
{
    public class NotAnEquationException : Exception
    {
        public NotAnEquationException()
        {

        }

        public NotAnEquationException(string message) : base(message)
        {

        }
    }
}
