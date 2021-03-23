﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scolarite.Domain.entities;
using Scolarite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScolariteWeb.Controllers
{
    public class ModuleController : Controller
    {
        private readonly IServiceModule sm;


        public ModuleController(IServiceModule serviceModule)
        {
            sm = serviceModule;
        }


        public IActionResult List()

        {
            return View(sm.GetAll());
        }

        public ActionResult Create()
        {
            EspModule em = new EspModule();
            return View(em);

        }
        // POST: Classe/Create
        [HttpPost]
        //   [ValidateInput(false)]
        public ActionResult Create(EspModule c)
        {


          
                sm.CreateModule(c);
                //  context.Entry(c).State = EntityState.Added;
                // context.SaveChanges();
                return RedirectToAction("List");
           
         
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
