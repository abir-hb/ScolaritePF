using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class ComptCert
    {
        public DateTime DateCert { get; set; }
        public string Heure { get; set; }
        public decimal Cpt { get; set; }
        public string TypeCert { get; set; }
    }
}
