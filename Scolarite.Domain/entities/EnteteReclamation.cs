using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EnteteReclamation
    {
        public decimal IdEnteteReclamation { get; set; }
        public string NomEns { get; set; }
        public string TypeReclamation { get; set; }
        public DateTime DateReclamation { get; set; }
        public string Designation { get; set; }
        public string IdEns { get; set; }
    }
}
