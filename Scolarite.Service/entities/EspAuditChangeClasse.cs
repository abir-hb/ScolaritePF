using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAuditChangeClasse
    {
        public string AnneeDeb { get; set; }
        public string IdEt { get; set; }
        public DateTime? DateInscription { get; set; }
        public DateTime DateChangementCl { get; set; }
        public string OldCl { get; set; }
        public string NewCl { get; set; }
        public string IpMachine { get; set; }
        public string NomMachine { get; set; }
        public string Utilisateur { get; set; }
    }
}
