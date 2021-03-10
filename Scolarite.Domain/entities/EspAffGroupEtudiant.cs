using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAffGroupEtudiant
    {
        public EspAffGroupEtudiant()
        {
            EspSuiviProjetIndiv = new HashSet<EspSuiviProjetIndiv>();
        }

        public string IdGroupe { get; set; }
        public string AnneeDeb { get; set; }
        public string IdEt { get; set; }
        public DateTime? DateAffectation { get; set; }

        public virtual ICollection<EspSuiviProjetIndiv> EspSuiviProjetIndiv { get; set; }
    }
}
