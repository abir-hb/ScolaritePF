using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAuditFailedEns
    {
        public DateTime? DateOp { get; set; }
        public string ComCol { get; set; }
        public string CodeMat { get; set; }
        public string NomEns { get; set; }
        public string PEns { get; set; }
        public string NomMachine { get; set; }
        public string Justification { get; set; }
        public string IpAdress { get; set; }
    }
}
