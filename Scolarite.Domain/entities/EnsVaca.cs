using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EnsVaca
    {
        public string IdEns { get; set; }
        public string NomEns { get; set; }
        public string MailEns { get; set; }
        public string Cin { get; set; }
        public string DnEns { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string TypeEns { get; set; }
        public string DateRecrutement { get; set; }
    }
}
