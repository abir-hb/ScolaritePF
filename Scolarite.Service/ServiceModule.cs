using Scolarite.Data.Infrastructures;
using Scolarite.Domain.entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scolarite.Service
{
    public class ServiceModule : Service<EspModule>, IServiceModule
    {

        public static DataBaseFactory dbf = new DataBaseFactory();
        public static IUnitOfWork uow = new UnitOfWork(dbf);
        List<EspModule> modules = new List<EspModule>();
        public ServiceModule() : base(uow) { }

        public void CreateModule(EspModule m)
        {
            Add(m);
            Commit();
        }

        public void Delete(string id)
        {
            var module = modules.SingleOrDefault(b => b.CodeModule == id);
            modules.Remove(module);
        }

        public EspModule GetModuleByID(string moduleId)
        {
            return GetAll().FirstOrDefault(c => c.CodeModule == moduleId);
        }
        public void UpdateM(EspModule m)
        {
            Update(m);
            Commit();
        }


    }
}