using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspInscri
    {
        public decimal IdInscription { get; set; }
        public string NomEt { get; set; }
        public string PrenomEt { get; set; }
        public string AdresseEt { get; set; }
        public DateTime DateMisejour { get; set; }
        public DateTime? DateIns { get; set; }
        public string HeureIns { get; set; }
        public string NomJeton { get; set; }
        public string IdEt { get; set; }
        public string TypeCcna { get; set; }
    }
}
