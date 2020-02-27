using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Util;
using InBuMenCrossCutting.Exceptions;
using InBuMenModels.Classes;
using InBuMenModels.Interfaces;

namespace InBuMenWebApi.Services.Repository
{
    public class FakeTransactionRepository : IRepository<Transaction>
    {
        private readonly List<Transaction> _fakeTransaction = new List<Transaction>();

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> GetAll()
        {
            return _fakeTransaction;
        }

        public Transaction GetById(object id)
        {
            Transaction transactionToReturn = null;
            try
            {
                foreach (var transaction in _fakeTransaction)
                {
                    if (transaction.Id == (int)id)
                    {
                        transactionToReturn = transaction;
                    }

                }

                return transactionToReturn;
            }
            catch (Exception ex)
            {
                throw new RateInFakeRepositoryNotExistException(ex.Message);
            }
        }

        public void Insert(Transaction obj)
        {
            _fakeTransaction.Add(obj);
        }

        public void Save()
        {
           
        }

        public void Update(Transaction obj)
        {
            foreach (var transaction in _fakeTransaction)
            {
                if (transaction.Id == obj.Id)
                {
                    transaction.Sku = obj.Sku;
                    transaction.Value = obj.Value;
                }
            }
        }
    }
}