using Scolarite.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScolariteWeb.ViewModels
{
    public class ClasseViewModel
    {
        public Classe Classe { get; set; }
        public IEnumerable<Classe> Classes { get; set; }
    }
}
