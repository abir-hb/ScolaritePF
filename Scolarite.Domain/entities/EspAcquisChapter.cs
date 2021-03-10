using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAcquisChapter
    {
        public string CodeModule { get; set; }
        public string CodeChapter { get; set; }
        public string Designation { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string AnneeDeb { get; set; }
        public string NumChapter { get; set; }
        public string EtatAcquis { get; set; }
        public string IdAcquis { get; set; }
        public string IdEnsModif { get; set; }
        public string DateDernierModif { get; set; }
    }
}
