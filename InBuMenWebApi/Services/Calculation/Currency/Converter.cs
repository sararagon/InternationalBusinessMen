using InBuMenCrossCutting.Exceptions;
using InBuMenModels.Classes;
using InBuMenModels.Interfaces;
using InBuMenWebApi.Services.Repository;
using System;

namespace InBuMenWebApi.Services.Calculation.Currency
{
    public class Converter
    {
        private IRepository<Rate> _repository;

        /// <summary>
        /// Método mediante el cual, al implementar una función determinada, se introduce una moneda y resulta el cambio.
        /// </summary>
        /// <param name="currency"></param>
        /// <param name="currenName"></param>
        /// <returns></returns>
        public ICurrency ChangeCurrency(ICurrency currency, string currenName)
        {
            foreach (var rate in _repository.GetAll())
            {
                if (rate.FromCurrency == currency.CurrencyName && rate.ToCurrency == currenName)
                {
                    return new InBuMenModels.Classes.Currency()
                    {
                        Amount = rate.Value * currency.Amount,
                        CurrencyName = currenName
                    };
                }
                
            }

            var ratesInRepository = 0;
            foreach (var r in _repository.GetAll())
            {
                ratesInRepository++;
            }
            var intermCurrency = new InBuMenModels.Classes.Currency();
            var firstFind = false;
            var i = 0;
            try
            {
                while (!firstFind && i < ratesInRepository)
                {
                    i++;
                    if (_repository.GetById(i).FromCurrency == currency.CurrencyName)
                    {
                        firstFind = true;
                        intermCurrency.Amount = _repository.GetById(i).Value * currency.Amount;
                        intermCurrency.CurrencyName = _repository.GetById(i).ToCurrency;
                    }

                    if (_repository.GetById(i).ToCurrency == currency.CurrencyName)
                    {
                        firstFind = true;
                        intermCurrency.Amount = _repository.GetById(i).Value / currency.Amount;
                        intermCurrency.CurrencyName = _repository.GetById(i).ToCurrency;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new NotPosibleConversonException("No ha podido realizar la conversión porque no hay nincún camino posible", ex);
            }

            return ChangeCurrency(intermCurrency, currenName);

        }

       
    }
}