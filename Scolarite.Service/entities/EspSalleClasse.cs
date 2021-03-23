using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspSalleClasse
    {
        public decimal Id { get; set; }
        public decimal? AnneeDeb { get; set; }
        public string CodeCl { get; set; }
        public string Salle { get; set; }
    }
}
