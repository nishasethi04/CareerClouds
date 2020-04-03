using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public interface IDataRepo<T>
    {
        void Create(T[] items);
        void Get(T[] items);
        void Delete(T[] items);
        void Update( T[] items);
       
    }
}
