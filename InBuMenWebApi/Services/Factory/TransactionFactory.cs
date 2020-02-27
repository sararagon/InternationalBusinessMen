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
        private readonly ICurrencySpecification _specification;

        public TransactionFactory()
        {
        }

        public TransactionFactory(ICurrencySpecification specification)
        {
            _specification = specification;
        }

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