using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class DetailSeance
    {
        public string IdDetailSeance { get; set; }
        public string IdSeance { get; set; }
        public string IdUp { get; set; }
        public string IdEns { get; set; }
        public string Specification { get; set; }
        public string IdProjet { get; set; }
        public string IdPhase { get; set; }
        public DateTime? DateSaisie { get; set; }
        public DateTime? DateModif { get; set; }
        public string TypeAffectation { get; set; }
    }
}
