using Scolarite.Domain.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScolariteWeb.ViewModels
{
    public class EnsViewModel
    {
        public EspEnseignant Enseignant { get; set; }



        public IEnumerable<EspEnseignant> Enseignants { get; set; }
    }
}
