using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspObservationEnseignant
    {
        public string AnneeDeb { get; set; }
        public DateTime DateSaisieObs { get; set; }
        public string IdEns { get; set; }
        public string IdResp { get; set; }
        public string QualiteResp { get; set; }
        public string Observation { get; set; }
    }
}
