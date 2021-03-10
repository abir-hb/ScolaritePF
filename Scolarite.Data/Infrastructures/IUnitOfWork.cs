using System;
using System.Collections.Generic;
using System.Text;

namespace Scolarite.Data.Infrastructures
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit(); //gérer les transaction
        //void Dispose();//libérer l'espace mémoire du ctx
        IRepositoryBase<T> getRepository<T>() where T : class; //CRUG générique
    }
}
