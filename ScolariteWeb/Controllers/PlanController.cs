using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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


        public PlanController(IPlanEService servicePlan, IServiceClasse serviceClasse, IServiceENS serviceEns, IServiceModule serviceModule)
        {
            ps = servicePlan;
            se = serviceClasse;
            ens = serviceEns;
            sm = serviceModule;
        }



        // GET: PlanController
        public ActionResult List()
        {
            return View(ps.GetAll());
        }

        // GET: PlanController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlanController/Create
        public ActionResult Create()
        {
            var listClasse = se.GetAll();
            var listEns = ens.GetAll();
            var listModule = sm.GetAll();
            ViewBag.CodeCl = new SelectList(listClasse, "CodeCl", "CodeCl");
            ViewBag.IdEns = new SelectList(listEns, "IdEns", "NomEns");
            ViewBag.CodeModule = new SelectList(listModule, "CodeModule", "Designation");


            EspModulePanierClasseSaiso em = new EspModulePanierClasseSaiso();
            return View(em);
        }

        // POST: PlanController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EspModulePanierClasseSaiso em)
        {
            try
            {
                ps.CreatePlan(em);
                // ViewBag.message("succes");
                return RedirectToAction("List");

            }
            catch
            {

                return View();

            }
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
    
    public ActionResult MainView()
    {
        return View(); //this is main page.We will display  "_AddMorePartialView" partial page on this main page
    }
    public ActionResult AddMorePartialView()
    {
        //this  action page is support cal the partial page.
        //We will call this action by view page.This Action is return partial page
        EspModulePanierClasseSaiso model = new EspModulePanierClasseSaiso();
        return PartialView("_AddMorePartialView", model);
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