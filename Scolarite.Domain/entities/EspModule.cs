using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspModule
    {
        public EspModule()
        {
            EspEvaluation = new HashSet<EspEvaluation>();
            EspModuleEtudiant = new HashSet<EspModuleEtudiant>();
            EspModulePanierClasseSaiso = new HashSet<EspModulePanierClasseSaiso>();
            EspMoyModuleEtudiant = new HashSet<EspMoyModuleEtudiant>();
            EspProjet = new HashSet<EspProjet>();
            EspSeanceEns = new HashSet<EspSeanceEns>();
            Groupe = new HashSet<Groupe>();
            Phase = new HashSet<Phase>();
            Projet = new HashSet<Projet>();
        }

        public string CodeModule { get; set; }
        public string Designation { get; set; }
        public string Description { get; set; }
        public decimal? NbHeures { get; set; }
        public string Etat { get; set; }
        public string Up { get; set; }
        public decimal? Coef { get; set; }
        public string NumPanier { get; set; }
        public string AEvaluer { get; set; }
        public string TypeEpreuve { get; set; }
        public string CodeMatiereEduserv { get; set; }
        public string TypeEpreuveSr { get; set; }
        public string TypeModule { get; set; }
        public string CodeUe { get; set; }
        public string AnneeDeb { get; set; }
    
     // public virtual List<EspModule> AddMoreList { get; set; }

        public virtual EspUe EspUe { get; set; }
        public virtual EspUp UpNavigation { get; set; }
        public virtual ICollection<EspEvaluation> EspEvaluation { get; set; }
        public virtual ICollection<EspModuleEtudiant> EspModuleEtudiant { get; set; }
        public virtual ICollection<EspModulePanierClasseSaiso> EspModulePanierClasseSaiso { get; set; }
        public virtual ICollection<EspMoyModuleEtudiant> EspMoyModuleEtudiant { get; set; }
        public virtual ICollection<EspProjet> EspProjet { get; set; }
        public virtual ICollection<EspSeanceEns> EspSeanceEns { get; set; }
        public virtual ICollection<Groupe> Groupe { get; set; }
        public virtual ICollection<Phase> Phase { get; set; }
        public virtual ICollection<Projet> Projet { get; set; }
    }
}
