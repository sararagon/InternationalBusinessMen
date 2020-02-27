using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using InBuMenCrossCutting.Exceptions;
using InBuMenModels.Classes;
using InBuMenModels.Interfaces;

namespace InBuMenWebApi.Services.Repository
{
    public class FakeRateRepository : IRepository<Rate>
    {
        private readonly List<Rate> _fakeRates = new List<Rate>();

        public IEnumerable<Rate> GetAll()
        {
            return _fakeRates;
        }

        public Rate GetById(object id)
        {
            IRate rateToReturn = null;
            try
            {
                foreach (var rate in _fakeRates)
                {
                    if (rate.Id == (int)id)
                    {
                        rateToReturn = rate;
                    }
                    

                }

                return (Rate) rateToReturn;
            }
            catch (Exception ex)
            {
                throw new RateInFakeRepositoryNotExistException(ex.Message);
            }
            
        }

        

        public void Insert(Rate obj)
        {
           _fakeRates.Add(obj);
        }

        public void Update(Rate obj)
        {
            foreach (var rate in _fakeRates)
            {
                if (rate.Id == obj.Id)
                {
                    rate.Value = obj.Value;
                    rate.FromCurrency = obj.FromCurrency;
                    rate.ToCurrency = obj.ToCurrency;
                }
            }

        }

        public void Delete(object id)
        {
            _fakeRates.Remove(id as Rate);
        }

        public void Save()
        {
           
        }
    }
}