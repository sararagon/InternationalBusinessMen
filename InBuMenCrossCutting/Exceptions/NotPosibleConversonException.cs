using System;
using System.Collections.Generic;
using System.Text;

namespace InBuMenCrossCutting.Exceptions
{
    public class NotPosibleConversonException : Exception
    {
        public NotPosibleConversonException(string v, Exception ex) : base(v, ex)
        {
            
        }
    }
}
