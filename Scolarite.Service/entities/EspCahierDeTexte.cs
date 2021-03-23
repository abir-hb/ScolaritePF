using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspCahierDeTexte
    {
        public string CodeCl { get; set; }
        public string CodeModule { get; set; }
        public string NumSeance { get; set; }
        public DateTime? DateSeance { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string Duree { get; set; }
        public string ContenuTraite { get; set; }
        public string Remarque { get; set; }
        public string AnneeDeb { get; set; }
        public string IdEns { get; set; }
        public string HeureDebut { get; set; }
        public string HeureFin { get; set; }
        public decimal NumSemestre { get; set; }
    }
}
