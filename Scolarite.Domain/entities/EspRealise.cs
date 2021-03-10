using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspRealise
    {
        public string IdDr { get; set; }
        public string Titre { get; set; }
        public decimal NbJours { get; set; }
        public string Resultat { get; set; }
        public string NomDr { get; set; }
    }
}
