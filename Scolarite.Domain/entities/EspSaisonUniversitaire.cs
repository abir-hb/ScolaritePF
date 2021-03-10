using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspSaisonUniversitaire
    {
        public EspSaisonUniversitaire()
        {
            EspExamen = new HashSet<EspExamen>();
            EspGroupeTarif = new HashSet<EspGroupeTarif>();
            EspInscription = new HashSet<EspInscription>();
            EspProjet = new HashSet<EspProjet>();
            EspSaisonClasse = new HashSet<EspSaisonClasse>();
        }

        public string AnneeDeb { get; set; }
        public string AnneeFin { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EspExamen> EspExamen { get; set; }
        public virtual ICollection<EspGroupeTarif> EspGroupeTarif { get; set; }
        public virtual ICollection<EspInscription> EspInscription { get; set; }
        public virtual ICollection<EspProjet> EspProjet { get; set; }
        public virtual ICollection<EspSaisonClasse> EspSaisonClasse { get; set; }
    }
}
