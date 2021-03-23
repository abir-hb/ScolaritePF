using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Tes
    {
        public string NomEt { get; set; }
        public string PnomEt { get; set; }
        public string IdEt { get; set; }
        public string Reorientation { get; set; }
        public string ScoreReorientation { get; set; }
        public string NumChoixReorientation { get; set; }
        public string MinScorePourReorientation { get; set; }
        public string ChoixActuel { get; set; }
        public string ScorChActuel { get; set; }
        public string NumChoixActuel { get; set; }
        public string CodeCl { get; set; }
    }
}
