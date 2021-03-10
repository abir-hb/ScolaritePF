using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspArchivageEtudiant
    {
        public string IdEt { get; set; }
        public string TypeArchivage { get; set; }
        public DateTime DateArchivage { get; set; }
        public string MotifArchivage { get; set; }
        public string RespArchivage { get; set; }
        public string IpRchivage { get; set; }
        public string MachineArchivage { get; set; }
    }
}
