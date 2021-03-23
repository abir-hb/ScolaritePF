using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspFormation
    {
        public EspFormation()
        {
            EspFormateur = new HashSet<EspFormateur>();
        }

        public decimal Id { get; set; }
        public string Intitule { get; set; }
        public string Domaine { get; set; }
        public string Theme { get; set; }
        public string Objectifs { get; set; }
        public decimal? Nombremax { get; set; }
        public string Lieurealisation { get; set; }
        public DateTime? Datedebut { get; set; }
        public DateTime? Datefin { get; set; }
        public string Dascriptiondate { get; set; }
        public string References { get; set; }
        public string Aquisdapprentissages { get; set; }
        public string Impact { get; set; }
        public string Indicateure { get; set; }
        public string Etatform { get; set; }

        public virtual ICollection<EspFormateur> EspFormateur { get; set; }
    }
}
