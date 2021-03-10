using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspMoyPanierEtudiant
    {
        public EspMoyPanierEtudiant()
        {
            EspMoyModuleEtudiant = new HashSet<EspMoyModuleEtudiant>();
        }

        public string AnneeDeb { get; set; }
        public string IdEt { get; set; }
        public string NumPanier { get; set; }
        public string CodeCl { get; set; }
        public bool? NiveauAcces { get; set; }
        public string DesignationPanier { get; set; }
        public byte? NbHeures { get; set; }
        public decimal? Coef { get; set; }
        public string TypeMoy { get; set; }
        public decimal? Moyenne { get; set; }
        public string Utilisateur { get; set; }
        public string EtIdEt { get; set; }

        public virtual ICollection<EspMoyModuleEtudiant> EspMoyModuleEtudiant { get; set; }
    }
}
