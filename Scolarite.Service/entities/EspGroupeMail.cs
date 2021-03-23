using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspGroupeMail
    {
        public string IdGroupe { get; set; }
        public string IdEns { get; set; }
        public DateTime? DateSaisie { get; set; }
        public DateTime? DateModif { get; set; }
        public string Designation { get; set; }
        public string Utilisateur { get; set; }
    }
}
