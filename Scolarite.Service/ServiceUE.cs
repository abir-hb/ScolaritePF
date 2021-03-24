using Scolarite.Data.Infrastructures;
using Scolarite.Domain.entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scolarite.Service
{
    public class ServiceUE : Service<EspUe>, IServiceUE
    {
        public static DataBaseFactory dbf = new DataBaseFactory();
        public static IUnitOfWork uow = new UnitOfWork(dbf);
        List<EspUe> ues = new List<EspUe>();


        public ServiceUE() : base(uow){
        }

        public void CreateUe(EspUe m)
        {
            Add(m);
            Commit();
        }

        public void Delete(string id)
        {
            var ue = ues.SingleOrDefault(c => c.CodeUe == id);
            ues.Remove(ue);

        }

        public IEnumerable<EspUe> GetAllUE()
        {
            return GetAll();
        }

        public EspUe GetUEByID(string UeId)
        {
            return GetAll().FirstOrDefault(c => c.CodeUe == UeId);

        }

        public void UpdateUe(EspUe m)
        {
            UpdateUe(m);
            Commit();
           
        }
    }
}
