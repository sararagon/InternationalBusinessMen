using System.Collections.Generic;
using InBuMenModels.Interfaces;

namespace InBuMenWebApi.Services.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}