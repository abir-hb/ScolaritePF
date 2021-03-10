using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Scolarite.Data.Infrastructures
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T entity);
        void Delete(Expression<Func<T, bool>> condition);
        void Delete(T entity);
        T Get(Expression<Func<T, bool>> condition);
        T GetById(long id);
        T GetById(string id);

        IEnumerable<T> GetAll();

        // GetMany() ou getMany(param)

        IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null,
            Expression<Func<T, bool>> orderBy = null);
        void Update(T entity);
    }
}