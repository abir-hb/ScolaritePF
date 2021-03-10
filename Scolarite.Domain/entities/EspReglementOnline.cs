using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspReglementOnline
    {
        public string IdEt { get; set; }
        public string AnneeDeb { get; set; }
        public DateTime DateRglt { get; set; }
        public string MotifRglt { get; set; }
        public string AnneeRglt { get; set; }
        public string RgltVeridfie { get; set; }
        public string Comptabilise { get; set; }
    }
}
