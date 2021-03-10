using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspDirection
    {
        public string IdDr { get; set; }
        public string NomDr { get; set; }
        public string PnomDr { get; set; }
        public string TitreDr { get; set; }
        public DateTime? DateRec { get; set; }
        public string AdresseMailEsp { get; set; }
        public string Tel { get; set; }
        public string Diplome { get; set; }
        public string CinPass { get; set; }
    }
}
