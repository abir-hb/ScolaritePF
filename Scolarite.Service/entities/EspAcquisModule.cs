using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAcquisModule
    {
        public string CodeModule { get; set; }
        public string TitreChapter { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string AnneeDeb { get; set; }
        public string NumChapter { get; set; }
        public string IdEns { get; set; }
        public string CodeUe { get; set; }
        public string HoraireChap { get; set; }
    }
}
