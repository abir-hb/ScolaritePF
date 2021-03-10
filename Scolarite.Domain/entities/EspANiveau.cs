using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspANiveau
    {
        public string IdEt { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Niveau { get; set; }
        public string Photos { get; set; }
        public bool? Niv { get; set; }
        public bool? NewNiveau { get; set; }
    }
}
