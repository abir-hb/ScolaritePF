using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Seance
    {
        public string IdSeance { get; set; }
        public string TypeSeance { get; set; }
        public DateTime? DateSeance { get; set; }
        public decimal? NumeroSeance { get; set; }
        public string IdPhase { get; set; }
        public string CodeCl { get; set; }

        public virtual Classe CodeClNavigation { get; set; }
    }
}
