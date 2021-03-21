using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scolarite.Domain.entities;
using Scolarite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scolarite.Web.Controllers
{
    public class ClasseController : Controller
    {
        private readonly IServiceClasse sc;

        ModelContext context = new ModelContext();
        public ClasseController(IServiceClasse serviceClasse)
        {
            sc = serviceClasse;
        }


        public IActionResult List()

        {
            return View(sc.GetAll());
        }


        // GET: Questions/Create

        public ActionResult Create()
        {
            Classe pm = new Classe();
            return View(pm);

        }
        // POST: Classe/Create
        [HttpPost]
        //   [ValidateInput(false)]
        public ActionResult Create(Classe c)
        {


            try
            {
                sc.CreateCl(c);
                //  context.Entry(c).State = EntityState.Added;
                // context.SaveChanges();
                return RedirectToAction("List");
            }
            catch (Exception e)
            {

                string msg;
                msg = "error";

            }
            return RedirectToAction("List");
        }

        // GET: Classe/Edit/5
        public ActionResult Edit(String id)
        {
            Classe classe = sc.GetClasseByID(id);
            return View(classe);
        }

        // POST: Classe/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                Classe classe = sc.GetClasseByID(id);
                /*  Classe classe1 = new Classe()
                  {
                      CodeCl=User.gui
                  };*/
                sc.UpdateCl(classe);

                context.Entry(classe).State = EntityState.Modified;
                context.SaveChanges();
                sc.Commit();

                return RedirectToAction("List");
            }
            catch
            {
                return RedirectToAction("List");
            }
        }








        // GET: Client/Delete/5
        public ActionResult Delete(String id)
        {
            Classe classe = sc.GetClasseByID(id);
            //sc.Delete(classe);
            // sc.Commit();
            return View(classe);
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(String id, IFormCollection collection)
        {
            Classe classe = sc.GetClasseByID(id);

            sc.Delete(classe);

            sc.Commit();
            return RedirectToAction("List");


        }
    }
}
