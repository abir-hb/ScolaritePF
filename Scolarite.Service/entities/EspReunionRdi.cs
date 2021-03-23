using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspReunionRdi
    {
        public string IdEns { get; set; }
        public string Titre { get; set; }
        public DateTime DateReunion { get; set; }
        public string HeureDeb { get; set; }
        public string HeureFin { get; set; }
        public string Description { get; set; }
        public decimal IdReunion { get; set; }
        public string Flag { get; set; }
        public string IdGroupe { get; set; }
    }
}
