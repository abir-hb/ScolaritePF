using Microsoft.AspNetCore.Mvc;
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


        public ClasseController(IServiceClasse serviceClasse)
        {
            sc = serviceClasse;
        }


        public IActionResult List()

        {
            return View(sc.GetAll());
        }
    }
}
