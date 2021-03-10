using Scolarite.Data.Infrastructures;
using Scolarite.Domain.entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolarite.Service
{
   public class ServiceClasse : Service<Classe>, IServiceClasse
    {
        public static DataBaseFactory dbf = new DataBaseFactory();
        public static IUnitOfWork uow = new UnitOfWork(dbf);
        public ServiceClasse() : base(uow)
        {

        }

        public IEnumerable<Classe> GetClasseByFiliere(string filiere)
        {
            return GetMany(f => f.Filiere.Contains(filiere));
        }

       
        public Classe GetClasseByID(string classeId)
        {
            return GetAll().FirstOrDefault(c => c.CodeCl == classeId);
        }


       /* public Task<Classe> GetClasseByIdAsync(int id)
        {
            return GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }*/

      
    }
}
