using Scolarite.Data.Infrastructures;
using Scolarite.Domain.entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scolarite.Service
{
    public class ServiceENS : Service<EspEnseignant>, IServiceENS
    {
        public static DataBaseFactory dbf = new DataBaseFactory();
        public static IUnitOfWork uow = new UnitOfWork(dbf);
        public ServiceENS() : base(uow)
        {

        }
    }
}
