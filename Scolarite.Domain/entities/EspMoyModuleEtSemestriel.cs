using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspMoyModuleEtSemestriel
    {
        public string AnneeDeb { get; set; }
        public bool Semestre { get; set; }
        public string IdEt { get; set; }
        public string CodeCl { get; set; }
        public string CodeModule { get; set; }
        public string DesignationModule { get; set; }
        public byte? NbHeures { get; set; }
        public byte? Coef { get; set; }
        public string TypeMoy { get; set; }
        public decimal? Moyenne { get; set; }
        public DateTime? DateDernMaj { get; set; }
        public string Utilisateur { get; set; }
        public string CodeUe { get; set; }
    }
}
