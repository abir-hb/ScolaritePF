using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Scolarite.Domain.entities;
using Scolarite.Service;
using ScolariteWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ScolariteWeb.Controllers
{
    public class ModuleController : Controller
    {
        private readonly IServiceModule sm;
        private readonly IServiceUE se;
        private readonly IServiceUp sp;

        private readonly ModelContext context;
        //  List<EspUp> ups = new List<EspUp>();
        public IEnumerable<EspModule> modules { get; set; }
        public ModuleController(IServiceModule serviceModule, IServiceUE serviceUE, IServiceUp serviceUp, ModelContext ctx)
        {
            sm = serviceModule;
            se = serviceUE;
            sp = serviceUp;
            context = ctx;
        }
        //url : /Module/GetAllDataApiJson
        [HttpGet]

        public async Task<IActionResult> GetAllDataApiJson()
        {
            return Json(new { data = await context.EspModule.ToListAsync() });


        }

        [HttpGet]
        public IActionResult List()

        {
            List<EspModule> module = (List<EspModule>)sm.GetAll();
            ModuleViewModel myModel = new ModuleViewModel();
            myModel.Modules = module;
            return View(myModel);

            //return View(sm.GetAll());

        }



        //[HttpPost]
        //[ValidateAntiForgeryToken]
        ////[ValidateInput(false)]
        //public ActionResult Index(EspModule m)
        //{

        //    List<dynamic> modules = new List<dynamic> { new EspModule
        //    {

        //        CodeModule=m.CodeModule,
        //        Description=m.Description,
        //        AEvaluer=m.AEvaluer,
        //        AnneeDeb=m.AnneeDeb,
        //        CodeUe=m.CodeUe,
        //        Coef=m.Coef,
        //        Designation=m.Designation,
        //        NbHeures=m.NbHeures,


        //    } };

        //    List<dynamic> list = new List<dynamic> { new EspModule
        //    {

        //        CodeModule=m.CodeModule,
        //        Description=m.Description,
        //        AEvaluer=m.AEvaluer,
        //        AnneeDeb=m.AnneeDeb,
        //        CodeUe=m.CodeUe,
        //        Coef=m.Coef,
        //        Designation=m.Designation,
        //        NbHeures=m.NbHeures,


        //    } };
        //    list.AddRange(modules);
        //    foreach (var i in list)
        //    {
        //        context.EspModule.Add(i);
        //    }
        //    context.SaveChanges();
        //    return View(list);
        //}

        //get
        public ActionResult Create()

        {
            //List<EspModule> list = new List<EspModule> { new EspModule
            //{

            //    CodeModule="mm",
            //    Description="",
            //    AEvaluer="",
            //    AnneeDeb="",
            //    CodeUe="",
            //    Coef= 5 ,
            //    Designation="",
            //    NbHeures=55,


            //} };

            //return View(list);


            var ues = se.GetAll();
            var listup = sp.GetAll();


            ViewBag.CodeUe = new SelectList(ues, "CodeUe", "LibUe");
            ViewBag.AnneeDeb = new SelectList(ues, "AnneeDeb", "AnneeDeb");

           ViewBag.listup= new SelectList(listup, "Up", "Designantion");
            // Console.Out.WriteLine("erreur" + ViewData["listup"]);
            //  Debug.WriteLine(listup);
            //  Debug.WriteLine(ViewBag.Up);



            // return View();

            EspModule em = new EspModule();
            return View(em);
        }
        //// catch




 //       POST: module/Create
       [HttpPost]
       [ValidateAntiForgeryToken]
        //[ValidateInput(false)]
        public ActionResult Create(EspModule c)
        {

            List<EspModule> list = new List<EspModule>();


            list.Add(c);
            sm.CreateM(c);
            context.Entry(c).State = EntityState.Added;
            //context.SaveChanges();
            return View();

        }

        //public List<EspModule> CreateList(EspModule em)
        //{
        //    List<EspModule> modules = new List<EspModule>();
        //    modules.Add(em);
        //    sm.CreateList(em);
        //    return modules;
        //    // EspModule em = new EspModule();
          
        //  //  return List;

        //}
        public ActionResult Delete(String id)
        {
            EspModule module = sm.GetModuleByID(id);
            //sc.Delete(classe);
            // sc.Commit();
            return View(module);
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
            var ues = se.GetAll();
            var listup = sp.GetAll();

            var annees = se.GetAll();
            ViewBag.ues = new SelectList(ues, "CodeUe", "LibUe");
            ViewBag.annees = new SelectList(annees, "AnneeDeb", "AnneeDeb");

            ViewBag.listup = new SelectList(listup, "Up", "Designantion");
            EspModule module = sm.GetModuleByID(id);
            return View(module);
        }

        // POST: Classe/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, EspModule model)
        {
            try
            {

                EspModule module = sm.GetModuleByID(id);
                module.AnneeDeb = model.AnneeDeb;
                module.CodeMatiereEduserv = model.CodeMatiereEduserv;
                module.CodeModule = model.CodeModule;
                module.CodeUe = model.CodeUe;
                module.Coef = model.Coef;
                module.Description = model.Description;
                module.Designation = model.Designation;
                module.AEvaluer = model.AEvaluer;
               
                module.NbHeures = model.NbHeures;
                module.NumPanier = model.NumPanier;
                module.TypeEpreuve = model.TypeEpreuve;
                module.TypeEpreuveSr = model.TypeEpreuveSr;
                module.TypeModule = model.TypeModule;
                module.Up = model.Up;
                
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


        //public ActionResult Index()
        //{
        //    return View(); //this is main page.We will display  "_AddMorePartialView" partial page on this main page
        //}


        public ActionResult Details(String id)


        {



            EspModule module = sm.GetModuleByID(id);
            return View(module);

        }
        public ActionResult AddMorePartialView()
        {
            //this  action page is support cal the partial page.
            //We will call this action by view page.This Action is return partial page
            EspModule model = new EspModule();
            return PartialView("_AddMorePartialView", model);
            //^this is actual partical page we have 
            //create on this page in Home Controller as given below image
        }


        public ActionResult PostAddMore()
        {
            List<EspModule> list = new List<EspModule>();

            //  EspModule em = new EspModule();
            return View(list);

            //  EspModulePanierClasseSaiso em = new EspModulePanierClasseSaiso();
            // return View(em);
            //Here,Post addmore value from view page and get multiple values from view page
            // return View();
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult PostAddMore(EspModule model)
        //{

        //   // List<EspModule> list = new List<EspModule>();
        //    //  EspModule m = sm.GetModuleByID(id);


        //  //  list.Add(model);
        //    // sm.CreateModule(model);
        //    //    sm.CreateModule(List);

        //  /*  foreach (var i in model.AddMoreList)
        //    {
        //       */
               

        //        //  list.Add(i);
        //        //     context.Entry(i).State = EntityState.Added;
        //        //  sm.CreateModule(i);
        //       //  context.Add(i);
        //       // context.SaveChanges();
        //      //  Console.WriteLine(i.CodeModule);   
        //            }

        //    //   list.Add(m);
        //    // sm.CreateList(list);
        //    // context.SaveChanges();
        //    //ViewBag.Message = "Data successfully";



        //    return View();
        //   // return model.AddMoreList;
        //   //  return RedirectToAction("List");




        //    //Here,Post addmore value from view page and get multiple values from view page
        //    //  return RedirectToAction("List");
        //}


    }
}
