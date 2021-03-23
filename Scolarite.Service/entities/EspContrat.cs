using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspContrat
    {
        public string Numord { get; set; }
        public string Annee { get; set; }
        public string IdEns { get; set; }
        public DateTime DateEtab { get; set; }
        public string Diplome { get; set; }
        public string Grade { get; set; }
        public string Institution { get; set; }
    }
}
