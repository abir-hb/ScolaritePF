using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspJournalMdpEns
    {
        public string IdEns { get; set; }
        public DateTime? DateModif { get; set; }
        public string OldMdp { get; set; }
        public string NewMdp { get; set; }
        public string IpModif { get; set; }
        public string MachineModif { get; set; }
    }
}
