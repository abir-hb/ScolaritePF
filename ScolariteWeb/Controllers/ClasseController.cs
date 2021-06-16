using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scolarite.Domain.entities;
using Scolarite.Service;
using ScolariteWeb.ViewModels;
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
            List<Classe> classe = (List<Classe>)sc.GetAll();
            ClasseViewModel myModel = new ClasseViewModel();
            myModel.Classes = classe;
            return View(myModel);
        }
        public ActionResult Index()

        {
            return View();
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



            if (ModelState.IsValid) {
                {
                    sc.CreateCl(c);
                    //  context.Entry(c).State = EntityState.Added;
                    // context.SaveChanges();
                    return RedirectToAction("List");
                } }
            else {


            } return View(); }



        // GET: Classe/Edit/5
        public ActionResult Edit(String id)
        {
            Classe classe = sc.GetClasseByID(id);
            return View(classe);
        }

        // POST: Classe/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Classe espClasse)
        {

            Classe classe = sc.GetClasseByID(id);
            classe.AnneeScolaire = espClasse.AnneeScolaire;
            classe.Categorie = espClasse.Categorie;
            classe.CodeDept = espClasse.CodeDept;
            classe.CodeOption = espClasse.CodeOption;
            classe.CodeSpecialite = espClasse.CodeSpecialite;
            classe.DateAffectMc = espClasse.DateAffectMc;
            classe.DateCr = espClasse.DateCr;
            classe.DateDernModif = espClasse.DateDernModif;
            classe.DescriptionCl = espClasse.DescriptionCl;
            classe.Filiere = espClasse.Filiere;
            classe.LibelleCl = espClasse.LibelleCl;
            classe.LibFiliere = espClasse.LibFiliere;
            classe.LibSpecialite = espClasse.LibSpecialite;
            classe.Mail = espClasse.Mail;
            classe.NiveauAccees = espClasse.NiveauAccees;
            classe.Pole = espClasse.Pole;
            classe.SallePrincipale = espClasse.SallePrincipale;
            classe.SalleSecondaire2 = espClasse.SalleSecondaire2;

            classe.Seance = espClasse.Seance;
            classe.SelleSecondaire1 = espClasse.SelleSecondaire1;
            classe.SiteEsp = espClasse.SiteEsp;
            

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

    


        // GET: Client/Delete/5
        public ActionResult Delete(String id)
        {
            ClasseViewModel model = new ClasseViewModel();

            Classe classe = sc.GetClasseByID(id);
            model.Classe = classe;
            //sc.Delete(classe);
            // sc.Commit();
            return View(model);
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(String id, ClasseViewModel model)
        {
            Classe classe = sc.GetClasseByID(id);
            model.Classe = classe;
            sc.Delete(classe);

            sc.Commit();
            return RedirectToAction("List");


        }

        public ActionResult Details(String id)


        {



            Classe classe = sc.GetClasseByID(id);
            return View(classe);

        }

    }
}
