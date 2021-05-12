using Microsoft.EntityFrameworkCore;
using Scolarite.Domain.entities;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;


namespace Scolarite.Data.Infrastructures
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private ModelContext dataContext;
        private readonly DbSet<T> dbset; // générique
     //   IDataBaseFactory databaseFactory;

      
        public RepositoryBase(ModelContext dataContext)
        {
            this.dataContext = dataContext;
            dbset = dataContext.Set<T>();

        }
      /*  protected ModelContext DataContext
        {
            get { return dataContext = databaseFactory.DataContext; }
        }*/
        public virtual void Add(T entity)
        {

            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Added;
            
            
        }

       

        

        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;// etat de la variable
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }
        public virtual void Delete(Expression<Func<T, bool>> condition) // expression : strongly tiped lambda expression
        {
            IEnumerable<T> objects = dbset.Where<T>(condition).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }
        public virtual T GetById(long id)
        {
            return dbset.Find(id);
        }
        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }
        public virtual IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null,
            Expression<Func<T, bool>> orderBy = null)
        {
            IEnumerable<T> Query1 = dbset;
            IQueryable<T> Query = dbset;
            if (where != null)
            {
                Query = Query.Where(where);
            }
            if (orderBy != null)
            {
                Query = Query.OrderBy(orderBy);
            }
            return Query1;
        }
        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }

        //public IEnumerable<T> GetAll()
        //{
        //    return dbset.ToList();
        //}
    }
}