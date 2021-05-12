using Scolarite.Domain.entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scolarite.Service
{
    public interface IPlanEService : IService<EspModulePanierClasseSaiso>
    {


        public EspModulePanierClasseSaiso GetPlanByID(string planId);
        public EspModulePanierClasseSaiso GetPlanByClasse(string planId);
        public EspModulePanierClasseSaiso GetPlanByClasse1(string id);
        public EspModulePanierClasseSaiso GetPlanByC(String id, ICollection<EspModulePanierClasseSaiso> listC);

        void Delete(string id);

       void CreatePlan(EspModulePanierClasseSaiso e);
      void UpdatePlan(EspModulePanierClasseSaiso e);
        void CreateList(List<EspModulePanierClasseSaiso> listPlan);

    }
}
