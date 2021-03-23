using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Presidentjury
    {
        public Presidentjury()
        {
            Soutenance = new HashSet<Soutenance>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Fonction { get; set; }
        public string Tel { get; set; }
        public int? Juryref { get; set; }
        public string Societe { get; set; }

        public virtual ICollection<Soutenance> Soutenance { get; set; }
    }
}
