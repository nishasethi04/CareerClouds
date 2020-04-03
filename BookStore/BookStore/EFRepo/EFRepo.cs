using BookStore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace BookStore.EFRepo
{
    public class EFRepo<T> : IDataRepo<T> where T : class
    {
        private readonly Bookstorecontext _context;
        public EFRepo()
        {
            _context = new Bookstorecontext();
        }
        public void Create(T[] items)
        {
            foreach (var item in items)
            {
                _context.Entry(item).State =
                    EntityState.Added;
            }
            _context.SaveChanges();
        }

       
        public void Delete(T[] items)
        {
            foreach (T item in items)
            {
                _context.Entry(item).State = EntityState.Deleted;
            }
            _context.SaveChanges();
        }

        public void Get(T[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(T[] items)
        {
            foreach (T item in items)
            {
                _context.Entry(item).State = EntityState.Modified;
            }
            _context.SaveChanges();
        }

       
    }
}
