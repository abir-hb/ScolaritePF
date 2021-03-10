using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Presoutenance
    {
        public int IdPresoutenance { get; set; }
        public string Dte { get; set; }
        public string Heure { get; set; }
        public int? Etat { get; set; }
        public int? SessionpsoutIdsoutenance { get; set; }
        public string EtIdEt { get; set; }

        public virtual Sessionpresoutenance SessionpsoutIdsoutenanceNavigation { get; set; }
    }
}
