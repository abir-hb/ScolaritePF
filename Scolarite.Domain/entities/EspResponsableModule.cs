using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspResponsableModule
    {
        public string IdEns { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string AnneeDeb { get; set; }
        public string Etat { get; set; }
        public string CodeModule { get; set; }
        public DateTime? DateModif { get; set; }
        public string IdUserModif { get; set; }
    }
}
