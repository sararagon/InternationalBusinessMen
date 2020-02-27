using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiInBuMen.DAL;

namespace WebApiInBuMen.Services.Repository
{
    public class Repository<T> :  IRepository<T> where T : class
    {
        private readonly InBuMenContext _context = null;
        private readonly DbSet<T> _table = null;

        public Repository()
        {
            this._context = new InBuMenContext();
            _table = _context.Set<T>();
        }
        public Repository(InBuMenContext context)
        {
            this._context = context;
            _table = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }
        public T GetById(object id)
        {
            return _table.Find(id);
        }
        public void Insert(T obj)
        {
            _table.Add(obj);
        }
        public void Update(T obj)
        {
            _table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = _table.Find(id);
            _table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}