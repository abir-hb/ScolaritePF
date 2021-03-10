using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspRemarqueAbsence
    {
        public string AnneeDeb { get; set; }
        public bool Semestre { get; set; }
        public string IdEt { get; set; }
        public string CodeCl { get; set; }
        public string IdEns { get; set; }
        public DateTime DateRemarque { get; set; }
        public string LibelleRemarque { get; set; }
        public string EtatConvocation { get; set; }

        public virtual EspSaisonClasse EspSaisonClasse { get; set; }
    }
}
