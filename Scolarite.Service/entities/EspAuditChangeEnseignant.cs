using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAuditChangeEnseignant
    {
        public string IdEns { get; set; }
        public DateTime? DateOp { get; set; }
        public string ComCol { get; set; }
        public string ValInit { get; set; }
        public string ValFinal { get; set; }
        public string AdresseIp { get; set; }
        public string NomMachine { get; set; }
    }
}
