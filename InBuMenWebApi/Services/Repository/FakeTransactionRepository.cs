using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Util;

namespace InBuMenWebApi.Services.Repository
{
    public class FakeTransactionRepository : IRepository<Transactions>
    {
        public IEnumerable<Transactions> GetAll()
        {
            throw new NotImplementedException();
        }

        public Transactions GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Transactions obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Transactions obj)
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