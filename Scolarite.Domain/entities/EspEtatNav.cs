using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspEtatNav
    {
        public string NumCompte { get; set; }
        public string IdentifiantEtudiant { get; set; }
        public string Nom { get; set; }
        public string SoldeDs { get; set; }
        public string Etat { get; set; }
        public string Formule { get; set; }
        public string CodeCl { get; set; }
        public decimal? SoldeEt { get; set; }
        public DateTime? DateSaisie { get; set; }
    }
}
