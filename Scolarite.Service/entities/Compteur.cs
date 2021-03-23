using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Compteur
    {
        public string CodeCpt { get; set; }
        public string LibCpt { get; set; }
        public DateTime? DateCr { get; set; }
        public DateTime? DateLastModif { get; set; }
    }
}
