using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scolarite.Domain.entities;
using Scolarite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScolariteWeb.Controllers
{
    public class EnsController : Controller
    {
        

        private readonly IServiceENS se;

        ModelContext context = new ModelContext();

        public EnsController(IServiceENS serviceEns)
        {
            se = serviceEns;

        }
        // GET: EnsController
        public ActionResult List()
        {
            
            return View(se.GetAll());
        }

        // GET: EnsController/Details/5
        public ActionResult Details(String id)


        {
            EspEnseignant enseignant = se.GetEnsByID(id);

            return View(enseignant);
        }

        // GET: EnsController/Create
        public ActionResult Create()
        {
            EspEnseignant ens = new EspEnseignant();
                return View (ens);
        }

        // POST: EnsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EspEnseignant ens)
        {
            
                se.CreateEns(ens);
            return RedirectToAction("List");


        }

        // GET: EnsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EnsController/Edit/5
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

        // GET: EnsController/Delete/5
        public ActionResult Delete(string id)
        {
            EspEnseignant ens = se.GetEnsByID(id);
            return View();
        }

        // POST: EnsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            EspEnseignant ens = se.GetEnsByID(id);
            se.Delete(ens);
            se.Commit();
            return RedirectToAction("List");

        }
    }
}
