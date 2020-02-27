using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InBuMenCrossCutting.Exceptions;

namespace WebApiInBuMen.Services.Calculation.Number
{
    public class StringToInt
    {
        public int RateFormatConverter(string rate)
        {
            try
            {
                var numberSplit = rate.Split('.');
                if (numberSplit.Length > 2)
                {
                    throw new IncorrectRateNumberFormatException("El numero contiene más de un punto.");
                }

                var integerPart = numberSplit[0];
                var decimalPart = numberSplit[1];
                return Int32.Parse(integerPart) * 1000 + Int32.Parse(decimalPart);
            }
            catch (Exception ex)
            {
                throw new IncorrectRateNumberFormatException("No es un número", ex);
            }

           
        }

        
    }
}