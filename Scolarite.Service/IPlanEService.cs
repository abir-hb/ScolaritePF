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
       void Delete(string id);

       void CreatePlan(EspModulePanierClasseSaiso e);
      void UpdatePlan(EspModulePanierClasseSaiso e);

    }
}
