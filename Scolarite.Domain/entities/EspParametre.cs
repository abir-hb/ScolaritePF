using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspParametre
    {
        public string AnneeEnCours { get; set; }
        public bool? NumSemestre { get; set; }
        public string NumPeriode { get; set; }
        public string AnneeFin { get; set; }
        public string Annee0 { get; set; }
        public string AnneeDeb { get; set; }
    }
}
