using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspProjetEtudiant
    {
        public string IdProjet { get; set; }
        public string IdEt { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string IdEns { get; set; }
        public DateTime? DateDernModif { get; set; }
        public string AnneeDeb { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
    }
}
