using Microsoft.AspNetCore.Mvc;
using Scolarite.Domain.entities;
using Scolarite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScolariteWeb.Controllers
{
    public class upController : Controller
    {

        private readonly IServiceUp sp;

        ModelContext context = new ModelContext();


        public upController(IServiceUp serviceup)
        {
            sp = serviceup;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()

        {
            return View(sp.GetAll());
            
        }
    }
}
