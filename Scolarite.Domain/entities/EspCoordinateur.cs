using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspCoordinateur
    {
        public string IdEns { get; set; }
        public string Categorie { get; set; }
        public string CodeModule { get; set; }
        public string AnneeDeb { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string CodeSpecialite { get; set; }
        public string CodeCl { get; set; }
        public decimal NumSemestre { get; set; }
        public string IdEnsChefDept { get; set; }
        public string NomEns { get; set; }
        public string Designation { get; set; }
    }
}
