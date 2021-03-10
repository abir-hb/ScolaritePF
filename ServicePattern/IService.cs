using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ServicePattern
{
    public interface IService <T>
    {
        void Add(T entity);
        void Delete(Expression<Func<T, bool>> condition);
        void Delete(T entity);

        T Get(Expression<Func<T, bool>> condition);
        T GetById(long id);
        T GetById(string id);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null,
          Expression<Func<T, bool>> orderBy = null);
        void Update(T entity);
        void Commit();
        IEnumerable<T> GetAll();



    }
}
