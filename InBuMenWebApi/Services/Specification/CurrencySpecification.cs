using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InBuMenModels.Interfaces;

namespace InBuMenWebApi.Services.Specification
{
    public class CurrencySpecification : ICurrencySpecification
    {
        public bool IsSatisfiedBy(string c)
        {
            return !string.IsNullOrEmpty(c) && c.Length == 3;
        }
    }
}