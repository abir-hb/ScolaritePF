using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspTempEtudiantEnreg
    {
        public string IdEt { get; set; }
        public string IdEnsEntretien { get; set; }
        public decimal? ScoreEntretien { get; set; }
        public DateTime? DateSaisie { get; set; }
    }
}
