using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspProjetN
    {
        public string AnneeDeb { get; set; }
        public string IdProjet { get; set; }
        public string NomProjet { get; set; }
        public string CodeModule { get; set; }
        public string TypeProjet { get; set; }
        public string DescriptionProjet { get; set; }
        public string Technologies { get; set; }
        public string Methodologie { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string IdEns { get; set; }
    }
}
