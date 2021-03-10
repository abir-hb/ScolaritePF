using Scolarite.Domain.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scolarite.Data.Infrastructures
{
    public class DataBaseFactory : Disposable, IDataBaseFactory
    {
        private ModelContext dataContext;
        public ModelContext DataContext { get { return dataContext; } }

        public DataBaseFactory()
        {
            dataContext = new ModelContext();
        }
        protected override void DisposeCore()//libérer l'espace mémoire du contexte
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }
}
