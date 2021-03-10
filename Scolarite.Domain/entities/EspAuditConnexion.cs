using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAuditConnexion
    {
        public DateTime? DateConnect { get; set; }
        public string Utilisateur { get; set; }
        public string NomProgram { get; set; }
        public string AdresseIp { get; set; }
        public string NomMachine { get; set; }
    }
}
