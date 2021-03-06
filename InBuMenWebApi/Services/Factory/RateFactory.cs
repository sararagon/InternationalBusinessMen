﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Scope;
using InBuMenCrossCutting.Exceptions;
using InBuMenModels.Classes;
using InBuMenModels.Interfaces;
using InBuMenWebApi.Services.Calculation.Numeric;
using InBuMenWebApi.Services.Specification;

namespace InBuMenWebApi.Services.Factory
{
    public class RateFactory : IRateFactory
    {
        private readonly ICurrencySpecification _specification;

        public RateFactory()
        {
        }

        public RateFactory(ICurrencySpecification specification)
        {
            _specification = specification;
        }

        public IRate SaveRate(IJsonRate r)
        {
            if (!(_specification.IsSatisfiedBy(r.From) && _specification.IsSatisfiedBy(r.To)))
            {
                throw new IncorrectCurrentNameException();
            }
            var rate = new Rate()
            {
                FromCurrency = r.From,
                ToCurrency = r.To,
                Value = RateStringToInt.RateFormatConverter(r.Rate)
            };
            return rate;
        }
    }

   
}