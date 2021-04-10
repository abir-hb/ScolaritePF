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


        public PlanController(IPlanEService servicePlan,IServiceClasse serviceClasse,IServiceENS serviceEns ,IServiceModule serviceModule)
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
            return View();
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
    }
}
