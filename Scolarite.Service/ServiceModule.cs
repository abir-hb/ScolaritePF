using Scolarite.Data.Infrastructures;
using Scolarite.Domain.entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scolarite.Service
{
    public class ServiceModule : Service<EspModule>, IServiceModule
    {

        public static DataBaseFactory dbf = new DataBaseFactory();
        public static IUnitOfWork uow = new UnitOfWork(dbf);
        public ServiceModule() : base(uow) { }
    }
}
