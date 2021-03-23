using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class GroupeInscription
    {
        public string IdGroupe { get; set; }
        public string IdEt { get; set; }
        public string AnneeDeb { get; set; }

        public virtual EspInscription EspInscription { get; set; }
    }
}
