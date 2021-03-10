using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Sessionpresoutenance
    {
        public Sessionpresoutenance()
        {
            Presoutenance = new HashSet<Presoutenance>();
        }

        public int Idsoutenance { get; set; }
        public DateTime? Datedebut { get; set; }
        public DateTime? Datefin { get; set; }
        public string Libelle { get; set; }

        public virtual ICollection<Presoutenance> Presoutenance { get; set; }
    }
}
