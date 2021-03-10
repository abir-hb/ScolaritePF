using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAbscence
    {
        public string IdEt { get; set; }
        public string CodeModule { get; set; }
        public string NumPanier { get; set; }
        public string CodeCl { get; set; }
        public string AnneeDeb { get; set; }
        public string AnneeFin { get; set; }
        public decimal NumSceance { get; set; }
        public DateTime DateSceance { get; set; }
        public string IdEns { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string Utilisateur { get; set; }
        public bool? Semestre { get; set; }
        public string Justification { get; set; }
        public string CodeJustif { get; set; }
        public string LibJustif { get; set; }
    }
}
