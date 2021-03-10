using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspWhiteList
    {
        public string IdEt { get; set; }
        public string NumCpt { get; set; }
        public string NomEt { get; set; }
        public string PnomEt { get; set; }
        public string CodeCl { get; set; }
        public decimal? MontFrais { get; set; }
        public decimal? MontRegle { get; set; }
        public DateTime? DateLimite { get; set; }
    }
}
