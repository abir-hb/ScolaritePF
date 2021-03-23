using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Projet
    {
        public Projet()
        {
            Groupe = new HashSet<Groupe>();
        }

        public string IdProjet { get; set; }
        public string TitreProjet { get; set; }
        public string Description { get; set; }
        public string CodeModule { get; set; }
        public string AnneeDeb { get; set; }
        public string Technologies { get; set; }
        public string Methodologie { get; set; }
        public string CodeCl { get; set; }
        public decimal? NumSemestre { get; set; }
        public string IdEns { get; set; }
        public DateTime? DateSaisie { get; set; }
        public DateTime? DateModif { get; set; }

        public virtual EspModule CodeModuleNavigation { get; set; }
        public virtual ICollection<Groupe> Groupe { get; set; }
    }
}
