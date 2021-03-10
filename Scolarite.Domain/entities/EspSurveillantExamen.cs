using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspSurveillantExamen
    {
        public byte NumSeance { get; set; }
        public string DateSeance { get; set; }
        public bool? Semestre { get; set; }
        public string Periode { get; set; }
        public string Module { get; set; }
        public string CodeCl { get; set; }
        public string Surveillant1 { get; set; }
        public string Surveillant2 { get; set; }
        public string HeureDebut { get; set; }
    }
}
