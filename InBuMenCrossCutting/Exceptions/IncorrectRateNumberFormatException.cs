using System;

namespace InBuMenCrossCutting.Exceptions
{
    public class IncorrectRateNumberFormatException : Exception
    {
        public IncorrectRateNumberFormatException(string message) : base(message)
        {

        }

        public IncorrectRateNumberFormatException(string message, Exception ex) : base(message, ex)
        {

        }

    }
}
