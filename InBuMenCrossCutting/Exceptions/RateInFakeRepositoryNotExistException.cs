using System;
using System.Collections.Generic;
using System.Text;

namespace InBuMenCrossCutting.Exceptions
{
    public class RateInFakeRepositoryNotExistException : Exception
    {
        

        public RateInFakeRepositoryNotExistException(string exception) : base(exception)
        {
        }
    }
}
