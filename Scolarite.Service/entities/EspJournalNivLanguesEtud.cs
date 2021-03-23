using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspJournalNivLanguesEtud
    {
        public string IdEt { get; set; }
        public string NomColonne { get; set; }
        public string TypeOp { get; set; }
        public DateTime DateOp { get; set; }
        public string Utilisateur { get; set; }
        public string ValInitfr { get; set; }
        public string ValFinalfr { get; set; }
        public string ValInitang { get; set; }
        public string ValFinalang { get; set; }
        public string HostName { get; set; }
    }
}
