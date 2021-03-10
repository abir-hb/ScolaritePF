using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspTabPlanSalle
    {
        public bool? Groupe { get; set; }
        public string AnneeDeb { get; set; }
        public string AnneeFin { get; set; }
        public string CodeCl { get; set; }
        public string IdEt { get; set; }
        public string NomEt { get; set; }
        public string PnomEt { get; set; }
        public int? CritereTri { get; set; }
    }
}
