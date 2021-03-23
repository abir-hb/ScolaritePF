using Scolarite.Data.Infrastructures;
using Scolarite.Domain.entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scolarite.Service
{
    public class ServiceENS : Service<EspEnseignant>, IServiceENS
    {
        public static DataBaseFactory dbf = new DataBaseFactory();
        public static IUnitOfWork uow = new UnitOfWork(dbf);
        List<EspEnseignant> enseignants = new List<EspEnseignant>();

        public ServiceENS() : base(uow)
        {

        }

        public void CreateEns(EspEnseignant e)
        {
            Add(e);
            Commit();
        }

        public void Delete(string id)
        {
            var enseignant = enseignants.SingleOrDefault(b => b.IdEns == id);
            enseignants.Remove(enseignant);

        }

        public EspEnseignant GetEnsByID(string ensId)
        {
            return GetAll().FirstOrDefault(m => m.IdEns == ensId);
        }
    }
}
