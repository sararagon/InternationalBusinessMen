using System;
using InBuMenCrossCutting.Exceptions;

namespace InBuMenWebApi.Services.Calculation.Numeric
{
    public static class StringToInt
    {
        public static int RateFormatConverter(string rate)
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

        public static int CurrentFormatConverter(string rate)
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
                return Int32.Parse(integerPart) * 100 + Int32.Parse(decimalPart);
            }
            catch (Exception ex)
            {
                throw new IncorrectRateNumberFormatException("No es un número", ex);
            }


        }


    }
}