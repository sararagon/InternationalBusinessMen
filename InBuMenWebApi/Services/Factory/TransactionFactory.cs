using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InBuMenCrossCutting.Exceptions;
using InBuMenModels.Classes;
using InBuMenWebApi.Services.Calculation.Numeric;
using InBuMenWebApi.Services.Specification;

namespace InBuMenWebApi.Services.Factory
{
    public class TransactionFactory : ITransactionFactory
    {
        private ICurrencySpecification _specification;

        public ITransaction SaveTransaction(IJsonTransaction t)
        {
            if (!(_specification.IsSatisfiedBy(t.Currency)))
            {
                throw new IncorrectCurrentNameException();
            }

            var c = new Currency()
            {
                Amount = CurrentStringToInt.CurrentFormatConverter(t.Amount),
                CurrencyName = t.Currency
            };

            return new Transaction()
            {
                Sku = t.Sku,
                Value = c
            };
        }
    }
}