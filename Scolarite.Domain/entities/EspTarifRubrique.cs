using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspTarifRubrique
    {
        public string AnneeDeb { get; set; }
        public string CodeRub { get; set; }
        public string LibelleRub { get; set; }
        public decimal? MontantRub { get; set; }
        public decimal? TvaRub { get; set; }
        public string DeviseRub { get; set; }
        public decimal? Tranche1Rub { get; set; }
        public decimal? Tranche2Rub { get; set; }
        public decimal? MontantTva { get; set; }
        public decimal? MontantTtc { get; set; }
    }
}
