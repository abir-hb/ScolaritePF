using Scolarite.Domain.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scolarite.Data.Infrastructures
{
    public class UnitOfWork : IUnitOfWork
    {
        private ModelContext dataContext;
        IDataBaseFactory dbfactory ;

        public UnitOfWork(IDataBaseFactory dbfactory)
        {
            this.dbfactory = dbfactory;
            dataContext = dbfactory.DataContext;
        }
        public void Commit()
        {
            dataContext.SaveChanges();
            //factory.DataContext.SaveChanges();
        }

        public void Dispose()
        {
            // factory.Dispose();
            dataContext.Dispose();
        }

        public IRepositoryBase<T> getRepository<T>() where T : class
        {
            return new RepositoryBase<T>(dbfactory.DataContext);
        }

       
    }
}
