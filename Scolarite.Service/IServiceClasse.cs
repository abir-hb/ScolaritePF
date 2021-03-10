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
    }
}
