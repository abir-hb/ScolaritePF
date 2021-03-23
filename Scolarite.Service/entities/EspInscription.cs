﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspInscription
    {
        public EspInscription()
        {
            GroupeInscription = new HashSet<GroupeInscription>();
        }

        public string AnneeDeb { get; set; }
        public string AnneeFin { get; set; }
        public string CodeCl { get; set; }
        public string IdEt { get; set; }
        public decimal? CoutAnnuel { get; set; }
        public decimal? FraisIns { get; set; }
        public string TypeRglt { get; set; }
        public string ModeRglt { get; set; }
        public string CodeDev { get; set; }
        public decimal? CoutDev { get; set; }
        public string SitRglt { get; set; }
        public decimal? CreditRglt { get; set; }
        public decimal? NbCreditModule { get; set; }
        public decimal? MoySem1 { get; set; }
        public decimal? MoySem2 { get; set; }
        public decimal? MoyGeneral { get; set; }
        public string Resultat { get; set; }
        public bool? NiveauAccees { get; set; }
        public string TypeInsc { get; set; }
        public bool? Semestre { get; set; }
        public string NivLangue { get; set; }
        public string CodeClLangue { get; set; }
        public string Utilisateur { get; set; }
        public string DernUtilisateur { get; set; }
        public DateTime? DatePreinsc { get; set; }
        public DateTime? DateInsc { get; set; }
        public string CodeCl1 { get; set; }
        public string CodeCl2 { get; set; }
        public decimal? MoyRatt { get; set; }
        public string Observation { get; set; }
        public byte? Numpromotioncs { get; set; }
        public string CodeDecisionSessionP { get; set; }
        public string LibDecisionSessionP { get; set; }
        public string CodeDecisionSessionRat { get; set; }
        public string LibDecisionSessionRat { get; set; }
        public byte? NbImpAttestReussite { get; set; }
        public DateTime? DateLastMajDecisionPrinc { get; set; }
        public DateTime? DateLastMajDecisionRatt { get; set; }
        public string CreditAnt { get; set; }
        public byte? NbImpReleve { get; set; }
        public string EtatEntretien { get; set; }
        public DateTime? DateLastModifRat2 { get; set; }
        public decimal? MoyRat2 { get; set; }
        public string CodeDecisionSessionRat2 { get; set; }
        public string LibDecisionSessionRat2 { get; set; }
        public string AdmisRach { get; set; }
        public decimal? MoyRatAvRach { get; set; }
        public string AdmisTs { get; set; }
        public DateTime? DateLimProlongRglt { get; set; }
        public string NivAcquisFrancais { get; set; }
        public bool? MajNiveauDefinitif { get; set; }
        public string Reserve { get; set; }
        public decimal? NbEctsSp { get; set; }
        public decimal? NbEctsSr { get; set; }
        public string NivAcquisAnglais { get; set; }
        public DateTime? DateTestFr { get; set; }
        public DateTime? DateTestAng { get; set; }
        public string PrepToeic { get; set; }
        public string TestToeic { get; set; }
        public string EtatInsTestNiv { get; set; }
        public string UserLangModif { get; set; }
        public byte? RangSp { get; set; }
        public byte? NumAnnuelDiplome { get; set; }
        public byte? NumAnnexe { get; set; }
        public string GroupeTarif { get; set; }
        public decimal? MoyGenAvPfe { get; set; }
        public decimal? NbEctsAvPfe { get; set; }
        public decimal? NotePfe { get; set; }
        public decimal? CoefPfe { get; set; }
        public decimal? MoyGenAvPfeSp { get; set; }
        public decimal? MoyGenAvPfeSr { get; set; }
        public bool? EtatFinancier { get; set; }
        public int? TemNum { get; set; }
        public decimal? MgSeved { get; set; }
        public string RachatUeEt { get; set; }

        public virtual EspSaisonUniversitaire AnneeDebNavigation { get; set; }
        public virtual EspSaisonClasse EspSaisonClasse { get; set; }
        public virtual ICollection<GroupeInscription> GroupeInscription { get; set; }
    }
}
