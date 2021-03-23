using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAffectationEmploi
    {
        public decimal CodeEmploi { get; set; }
        public string AnneeDeb { get; set; }
        public string CodeCl { get; set; }
        public string CodeModule { get; set; }
        public string IdEns { get; set; }
        public string SallePrincipale { get; set; }
        public DateTime? Jours { get; set; }
        public decimal? Cren1 { get; set; }
        public decimal? Cren2 { get; set; }
        public string Etat { get; set; }
        public string IdEns2 { get; set; }
        public string IdEns3 { get; set; }
        public string IdEns4 { get; set; }
    }
}
