using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAuditCredit
    {
        public string AnneeDeb { get; set; }
        public decimal? OldValCredit { get; set; }
        public decimal? NewValCredit { get; set; }
        public string AdresseIp { get; set; }
        public string Machine { get; set; }
        public DateTime DateOp { get; set; }
    }
}
