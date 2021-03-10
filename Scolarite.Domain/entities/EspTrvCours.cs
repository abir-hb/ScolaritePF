using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspTrvCours
    {
        public string IdDr { get; set; }
        public DateTime DateDeb { get; set; }
        public string Titre { get; set; }
        public decimal NbrJoursPrsv { get; set; }
        public string NomDr { get; set; }
    }
}
