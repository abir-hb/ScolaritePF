using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspNiveauLangue
    {
        public string IdEt { get; set; }
        public string Langue { get; set; }
        public string AncienNiveau { get; set; }
        public string NiveauActuel { get; set; }
        public string IdEns { get; set; }
        public DateTime DateNiveau { get; set; }
    }
}
