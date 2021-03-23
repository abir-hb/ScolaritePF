using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAcquisValidEns
    {
        public string IdEns { get; set; }
        public string CodeCl { get; set; }
        public string CodeModule { get; set; }
        public string IdAcquis { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string DateSeance { get; set; }
        public string ProgCours { get; set; }
        public string RemarqueEns { get; set; }
        public string ProgCoursPercent { get; set; }
        public DateTime? DateModif { get; set; }
        public string Jour { get; set; }
    }
}
