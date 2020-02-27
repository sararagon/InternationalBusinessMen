using System;
using System.Collections.Generic;
using System.Text;

namespace InBuMenCrossCutting.Exceptions
{
    public class ValuesControlerException : Exception
    {
        public ValuesControlerException(Exception ex) : base ("", ex)
        {
        }
    }
}
