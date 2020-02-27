using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InBuMenModels.Classes;

namespace InBuMenWebApi.Services.Repository
{
    public class FakeRateRepository : IRepository<Rate>
    {
        private List<Rate> _fakeRates = new List<Rate>();

        public IEnumerable<Rate> GetAll()
        {
            return _fakeRates;
        }

        public Rate GetById(object id)
        {
            foreach (var rate in _fakeRates)
            {
                if (rate.Id == (int) id)
                {
                    return rate;
                } 
            }
        }

        public void Insert(Rate obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Rate obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}