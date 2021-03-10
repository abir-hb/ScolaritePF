using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAbsenceEnseignant
    {
        public string IdEns { get; set; }
        public string CodeModule { get; set; }
        public DateTime Date { get; set; }
        public string CodeCl { get; set; }
        public bool NumSceance { get; set; }
        public string Motif { get; set; }
        public byte? NbHeures { get; set; }
        public string AnneeDeb { get; set; }
        public string TypeAbs { get; set; }
        public string CodeMotif { get; set; }
        public byte? NbMinutes { get; set; }
        public string Utilisateur { get; set; }
        public bool? Semestre { get; set; }
        public string Observation { get; set; }
    }
}
