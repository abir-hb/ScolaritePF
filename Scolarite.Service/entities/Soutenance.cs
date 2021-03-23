using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Soutenance
    {
        public int Soutenanceid { get; set; }
        public string Dte { get; set; }
        public int? Jury { get; set; }
        public string Heure { get; set; }
        public string Repporteur { get; set; }
        public bool Etat { get; set; }
        public string Idrapporteur { get; set; }
        public int? PrId { get; set; }
        public string EtIdEt { get; set; }
        public int? SessionsoutenanceIdsoutenance { get; set; }

        public virtual Presidentjury Pr { get; set; }
        public virtual Sessionsoutenance SessionsoutenanceIdsoutenanceNavigation { get; set; }
    }
}
