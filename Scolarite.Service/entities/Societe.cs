﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class Societe
    {
        public string CodeSoc { get; set; }
        public string NomSoc { get; set; }
        public string AdrSoc { get; set; }
        public string TelSoc { get; set; }
        public string FaxSoc { get; set; }
        public byte[] Sigle { get; set; }
        public string EMail { get; set; }
        public string CodePostal { get; set; }
        public DateTime? DateCr { get; set; }
        public DateTime? DateMaj { get; set; }
        public string Ville { get; set; }
        public string Rib { get; set; }
        public string CodeTva { get; set; }
        public string Banque { get; set; }
        public string Rc { get; set; }
        public string CodeRgltComptant { get; set; }
        public string CodeRgltEspece { get; set; }
        public string AnneeDeb { get; set; }
        public string AnneeFin { get; set; }
        public decimal? TauxExam { get; set; }
        public decimal? TauxDs { get; set; }
        public decimal? TauxTp { get; set; }
        public decimal? TauxOrale { get; set; }
        public decimal? NbMaxAbsModule { get; set; }
        public decimal? NbSceanceJour { get; set; }
        public string Symbole { get; set; }
        public decimal? TimbFiscal { get; set; }
        public decimal? TimbreFiscal { get; set; }
        public DateTime? DateDebutSaison { get; set; }
        public bool? NumSemestreActuel { get; set; }
        public string CheminFichierDonnee { get; set; }
        public decimal? TauxExamWithCc { get; set; }
        public decimal? TauxExamWithTpCc { get; set; }
        public decimal? MinMoyResussite { get; set; }
        public decimal? BiRachat { get; set; }
        public decimal? BsRachat { get; set; }
        public string IdVacataire { get; set; }
        public string GererSemestre { get; set; }
        public decimal? FrScolariteCs { get; set; }
        public decimal? FrScolariteCj { get; set; }
        public decimal? MinPanier { get; set; }
        public string IdDiret { get; set; }
        public string IdServScolaire { get; set; }
        public string LiaisonFinancier { get; set; }
        public decimal? TauxRglt { get; set; }
        public string LiaisonSite { get; set; }
        public byte? Numpromotioncs { get; set; }
        public DateTime? Datedemarragecs { get; set; }
        public string ControlBalckliste { get; set; }
        public decimal? MaxValCreditAccepte { get; set; }
        public decimal? MaxTauxCreditAccepte { get; set; }
        public decimal? CreditMax { get; set; }
        public string ActiveDispenseAuto { get; set; }
        public string ActiveMpEns { get; set; }
        public string ActiveModuleOpt { get; set; }
        public string VerrouResul { get; set; }
        public decimal? TotEctsAdmis { get; set; }
        public decimal? QuotaEctsNv { get; set; }
        public string ActiverTauxAbsence { get; set; }
        public decimal? TauxMaxAbsence { get; set; }
        public decimal? NbhSemaine { get; set; }
        public string BlockOtherRat { get; set; }
        public decimal? CtrlConformEcts { get; set; }
        public string CtrlFinStat { get; set; }
        public string VerrouPlEtude { get; set; }
        public string AnneeAdmission { get; set; }
        public string DelibResultats { get; set; }
        public string AffichNote { get; set; }
    }
}
