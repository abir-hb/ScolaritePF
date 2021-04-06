using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using Scolarite.Domain.entities;
using Scolarite.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ScolariteWeb.Controllers
{
    public class ModuleController : Controller
    {
        private readonly IServiceModule sm;
        private readonly IServiceUE se;
        private readonly IServiceUp sp;

        ModelContext context = new ModelContext();
        //  List<EspUp> ups = new List<EspUp>();
    
        public ModuleController(IServiceModule serviceModule, IServiceUE serviceUE, IServiceUp serviceUp ,ModelContext ctx)
        {
            sm = serviceModule;
            se = serviceUE;
            sp = serviceUp;
            context = ctx;
        }


        public IActionResult List()

        {
            return View(sm.GetAll());
        }
        //public abstract System.Threading.Tasks.Task ExecuteAsync();

        //get
        public ActionResult Create()

        {

            var ues = se.GetAll();
            var listup = sp.GetAll();

            ViewBag.CodeUe = new SelectList(ues, "CodeUe", "LibUe");
            ViewBag.AnneeDeb = new SelectList(ues, "AnneeDeb", "AnneeDeb");
             
            ViewBag.Up = new SelectList(listup, "Up", "Designantion");
          // Console.Out.WriteLine("erreur" + ViewData["listup"]);
          //  Debug.WriteLine(listup);
          //  Debug.WriteLine(ViewBag.Up);



            // return View();

            EspModule em = new EspModule();
                return View(em);
            }
           // catch
           

            

        
        // POST: Classe/Create
        [HttpPost]
        //   [ValidateInput(false)]
        public ActionResult Create(EspModule c)
        {

            try
            {

                sm.CreateModule(c);
                // context.Entry(c).State = EntityState.Added;
                // context.SaveChanges();
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
         
        }
        public ActionResult Delete(String id)
        {
            EspModule module = sm.GetModuleByID(id);
            //sc.Delete(classe);
            // sc.Commit();
            return View();
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(String id, IFormCollection collection)
        {
            EspModule module = sm.GetModuleByID(id);

            sm.Delete(module);

            sm.Commit();
            return RedirectToAction("List");


        }


        // GET: Classe/Edit/5
        public ActionResult Edit(String id)
        {
            EspModule module = sm.GetModuleByID(id);
            return View(module);
        }

        // POST: Classe/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                EspModule module = sm.GetModuleByID(id);
                /*  Classe classe1 = new Classe()
                  {
                      CodeCl=User.gui
                  };*/
                sm.UpdateM(module);


               // context.Entry(classe).State = EntityState.Modified;
             //   context.SaveChanges();
             //   sc.Commit();

                return RedirectToAction("List");
            }
            catch
            {
                return RedirectToAction("List");
            }
        }

    }
}
