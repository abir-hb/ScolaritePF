using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspEtudiantsDiplomes
    {
        public string IdEt { get; set; }
        public string AnneeDeb { get; set; }
        public string NatureEtude { get; set; }
        public decimal? NotePfe { get; set; }
        public string Specialite { get; set; }
        public DateTime? DateSaisie { get; set; }
    }
}
