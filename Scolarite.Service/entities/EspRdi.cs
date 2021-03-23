using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspRdi
    {
        public string IdRdi { get; set; }
        public string CodeProduction { get; set; }
        public string LibProduction { get; set; }
        public DateTime? DateProduction { get; set; }
        public string CodeRefProduction { get; set; }
        public string LibRefProduction { get; set; }
        public string Description { get; set; }
        public string PartiePrenente { get; set; }
        public string IdEns { get; set; }
        public string NomEns { get; set; }
        public string ChargeH { get; set; }
    }
}
