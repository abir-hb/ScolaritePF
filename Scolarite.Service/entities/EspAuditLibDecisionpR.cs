using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAuditLibDecisionpR
    {
        public string AnneeDeb { get; set; }
        public string CodeCl { get; set; }
        public string IdEt { get; set; }
        public string TypeOp { get; set; }
        public DateTime? DateOp { get; set; }
        public string Utilisateur { get; set; }
        public decimal? OldCodeDecisionSessionP { get; set; }
        public decimal? NewCodeDecisionSessionP { get; set; }
        public decimal? OldCodeDecisionSessionRat { get; set; }
        public decimal? NewCodeDecisionSessionRat { get; set; }
        public decimal? OldLibDecisionSessionRat { get; set; }
        public decimal? NewLibDecisionSessionRat { get; set; }
        public decimal? OldLibDecisionSessionP { get; set; }
        public decimal? NewLibDecisionSessionP { get; set; }
        public string IpAddress { get; set; }
        public string NomMachine { get; set; }
    }
}
