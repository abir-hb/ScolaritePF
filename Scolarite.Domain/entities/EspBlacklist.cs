using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspBlacklist
    {
        public string IdEt { get; set; }
        public string NumCpt { get; set; }
        public string NomEt { get; set; }
        public string PnomEt { get; set; }
        public string CodeCl { get; set; }
        public decimal? MontFrais { get; set; }
        public decimal? MontRegle { get; set; }
        public decimal? Taux60 { get; set; }
        public decimal? ResteSurTaux60 { get; set; }
        public decimal? CaAnnuel { get; set; }
        public decimal? Paiement { get; set; }
        public decimal? SoldeActuel { get; set; }
    }
}
