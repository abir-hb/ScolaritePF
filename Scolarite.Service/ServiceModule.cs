using Microsoft.EntityFrameworkCore;
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
        ModelContext context = new ModelContext();
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

        public List<EspModule> CreateList(EspModule model)
        {


            modules.Add(model);
            return modules;

        }

        public List<EspModule> CreateM(EspModule model)
        {

            List<EspModule> list = new List<EspModule>();
            modules.Add(model);
            foreach(var i in modules)
            {
                list.Add(i);
                context.Entry(i).State = EntityState.Added;
                context.SaveChanges();

            }
            return modules;
        }

    }
}