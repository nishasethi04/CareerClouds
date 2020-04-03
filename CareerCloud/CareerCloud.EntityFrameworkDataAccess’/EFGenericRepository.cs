using CareerCloud.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class EFGenericRepository<T> : IDataRepository<T> where T : class

    {
        private CareerCloudContext _context;

        public EFGenericRepository()
        {
            DbContextOptions<CareerCloudContext> options = new DbContextOptions<CareerCloudContext>();
            _context = new CareerCloudContext(options);
        }

        public void Add(params T[] items)
        {
                foreach (var item in items)
                {
                _context.Entry(item).State=
                    EntityState.Added;
            }
            _context.SaveChanges();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbquery = _context.Set<T>();
            foreach(Expression<Func<T, object>> property  in navigationProperties)
            {
                dbquery = dbquery.Include<T, object>(property);
            }
            return dbquery.ToList();
        }

        public IList<T> GetList(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbquery = _context.Set<T>();
            foreach (var item in navigationProperties)
            {
                dbquery = dbquery.Include<T, object>(item);
            }
            return dbquery.Where(where).ToList<T>() ;

        }

        public T GetSingle(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbquery = _context.Set<T>();
            foreach (var item in navigationProperties)
            {
                dbquery = dbquery.Include<T, object>(item);
            }
            return dbquery.Where(where).FirstOrDefault();

        }

        public void Remove(params T[] items)
        {
            foreach(T item in items)
            {
                _context.Entry(item).State = EntityState.Deleted;
            }
            _context.SaveChanges();
        }

        public void Update(params T[] items)
        {
            foreach (T item in items)
            {
                _context.Entry(item).State = EntityState.Modified;
            }
            _context.SaveChanges();
        }
    }
}
