using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAbsence
    {
        public decimal Id { get; set; }
        public string IdEleve { get; set; }
        public string IdProf { get; set; }
        public string IdMat { get; set; }
        public string IdClasse { get; set; }
        public string Justifier { get; set; }
        public string Motif { get; set; }
        public decimal? Crenaux { get; set; }
        public DateTime? IdDate { get; set; }
        public string AnneeDeb { get; set; }
        public string Semestre { get; set; }
        public string Remarque { get; set; }
        public DateTime? DateSaisie { get; set; }
    }
}
