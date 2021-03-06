using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspEtudiant
    {
        public string IdEt { get; set; }
        public string NomEt { get; set; }
        public string PnomEt { get; set; }
        public DateTime? DateNaisEt { get; set; }
        public string LieuNaisEt { get; set; }
        public string NatureEt { get; set; }
        public string FonctionEt { get; set; }
        public string AdresseEt { get; set; }
        public string TelEt { get; set; }
        public string TelParentEt { get; set; }
        public string EMailEt { get; set; }
        public string CycleEt { get; set; }
        public string NatureBac { get; set; }
        public DateTime? DateBac { get; set; }
        public string NumBacEt { get; set; }
        public string EtabBac { get; set; }
        public string DiplomeSupEt { get; set; }
        public decimal? NiveauDiplomeSupEt { get; set; }
        public string EtabOrigine { get; set; }
        public string SpecialiteEspEt { get; set; }
        public DateTime? DateEntreeEspEt { get; set; }
        public string AnneeEntreeEspEt { get; set; }
        public string ClasseCouranteEt { get; set; }
        public string SituationFinanciereEt { get; set; }
        public bool? NiveauCourantEt { get; set; }
        public decimal? MoyenneDernSemestreEt { get; set; }
        public string ResultatFinalEt { get; set; }
        public string DiplomeObtenuEspEt { get; set; }
        public DateTime? DateSortieEt { get; set; }
        public string ObservationEt { get; set; }
        public string Sexe { get; set; }
        public string Nationalite { get; set; }
        public string NumCinPasseport { get; set; }
        public DateTime? DateSaisie { get; set; }
        public DateTime? DateDernModif { get; set; }
        public string Agent { get; set; }
        public string NumOrd { get; set; }
        public DateTime? DateDelivrance { get; set; }
        public string LieuDelivrance { get; set; }
        public bool? NiveauAcces { get; set; }
        public string NatureCours { get; set; }
        public string NaturePieceId { get; set; }
        public string AdresseParent { get; set; }
        public string CpParent { get; set; }
        public string VilleParent { get; set; }
        public string PaysParent { get; set; }
        public string CpEt { get; set; }
        public string VilleEt { get; set; }
        public string PaysEt { get; set; }
        public string EMailParent { get; set; }
        public string TelParent { get; set; }
        public string TypeEnregEt { get; set; }
        public string DateLieuNais { get; set; }
        public string CodeEtabOrigine { get; set; }
        public string CodeSpecOrigine { get; set; }
        public string LibSpecOrigine { get; set; }
        public string ClassePrecEt { get; set; }
        public string IdEtOrigin { get; set; }
        public string Etat { get; set; }
        public string JustifEtat { get; set; }
        public string LibJustifEtat { get; set; }
        public string IdEtNew { get; set; }
        public string IdEtOrigine { get; set; }
        public DateTime? DateLastChangeEtat { get; set; }
        public string DernUtilisateur { get; set; }
        public string Numcompte { get; set; }
        public string Banque { get; set; }
        public string RibBanque { get; set; }
        public string Mp08 { get; set; }
        public string TypeEt { get; set; }
        public string CodeNationalite { get; set; }
        public byte? Numpromotioncs { get; set; }
        public string CodeDecisionSessionPAp1 { get; set; }
        public string LibDecisionSessionPAp1 { get; set; }
        public string CodeDecisionSessionRAp1 { get; set; }
        public string LibDecisionSessionRAp1 { get; set; }
        public string CodeDecisionSessionPAp2 { get; set; }
        public string LibDecisionSessionPAp2 { get; set; }
        public string CodeDecisionSessionRAp2 { get; set; }
        public string LibDecisionSessionRAp2 { get; set; }
        public string CodeDecisionSessionPAp3 { get; set; }
        public string LibDecisionSessionPAp3 { get; set; }
        public string CodeDecisionSessionRAp3 { get; set; }
        public string LibDecisionSessionRAp3 { get; set; }
        public decimal? MoyPAp1 { get; set; }
        public decimal? MoyRAp1 { get; set; }
        public decimal? MoyPAp2 { get; set; }
        public decimal? MoyRAp2 { get; set; }
        public decimal? MoyPAp3 { get; set; }
        public decimal? MoyRAp3 { get; set; }
        public byte? NbImpReleve { get; set; }
        public string CodeBarre { get; set; }
        public string MoyBacEt { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FonctionPereEt { get; set; }
        public string FonctionMereEt { get; set; }
        public string TelMereEt { get; set; }
        public string TelPereEt { get; set; }
        public string EmailPereEt { get; set; }
        public string EmailMereEt { get; set; }
        public string NomPereEt { get; set; }
        public string NomMereEt { get; set; }
        public string AnneeBac { get; set; }
        public string AnneeDiplome { get; set; }
        public decimal? MoyBacEt2 { get; set; }
        public decimal? EntretienAnglais { get; set; }
        public decimal? EntretienFrancais { get; set; }
        public string EnsIdEns { get; set; }
        public int? ComiteIdGrp { get; set; }
        public string FkEns { get; set; }
        public string FkEnsei { get; set; }
        public decimal? TelEt1 { get; set; }
        public decimal? MoyBac { get; set; }
        public string FilierePrepa { get; set; }
        public string LibFilierePrepa { get; set; }
        public string Dateentr { get; set; }
        public decimal ScoreFinal { get; set; }
        public decimal? ScoreMinAdmin { get; set; }
        public string UserTransfPreinscrit { get; set; }
        public DateTime? DateTransfPreinscrit { get; set; }
        public bool? NumLot { get; set; }
        public string Recommandation { get; set; }
        public string Gouvernorat { get; set; }
        public string AdresseMailEsp { get; set; }
        public string PwdEt { get; set; }
        public string PwdEtInit { get; set; }
        public string SuiviParticulier { get; set; }
        public string NiveauCourantAng { get; set; }
        public string NiveauCourantFr { get; set; }
        public string NomArb { get; set; }
        public string PnomArb { get; set; }
        public string LieuNaisArb { get; set; }
        public string NatureBacArb { get; set; }
        public string DiplomeSupArb { get; set; }
        public string EtabOrigineArb { get; set; }
        public string IdEleveEduserv { get; set; }
        public string PwdParent { get; set; }
        public byte? NumAnnuelDiplome { get; set; }
        public byte? NumAnnexe { get; set; }
        public string Orientation { get; set; }
        public string GroupeTarif { get; set; }
        public string CatEtabOrigine { get; set; }
        public string EtabOriginNew { get; set; }
        public string CodeRfid { get; set; }
        public string DateHeureCreation { get; set; }
        public string OraRowscn { get; set; }
        public string ChoixAB { get; set; }
        public string CodeGouvernorat { get; set; }
    }
}
