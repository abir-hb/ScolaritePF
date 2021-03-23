using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspRubrique
    {
        public string CodeRub { get; set; }
        public string Libelle { get; set; }
        public string Signe { get; set; }
        public decimal? Taux { get; set; }
        public decimal? Valeur { get; set; }
    }
}
