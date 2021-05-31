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

namespace ScolariteWeb.Controllers
{
    public class EnsController : Controller
    {
        

        private readonly IServiceENS se;

        ModelContext context = new ModelContext();

        List<EnsViewModel> enseignants = new List<EnsViewModel>();
       private readonly EspEnseignant e = new EspEnseignant();
        public EnsController(IServiceENS serviceEns)
        {
            se = serviceEns;

        }
        // GET: EnsController
        public ActionResult List()
        {
            
            return View(se.GetAll());
        }
        public ActionResult DetailsEns()
        {
           List<EspEnseignant> ens = (List<EspEnseignant>)se.GetAll();
            EnsViewModel myModel = new EnsViewModel();
            myModel.Enseignants = ens;
            return View(myModel);

        }
        // GET: EnsController/Details/5

        public ActionResult Details(String id)


        {


            
                EspEnseignant enseignant = se.GetEnsByID(id);
                return View(enseignant);
            
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Details(string id, EnsViewModel ens)
        //{

        //    EspEnseignant enseignant = se.GetEnsByID(id);
        //    enseignant.ChargeEns = ens.Enseignant.ChargeEns;
        //    enseignant.Cin = ens.Enseignant.Cin;
        //    enseignant.CnssEns = ens.Enseignant.CnssEns;
        //    enseignant.CodeGradeActuel = ens.Enseignant.CodeGradeActuel;
        //    enseignant.CodeGradeEntree = ens.Enseignant.CodeGradeEntree;
        //    enseignant.DateModifyJwtPwd = ens.Enseignant.DateModifyJwtPwd;
        //    enseignant.DateRec = ens.Enseignant.DateRec;
        //    enseignant.SexeEns = ens.Enseignant.SexeEns;
        //    enseignant.Tel = ens.Enseignant.Tel;
        //    enseignant.PwdJwtEnseignant = ens.Enseignant.PwdJwtEnseignant;
        //    enseignant.PwdInit = ens.Enseignant.PwdInit;
        //    enseignant.PwdEns = ens.Enseignant.PwdEns;
        //    enseignant.PrenomEns = ens.Enseignant.PrenomEns;
        //    enseignant.Niveau = ens.Enseignant.Niveau;
        //    enseignant.NbHeureEns = ens.Enseignant.NbHeureEns;
        //    enseignant.MailEns = ens.Enseignant.MailEns;
        //    enseignant.LibGradeEntree = ens.Enseignant.LibGradeEntree;
        //    enseignant.LibGradeActuelle = ens.Enseignant.LibGradeActuelle;
        //    enseignant.NomEns = ens.Enseignant.NomEns;

        //    /*  Classe classe1 = new Classe()
        //      {
        //          CodeCl=User.gui
        //      };*/
          
        ////    se.Commit();

        //   return View(enseignant);


        //}

        //// GET: EnsController/Create
        //[HttpGet]
        //public IActionResult Create()
        //{
        //    EspEnseignant ens = new EspEnseignant();
        //    return PartialView("_EnsModalCreate", ens);
        //}

        //// POST: EnsController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(EspEnseignant ens)
        //{

        //    se.CreateEns(ens);
        //    return RedirectToAction("List");


        //}

        //List<EspEnseignant> ens = (List<EspEnseignant>)se.GetAll();
        //EnsViewModel myModel = new EnsViewModel();
        //myModel.Enseignants = ens;
        //    return View(myModel);

        // GET: EnsController/Create
        public ActionResult Create()
        {
            EspEnseignant ens = new EspEnseignant();
            EnsViewModel model = new EnsViewModel();
            model.Enseignant = ens;
            return View(model);
        }

        // POST: EnsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EnsViewModel ensView)
        {
           

            EspEnseignant enseignant = new EspEnseignant();
            enseignant = ensView.Enseignant;
          //  ensView.Enseignant = enseignant;
            se.CreateEns(enseignant);
            return RedirectToAction("DetailsEns");

         
        }
      
        public ActionResult Delete(String id)
        {
            EnsViewModel model = new EnsViewModel();
            EspEnseignant ens = se.GetEnsByID(id);
            //EnsViewModel m = enseignants.SingleOrDefault(b => b.Enseignant.IdEns == id);

            model.Enseignant = ens;
            //sc.Delete(classe);
            // sc.Commit();
            return View(model);

        }

       

        // POST: EnsController/Delete/5
        [HttpPost]
       
        public ActionResult Delete(string id, EnsViewModel model)
        {
            //EnsViewModel m = enseignants.SingleOrDefault(b => b.Enseignant.IdEns == id);
            //EspEnseignant ens = new EspEnseignant();
            //ens = m.Enseignant;
            //se.Delete(ens);
            //se.Commit();

            //return RedirectToAction("List");

         //   EnsViewModel model = new EnsViewModel();
            EspEnseignant ens = se.GetEnsByID(id);
            model.Enseignant = ens;
            se.Delete(ens);
            se.Commit();
            return RedirectToAction("DetailsEns");

        }

        public ActionResult Edit(String id)
        {
            EnsViewModel ens = new EnsViewModel();
                
            EspEnseignant enseignant = se.GetEnsByID(id);
            ens.Enseignant = enseignant;
            return View(ens);
        }

        // POST: Classe/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, EnsViewModel ens)
        {
          
             EspEnseignant enseignant = se.GetEnsByID(id);
            enseignant.ChargeEns = ens.Enseignant.ChargeEns;
            enseignant.Cin = ens.Enseignant.Cin;
            enseignant.CnssEns = ens.Enseignant.CnssEns;
            enseignant.CodeGradeActuel = ens.Enseignant.CodeGradeActuel;
            enseignant.CodeGradeEntree = ens.Enseignant.CodeGradeEntree;
            enseignant.DateModifyJwtPwd = ens.Enseignant.DateModifyJwtPwd;
            enseignant.DateRec = ens.Enseignant.DateRec;
            enseignant.SexeEns = ens.Enseignant.SexeEns;
            enseignant.Tel = ens.Enseignant.Tel;
            enseignant.PwdJwtEnseignant = ens.Enseignant.PwdJwtEnseignant;
            enseignant.PwdInit = ens.Enseignant.PwdInit;
            enseignant.PwdEns = ens.Enseignant.PwdEns;
            enseignant.PrenomEns = ens.Enseignant.PrenomEns;
            enseignant.Niveau = ens.Enseignant.Niveau;
            enseignant.NbHeureEns = ens.Enseignant.NbHeureEns;
            enseignant.MailEns = ens.Enseignant.MailEns;
            enseignant.LibGradeEntree = ens.Enseignant.LibGradeEntree;
            enseignant.LibGradeActuelle = ens.Enseignant.LibGradeActuelle;
            enseignant.NomEns = ens.Enseignant.NomEns;
          //  ens.Enseignant = enseignant;
                /*  Classe classe1 = new Classe()
                  {
                      CodeCl=User.gui
                  };*/
                se.UpdateEns(enseignant);


                context.Entry(enseignant).State = EntityState.Modified;
                //   context.SaveChanges();
                  se.Commit();

                return RedirectToAction("DetailsEns");
            
            
        }
    }
}
