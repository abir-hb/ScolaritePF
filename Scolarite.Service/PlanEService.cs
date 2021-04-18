using Scolarite.Data.Infrastructures;
using Scolarite.Domain.entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scolarite.Service
{
    public class PlanEService : Service<EspModulePanierClasseSaiso>, IPlanEService
    {
        public static DataBaseFactory dbf = new DataBaseFactory();
        public static IUnitOfWork uow = new UnitOfWork(dbf);
        List<EspModulePanierClasseSaiso> plans = new List<EspModulePanierClasseSaiso>();
        public PlanEService() : base(uow)
        {

        }

        public void CreateList(List<EspModulePanierClasseSaiso> listPlan)
        {
           
          
            foreach (var i in listPlan)
            {
                listPlan.Add(i);
                Commit();

            }
           
        }

        public void CreatePlan(EspModulePanierClasseSaiso e)
        {

            Add(e);
            Commit();
        }

      
        public void Delete(string id)
        {
            var plan = plans.SingleOrDefault(p => p.CodeCl == id);
            plans.Remove(plan);
          
        }

        public EspModulePanierClasseSaiso GetPlanByID(string planId)
        {
            return GetAll().FirstOrDefault(c => c.CodeModule == planId);
        }

        public void UpdatePlan(EspModulePanierClasseSaiso e)
        {
            throw new NotImplementedException();
        }
    }
}
