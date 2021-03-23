using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspTempModifClasse
    {
        public string IdEt { get; set; }
        public string CodeCl { get; set; }
        public string CodeClDemander { get; set; }
        public string AnneeDeb { get; set; }
        public string Etat { get; set; }
        public DateTime? DateSaisie { get; set; }
    }
}
