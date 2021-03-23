using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspMoyModuleEtudiant
    {
        public string AnneeDeb { get; set; }
        public string IdEt { get; set; }
        public string CodeCl { get; set; }
        public bool? NiveauAcces { get; set; }
        public string CodeModule { get; set; }
        public string DesignationModule { get; set; }
        public string NumPanier { get; set; }
        public byte? NbHeures { get; set; }
        public decimal? Coef { get; set; }
        public string TypeMoy { get; set; }
        public decimal? Moyenne { get; set; }
        public DateTime? DateDernMaj { get; set; }
        public string Utilisateur { get; set; }
        public string CodeUe { get; set; }
        public string EtatRat { get; set; }
        public string ConfRat { get; set; }

        public virtual EspModule CodeModuleNavigation { get; set; }
        public virtual EspMoyPanierEtudiant EspMoyPanierEtudiant { get; set; }
    }
}
