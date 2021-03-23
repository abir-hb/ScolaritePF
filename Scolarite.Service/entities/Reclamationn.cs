using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Reclamationn
    {
        public string NomEns { get; set; }
        public decimal? IdEnteteReclamation { get; set; }
        public decimal IdReclamtion { get; set; }
        public string Traiter { get; set; }
        public DateTime DateTraitement { get; set; }
        public string Description { get; set; }
        public string Utilisateur { get; set; }
    }
}
