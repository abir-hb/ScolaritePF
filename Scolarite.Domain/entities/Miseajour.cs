using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Miseajour
    {
        public string Annee { get; set; }
        public string Classe { get; set; }
        public string SessionPrincipale { get; set; }
        public string SessionRattrapage { get; set; }
        public string Decision { get; set; }
        public string Identifiant { get; set; }
    }
}
