using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Scolarite.Domain.entities
{
    public partial class Classe
    {
        public Classe()
        {
            EspGroupeProjet = new HashSet<EspGroupeProjet>();
            EspModulePanierClasseSaiso = new HashSet<EspModulePanierClasseSaiso>();
            EspSaisonClasse = new HashSet<EspSaisonClasse>();
            Seance = new HashSet<Seance>();
        }
        [Required(ErrorMessage = "le champs Code est obligatoire")]
        public string CodeCl { get; set; }
       
        public string LibelleCl { get; set; }
        
        public string DescriptionCl { get; set; }
        
        public DateTime? DateCr { get; set; }
        public DateTime? DateDernModif { get; set; }
        public string SallePrincipale { get; set; }
        public string SelleSecondaire1 { get; set; }
        public string SalleSecondaire2 { get; set; }
        public bool? NiveauAccees { get; set; }
        public string Filiere { get; set; }
        public string AnneeScolaire { get; set; }
        public string LibFiliere { get; set; }
        public string CodeSpecialite { get; set; }
        public string LibSpecialite { get; set; }
        public string Categorie { get; set; }
        public string FiliereNew { get; set; }
        public string SiteEsp { get; set; }
        public string CodeDept { get; set; }
        public string CodeOption { get; set; }
        public string CurrentUser { get; set; }
        public DateTime? DateAffectMc { get; set; }
        public string Mail { get; set; }
        public string Pole { get; set; }

        public virtual ICollection<EspGroupeProjet> EspGroupeProjet { get; set; }
        public virtual ICollection<EspModulePanierClasseSaiso> EspModulePanierClasseSaiso { get; set; }
        public virtual ICollection<EspSaisonClasse> EspSaisonClasse { get; set; }
        public virtual ICollection<Seance> Seance { get; set; }
    }
}
