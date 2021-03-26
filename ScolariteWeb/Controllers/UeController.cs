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
    public class UeController : Controller


    {


        private readonly IServiceUE ue;

        ModelContext context = new ModelContext();


        public UeController(IServiceUE serviceUE)
        {
            ue = serviceUE;
        }
        // GET: UesController
        public ActionResult List()
        {
          
            return View(ue.GetAll());
        }

        // GET: UesController/Details/5
        public ActionResult Details(String id)


        {
            EspUe uens = ue.GetUEByID(id);

            return View(uens);
          
                }



        // GET: UesController/Create
        public ActionResult Create()
        {
            EspUe uens = new EspUe();
            return View(uens);
        }

        // POST: UesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EspUe ens)
        {

            ue.CreateUe(ens);
            return RedirectToAction("List");


        }



       // GET: UesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UesController/Edit/5
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

        // GET: UesController/Delete/5
        public ActionResult Delete(string id)
        {
            EspUe ens = ue.GetUEByID(id);

            return View(ens);
        }

        // POST: UesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            //EspUe en = context.EspUe.Find(id,annee);
           EspUe ens = ue.GetUEByID(id);
            ue.Delete(ens);
            ue.Commit();
            return RedirectToAction("List");

        }

    }
}
