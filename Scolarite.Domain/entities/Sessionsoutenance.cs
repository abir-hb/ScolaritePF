﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Sessionsoutenance
    {
        public Sessionsoutenance()
        {
            Soutenance = new HashSet<Soutenance>();
        }

        public int Idsoutenance { get; set; }
        public string Datedebut { get; set; }
        public string Datefin { get; set; }
        public string Libelle { get; set; }
        public int Etat { get; set; }

        public virtual ICollection<Soutenance> Soutenance { get; set; }
    }
}
