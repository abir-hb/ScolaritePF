using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Phase
    {
        public string IdPhase { get; set; }
        public DateTime? DateDeb { get; set; }
        public DateTime? DateFin { get; set; }
        public string Designation { get; set; }
        public decimal? NbreSeance { get; set; }
        public string Objectif { get; set; }
        public string CodeModule { get; set; }

        public virtual EspModule CodeModuleNavigation { get; set; }
    }
}
