using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspScoreSpecialite
    {
        public string AnneeDeb { get; set; }
        public string CodeSpec { get; set; }
        public bool NiveauAcces { get; set; }
        public byte? CapaciteAccueuil { get; set; }
        public decimal? ScoreMin { get; set; }
    }
}
