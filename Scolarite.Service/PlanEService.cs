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
    public class PlanEService : Service<EspModulePanierClasseSaiso>, IPlanEService
    {
        public static DataBaseFactory dbf = new DataBaseFactory();
        public static IUnitOfWork uow = new UnitOfWork(dbf);
        private ModelContext context;
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
        //public Task<EspModulePanierClasseSaiso> GetPlan(String id,ICollection<EspModulePanierClasseSaiso> listC)
        //{
        //    List<EspModulePanierClasseSaiso> ListP = (List<EspModulePanierClasseSaiso>)GetAll();

        //    return context.EspModulePanierClasseSaiso.Where<(n => n.CodeCl.Equals(id)>);
        //}


        public EspModulePanierClasseSaiso GetPlanByC(String id , List<EspModulePanierClasseSaiso> listC)
        {

           
            //EspModulePanierClasseSaiso plan = GetAll().Where(prov => prov.CodeCl == id).FirstOrDefault();
            //Console.WriteLine(id);
            //Console.WriteLine(GetAll());
            //return (plan);
            //linq
            //return (from prov in listC
            //        where prov.CodeCl == id
            //        select prov).FirstOrDefault();
            //lambda
              return listC.Where(prov => prov.CodeCl.Equals(id)).FirstOrDefault();
        }

        public EspModulePanierClasseSaiso GetPlanByID(string planId)
        {
            return GetAll().FirstOrDefault(c => c.CodeModule == planId);
        }
        public EspModulePanierClasseSaiso GetPlanByClasse1(string id)
        {
            var plan = plans.FirstOrDefault(p => p.CodeCl.Equals(id));
            return (plan);
        }
        public EspModulePanierClasseSaiso GetPlanByClasse(string planId)
        {
            return GetAll().FirstOrDefault(c => c.CodeCl.Equals(planId));
        }

        public IEnumerable<EspModulePanierClasseSaiso> GetListPlanByC(string id,List<EspModulePanierClasseSaiso> listc) { 
       
            
            return listc.Where(m => m.CodeCl.Equals(id));

        }

        public void UpdatePlan(EspModulePanierClasseSaiso e)
        {
            throw new NotImplementedException();
        }
    }
}
