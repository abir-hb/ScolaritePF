using Scolarite.Domain.entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scolarite.Service
{
    public interface IServiceENS : IService<EspEnseignant>
    {
        public EspEnseignant GetEnsByID(string ensId);
        void Delete(string id);

        void CreateEns(EspEnseignant e);
        void UpdateEns(EspEnseignant e);


    }
}
