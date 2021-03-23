using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAbsenceNew
    {
        public string IdEt { get; set; }
        public string CodeModule { get; set; }
        public string CodeCl { get; set; }
        public string AnneeDeb { get; set; }
        public decimal NumSeance { get; set; }
        public DateTime DateSeance { get; set; }
        public string IdEns { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string Utilisateur { get; set; }
        public bool? Semestre { get; set; }
        public string Justification { get; set; }
        public string CodeJustif { get; set; }
        public string LibJustif { get; set; }
        public string AConvoquer { get; set; }
        public string Observation { get; set; }
        public decimal? NewSemestre { get; set; }
    }
}
