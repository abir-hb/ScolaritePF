using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspCalcul
    {
        public string IdEt { get; set; }
        public decimal? ScoreEntretien { get; set; }
        public decimal? ScoreDossier { get; set; }
        public decimal? ScoreTest { get; set; }
        public decimal? ScoreFinal { get; set; }
        public decimal? ScoreFrancais { get; set; }
        public decimal? ScoreAnglais { get; set; }
        public decimal? ScoreQi { get; set; }
    }
}
