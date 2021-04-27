using Scolarite.Domain.entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scolarite.Service
{
     public interface IServiceModule : IService<EspModule>
    {
        public EspModule GetModuleByID(string moduleId);
        void Delete(string id);

        void CreateModule(EspModule m);
        void UpdateM(EspModule m);
       // public void CreateM(List<EspModule> list);
        public List<EspModule> CreateList(EspModule model);
        public List<EspModule> CreateM(EspModule model);
    }
}
