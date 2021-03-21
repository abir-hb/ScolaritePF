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


        List<Classe> classes = new List<Classe>();

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




        public void Delete(string id)
        {
            var classe = classes.SingleOrDefault(b => b.CodeCl == id);
            classes.Remove(classe);
        }

        public void CreateCl(Classe cl)
        {
            Add(cl);
            Commit();
        }
        /* public void Update(string id)
         {
             var classe = classes.SingleOrDefault(b => b.CodeCl == id);
             Update(classe);
             Commit();


         }*/

        public void UpdateCl(Classe cl)
        {
            Update(cl);
            Commit();
        }

        /* public void UpdateC(Guid id,Classe classe)
           {

               Update(classe);
               Commit();
           }*/
    }
}