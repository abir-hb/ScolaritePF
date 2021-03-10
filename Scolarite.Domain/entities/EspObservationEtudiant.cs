using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspObservationEtudiant
    {
        public string IdEt { get; set; }
        public string AnneeDeb { get; set; }
        public string CodeCl { get; set; }
        public string CodeModule { get; set; }
        public string IdEns { get; set; }
        public DateTime DateObs { get; set; }
        public string Observation { get; set; }
    }
}
