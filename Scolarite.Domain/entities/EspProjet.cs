using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspProjet
    {
        public EspProjet()
        {
            EspGroupeProjet = new HashSet<EspGroupeProjet>();
        }

        public string IdProjet { get; set; }
        public string AnneeDeb { get; set; }
        public string NomProjet { get; set; }
        public string DescriptionProjet { get; set; }
        public string Technologies { get; set; }
        public string Methodologie { get; set; }
        public string TypeProjet { get; set; }
        public string Niveau { get; set; }
        public string CodeModule { get; set; }
        public string IdEnseignant { get; set; }

        public virtual EspSaisonUniversitaire AnneeDebNavigation { get; set; }
        public virtual EspModule CodeModuleNavigation { get; set; }
        public virtual ICollection<EspGroupeProjet> EspGroupeProjet { get; set; }
    }
}
