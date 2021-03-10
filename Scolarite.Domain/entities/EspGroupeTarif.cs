using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspGroupeTarif
    {
        public string AnneeDeb { get; set; }
        public string CodeGrp { get; set; }
        public string LibelleGrp { get; set; }
        public decimal? MontantTarif { get; set; }
        public decimal? MontantTranche1 { get; set; }
        public DateTime? EcheanceTranche1 { get; set; }
        public decimal? MontantTranche2 { get; set; }
        public DateTime? EcheanceTranche2 { get; set; }
        public DateTime? DateSaisie { get; set; }
        public DateTime? DateMaj { get; set; }
        public decimal? TauxTva { get; set; }
        public decimal? MontantTva { get; set; }
        public string CodeDevise { get; set; }
        public decimal? MontantTtc { get; set; }

        public virtual EspSaisonUniversitaire AnneeDebNavigation { get; set; }
    }
}
