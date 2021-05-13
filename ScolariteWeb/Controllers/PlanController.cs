using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Scolarite.Domain.entities;
using Scolarite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ScolariteWeb.Controllers
{
    public class PlanController : Controller

    {
        
        private readonly IPlanEService ps;
        private readonly IServiceClasse se;
        private readonly IServiceENS ens;
        private readonly IServiceModule sm;
        ModelContext context = new ModelContext();
        List<EspModulePanierClasseSaiso> plans = new List<EspModulePanierClasseSaiso>();

        public PlanController(IPlanEService servicePlan, IServiceClasse serviceClasse, IServiceENS serviceEns, IServiceModule serviceModule)
        {
            ps = servicePlan;
            se = serviceClasse;
            ens = serviceEns;
            sm = serviceModule;
        }

        public IActionResult ListClasse()

        {
            return View(se.GetAll());
        }


        // GET: PlanController
        public ActionResult List()
        {
            return View(ps.GetAll());
        }

        // GET: PlanController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: PlanController/Create
        public ActionResult Create()

        {

            var listModule = sm.GetAll();
            var listClasse = se.GetAll();
            var listEns = ens.GetAll();

            ViewBag.CodeModule = new SelectList(listModule, "CodeModule", "CodeModule");
            ViewBag.CodeCl = new SelectList(listClasse, "CodeCl", "CodeCl");
            ViewBag.IdEns = new SelectList(listEns, "IdEns", "IdEns");
            


            EspModulePanierClasseSaiso em = new EspModulePanierClasseSaiso();
            return View(em);
        }

        // POST: PlanController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(EspModulePanierClasseSaiso em)
        {

          

            EspModulePanierClasseSaiso list = new EspModulePanierClasseSaiso
            {
                
                CodeModule=em.CodeModule,
                CodeCl=em.CodeCl,
                AnneeDeb=em.AnneeDeb,
                NumSemestre=em.NumSemestre,
                         

            };


           // list.Add(em);
            ps.CreatePlan(list);
          // context.Entry(em).State = EntityState.Added;
         //   ps.Commit();
           // context.SaveChanges();
            return View();
            //try
            //{
            //    ps.CreatePlan(em);
            //    // ViewBag.message("succes");
            //    return RedirectToAction("List");

            //}
            //catch
            //{

            //    return View();

            //}
        }

        // GET: PlanController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlanController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlanController/Delete/5
        public ActionResult Delete(string id)
        {
            EspModulePanierClasseSaiso plan = ps.GetPlanByID(id);
            //sc.Delete(classe);
            // sc.Commit();
            return View(plan);
        }

        // POST: PlanController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                EspModulePanierClasseSaiso plan = ps.GetPlanByID(id);

                ps.Delete(plan);

                ps.Commit();
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

       [HttpGet]
        public  JsonResult GetPlanByCodeCl(string id)
        {
           
            List<EspModulePanierClasseSaiso> listp = (List<EspModulePanierClasseSaiso>)ps.GetAll();
          ///////////  EspModulePanierClasseSaiso panierk = new EspModulePanierClasseSaiso();

            //foreach(var i in listp)
            //   {
            //       if (i.CodeCl.Equals(id))
            //       {
            //           panierk = ps.GetPlanByClasse(id);

            //       }
            //   }

              EspModulePanierClasseSaiso result = listp.Where(m => m.CodeCl.Equals(id)).FirstOrDefault();
            //   EspModulePanierClasseSaiso panier = ps.GetPlanByC(id, listp);
            //   Console.WriteLine(Json(new { data = ps.GetPlanByC(id, listp) }));
            //  ICollection<EspModulePanierClasseSaiso> list=  ps.GetPlanByC(id, listp);
            //   return Json(new { data = ps.GetPlanByC(id,listp)});
            //  return Json(plan, System.Web.Mvc.JsonRequestBehavior.AllowGet);
            //  EspModulePanierClasseSaiso result = listp.Where(m => m.CodeCl == id).FirstOrDefault();

       ///////////////// return Json(result);
            //return Json(listp, System.Web.Mvc.JsonRequestBehavior.AllowGet);
            //   var plan = ps.GetPlanByC(id, (ICollection<EspModulePanierClasseSaiso>)ps.GetAll());
            //var plan = se.GetAll().FirstOrDefault(p => p.CodeCl == id);
            //return Json(new { data = plan });
            //    await context.EspModulePanierClasseSaiso.FirstOrDefaultAsync(p=>p.CodeCl==id) ;
            //Console.WriteLine(plan);
            // return Json(plan);

            //  return Json(new { data = context.EspModulePanierClasseSaiso.Where(m => m.CodeCl.Equals(id)).FirstOrDefault() });
         return Json(new { data = context.EspModulePanierClasseSaiso.FindAsync(id,1,"SR-12","2020")});
        }

        [HttpGet]
        public async Task<IActionResult> GetDataApiJson(string id)
        {
            return Json(new { data = await context.EspModulePanierClasseSaiso.FindAsync(id) });


        }
        //public ActionResult Details(String CodeCl)


        //{
        //    EspModulePanierClasseSaiso panier = ps.GetPlanByC(CodeCl);

        //    return View(panier);
        //}
        public ActionResult MainView()
    {
        return View(); //this is main page.We will display  "_AddMorePartialView" partial page on this main page
    }
    public ActionResult CreatePlan()
    {
        //this  action page is support cal the partial page.
        //We will call this action by view page.This Action is return partial page
        EspModulePanierClasseSaiso model = new EspModulePanierClasseSaiso();
        return PartialView("CreatePlan", model);
        //^this is actual partical page we have 
        //create on this page in Home Controller as given below image
    }


        //public ActionResult PostAddMore()
        //{
            
        //    EspModulePanierClasseSaiso list = new EspModulePanierClasseSaiso();
        //    return View(list);
            
        //  //  EspModulePanierClasseSaiso em = new EspModulePanierClasseSaiso();
        //   // return View(em);
        //    //Here,Post addmore value from view page and get multiple values from view page
        //   // return View();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PostAddMore(EspModulePanierClasseSaiso model) {




            //  List<EspModulePanierClasseSaiso> list = new List<EspModulePanierClasseSaiso>();
            //  EspModulePanierClasseSaiso plan = ps.GetPlanByID(id);


            //  //foreach (var i in list)
            //  //    {
            //  //       // context.EspModulePanierClasseSaiso.Add(i);
            //  //       // ps.CreatePlan(em);

            //  //    list.Add(i);
            //  //    list.Add(em);

            //  //    }

            //  list.Add(plan);
            //  ps.CreateList(list);
            //      context.SaveChanges();
            //      ViewBag.Message = "Data successfully";



            ////  return View(list);
            //  return RedirectToAction("List");

            //Here,Post addmore value from view page and get multiple values from view page
            return RedirectToAction("Delete");
        }
}

}