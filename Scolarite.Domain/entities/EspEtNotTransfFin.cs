using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspEtNotTransfFin
    {
        public string IdEt { get; set; }
        public string Numcompte { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string JustifNotTransf { get; set; }
        public string Transferrred { get; set; }
        public DateTime? DateTransf { get; set; }
    }
}
