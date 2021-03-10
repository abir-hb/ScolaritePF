﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspSaisonClasse
    {
        public EspSaisonClasse()
        {
            EspInscription = new HashSet<EspInscription>();
            EspRemarqueAbsence = new HashSet<EspRemarqueAbsence>();
        }

        public string AnneeDeb { get; set; }
        public string AnneeFin { get; set; }
        public string CodeCl { get; set; }
        public DateTime? DateDemarrage { get; set; }
        public string Description { get; set; }
        public byte? NbEtudiant { get; set; }
        public string SallePrincipale { get; set; }
        public string SalleSecondaire1 { get; set; }
        public string SalleSecondaire2 { get; set; }
        public string Nature { get; set; }
        public string TypeClasse { get; set; }
        public bool? NbSeance { get; set; }
        public string ClasseEntreprise { get; set; }
        public bool Semestre { get; set; }
        public string ClEclate { get; set; }
        public DateTime? DateEclatement { get; set; }
        public byte? Numpromotioncs { get; set; }
        public string ClasseS2 { get; set; }
        public string CodeCls1 { get; set; }
        public string ClAvecDispense { get; set; }
        public string PvSpSaved { get; set; }
        public string PvSrSaved { get; set; }
        public bool? NiveauAcces { get; set; }
        public string Filiere { get; set; }
        public string TypePv { get; set; }

        public virtual EspSaisonUniversitaire AnneeDebNavigation { get; set; }
        public virtual Classe CodeClNavigation { get; set; }
        public virtual ICollection<EspInscription> EspInscription { get; set; }
        public virtual ICollection<EspRemarqueAbsence> EspRemarqueAbsence { get; set; }
    }
}
