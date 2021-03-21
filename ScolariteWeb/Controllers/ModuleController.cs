using Microsoft.AspNetCore.Mvc;
using Scolarite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScolariteWeb.Controllers
{
    public class ModuleController : Controller
    {
        private readonly IServiceModule sc;


        public ModuleController(IServiceModule serviceModule)
        {
            sc = serviceModule;
        }


        public IActionResult List()

        {
            return View(sc.GetAll());
        }
    }
}
