using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class SansPhoto
    {
        public string Identifiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Niveau { get; set; }
        public decimal? Photos { get; set; }
        public string Niv { get; set; }
    }
}
