using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspDispenseEtudiant
    {
        public string IdEt { get; set; }
        public string CodeModule { get; set; }
        public string AnneeDeb { get; set; }
        public bool Semestre { get; set; }
        public decimal Moyenne { get; set; }
        public string Observation { get; set; }
        public DateTime? DateDebutDispense { get; set; }
    }
}
