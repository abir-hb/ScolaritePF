using Scolarite.Domain.entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scolarite.Service
{
    public interface IServiceClasse:IService<Classe>
    {
        IEnumerable<Classe> GetClasseByFiliere(string filiere);
        //   void Delete(long id);
        public Classe GetClasseByID(string classeId);
        void Delete(string id);

        void CreateCl(Classe cl);
        void UpdateCl(Classe cl);
        //void UpdateC(Guid id, Classe classe);

        // void Update(string id);
    }
}
