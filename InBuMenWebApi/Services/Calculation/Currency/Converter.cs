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
        /// <param name="CurrenName"></param>
        /// <returns></returns>
        public ICurrency ChangeCurrency(ICurrency currency, string CurrenName)
        {
            foreach (var rate in _repository.GetAll())
            {
                if (rate.FromCurrency == currency.CurrencyName && rate.ToCurrency == CurrenName)
                {
                    return new InBuMenModels.Classes.Currency()
                    {
                        Amount = rate.Value * currency.Amount,
                        CurrencyName = CurrenName
                    };
                }
                
            }

            var RatesInRepository = 0;
            foreach (var r in _repository.GetAll())
            {
                RatesInRepository++;
            }
            var IntermCurrency = new InBuMenModels.Classes.Currency();
            var FirstFind = false;
            var i = 0;
            try
            {
                while (!FirstFind && i < RatesInRepository)
                {
                    i++;
                    if (_repository.GetById(i).FromCurrency == currency.CurrencyName)
                    {
                        FirstFind = true;
                        IntermCurrency.Amount = _repository.GetById(i).Value * currency.Amount;
                        IntermCurrency.CurrencyName = _repository.GetById(i).ToCurrency;
                    }

                    if (_repository.GetById(i).ToCurrency == currency.CurrencyName)
                    {
                        FirstFind = true;
                        IntermCurrency.Amount = _repository.GetById(i).Value / currency.Amount;
                        IntermCurrency.CurrencyName = _repository.GetById(i).ToCurrency;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new NotPosibleConversonException("No ha podido realizar la conversión porque no hay nincún camino posible", ex);
            }

            return ChangeCurrency(IntermCurrency, CurrenName);

        }

       
    }
}