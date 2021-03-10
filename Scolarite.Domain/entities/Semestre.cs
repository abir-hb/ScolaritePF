using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Semestre
    {
        public long Id { get; set; }
        public string Anneuniversitaire { get; set; }
        public DateTime? Datedeb { get; set; }
        public DateTime? Datfin { get; set; }
        public long Idsem { get; set; }
    }
}
