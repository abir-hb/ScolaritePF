using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Scolarite.Domain.entities
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Champ> Champ { get; set; }
        public virtual DbSet<ChampStr> ChampStr { get; set; }
        public virtual DbSet<Classe> Classe { get; set; }
        public virtual DbSet<Classe3> Classe3 { get; set; }
        public virtual DbSet<Classes1516> Classes1516 { get; set; }
        public virtual DbSet<CodeNomenclature> CodeNomenclature { get; set; }
        public virtual DbSet<Comite> Comite { get; set; }
        public virtual DbSet<ComiteSpecialite> ComiteSpecialite { get; set; }
        public virtual DbSet<Comitevalidation> Comitevalidation { get; set; }
        public virtual DbSet<Commentaire> Commentaire { get; set; }
        public virtual DbSet<ComptCert> ComptCert { get; set; }
        public virtual DbSet<Compteur> Compteur { get; set; }
        public virtual DbSet<ConMoy0605> ConMoy0605 { get; set; }
        public virtual DbSet<CreditFinal> CreditFinal { get; set; }
        public virtual DbSet<Criterion> Criterion { get; set; }
        public virtual DbSet<CriterionDetail> CriterionDetail { get; set; }
        public virtual DbSet<Decid> Decid { get; set; }
        public virtual DbSet<DetailSeance> DetailSeance { get; set; }
        public virtual DbSet<Diplome1617> Diplome1617 { get; set; }
        public virtual DbSet<Emp> Emp { get; set; }
        public virtual DbSet<EnsVaca> EnsVaca { get; set; }
        public virtual DbSet<EnteteReclamation> EnteteReclamation { get; set; }
        public virtual DbSet<EspANiveau> EspANiveau { get; set; }
        public virtual DbSet<EspAbsNotTransSite> EspAbsNotTransSite { get; set; }
        public virtual DbSet<EspAbscence> EspAbscence { get; set; }
        public virtual DbSet<EspAbsence> EspAbsence { get; set; }
        public virtual DbSet<EspAbsenceEnseignant> EspAbsenceEnseignant { get; set; }
        public virtual DbSet<EspAbsenceList> EspAbsenceList { get; set; }
        public virtual DbSet<EspAbsenceNew> EspAbsenceNew { get; set; }
        public virtual DbSet<EspAbsenceTmp> EspAbsenceTmp { get; set; }
        public virtual DbSet<EspAcquisChapter> EspAcquisChapter { get; set; }
        public virtual DbSet<EspAcquisModule> EspAcquisModule { get; set; }
        public virtual DbSet<EspAcquisValidEns> EspAcquisValidEns { get; set; }
        public virtual DbSet<EspAdmission> EspAdmission { get; set; }
        public virtual DbSet<EspAdreeseMailEtudiant> EspAdreeseMailEtudiant { get; set; }
        public virtual DbSet<EspAdresseMailEspEtudiant> EspAdresseMailEspEtudiant { get; set; }
        public virtual DbSet<EspAffGroupEtudiant> EspAffGroupEtudiant { get; set; }
        public virtual DbSet<EspAffectationEmploi> EspAffectationEmploi { get; set; }
        public virtual DbSet<EspAppreciation> EspAppreciation { get; set; }
        public virtual DbSet<EspArchivageEtudiant> EspArchivageEtudiant { get; set; }
        public virtual DbSet<EspAssRubEtIns> EspAssRubEtIns { get; set; }
        public virtual DbSet<EspAuditAdmission> EspAuditAdmission { get; set; }
        public virtual DbSet<EspAuditChangeClasse> EspAuditChangeClasse { get; set; }
        public virtual DbSet<EspAuditChangeEnseignant> EspAuditChangeEnseignant { get; set; }
        public virtual DbSet<EspAuditConnexion> EspAuditConnexion { get; set; }
        public virtual DbSet<EspAuditCredit> EspAuditCredit { get; set; }
        public virtual DbSet<EspAuditFailedEns> EspAuditFailedEns { get; set; }
        public virtual DbSet<EspAuditLibDecisionpR> EspAuditLibDecisionpR { get; set; }
        public virtual DbSet<EspAuditModifPlan> EspAuditModifPlan { get; set; }
        public virtual DbSet<EspAuditSociete> EspAuditSociete { get; set; }
        public virtual DbSet<EspBilanPrepa> EspBilanPrepa { get; set; }
        public virtual DbSet<EspBlacklist> EspBlacklist { get; set; }
        public virtual DbSet<EspCahierClasse> EspCahierClasse { get; set; }
        public virtual DbSet<EspCahierDeTexte> EspCahierDeTexte { get; set; }
        public virtual DbSet<EspCalcul> EspCalcul { get; set; }
        public virtual DbSet<EspCandForm> EspCandForm { get; set; }
        public virtual DbSet<EspCcna> EspCcna { get; set; }
        public virtual DbSet<EspCertif> EspCertif { get; set; }
        public virtual DbSet<EspChoix> EspChoix { get; set; }
        public virtual DbSet<EspCompteur> EspCompteur { get; set; }
        public virtual DbSet<EspContrat> EspContrat { get; set; }
        public virtual DbSet<EspConvocation> EspConvocation { get; set; }
        public virtual DbSet<EspCoordinateur> EspCoordinateur { get; set; }
        public virtual DbSet<EspCorEtab> EspCorEtab { get; set; }
        public virtual DbSet<EspCorrespEt> EspCorrespEt { get; set; }
        public virtual DbSet<EspCorrespIdetCompte> EspCorrespIdetCompte { get; set; }
        public virtual DbSet<EspCreditPanier> EspCreditPanier { get; set; }
        public virtual DbSet<EspCreditUeSp> EspCreditUeSp { get; set; }
        public virtual DbSet<EspCreditUeSp4eme> EspCreditUeSp4eme { get; set; }
        public virtual DbSet<EspCritereEval> EspCritereEval { get; set; }
        public virtual DbSet<EspDept> EspDept { get; set; }
        public virtual DbSet<EspDerogation> EspDerogation { get; set; }
        public virtual DbSet<EspDetailContrat> EspDetailContrat { get; set; }
        public virtual DbSet<EspDioplome2018> EspDioplome2018 { get; set; }
        public virtual DbSet<EspDiplome2017> EspDiplome2017 { get; set; }
        public virtual DbSet<EspDirection> EspDirection { get; set; }
        public virtual DbSet<EspDispenseEtudiant> EspDispenseEtudiant { get; set; }
        public virtual DbSet<EspDisponibiliteEns> EspDisponibiliteEns { get; set; }
        public virtual DbSet<EspDsExam> EspDsExam { get; set; }
        public virtual DbSet<EspEncadProjetRq> EspEncadProjetRq { get; set; }
        public virtual DbSet<EspEncadrement> EspEncadrement { get; set; }
        public virtual DbSet<EspEncadrement1> EspEncadrement1 { get; set; }
        public virtual DbSet<EspEncadrementGp> EspEncadrementGp { get; set; }
        public virtual DbSet<EspEnseignant> EspEnseignant { get; set; }
        public virtual DbSet<EspEnseignantFichepfe> EspEnseignantFichepfe { get; set; }
        public virtual DbSet<EspEnteteAbsence> EspEnteteAbsence { get; set; }
        public virtual DbSet<EspEnteteNote> EspEnteteNote { get; set; }
        public virtual DbSet<EspEnteteNoteRat> EspEnteteNoteRat { get; set; }
        public virtual DbSet<EspEtNotTransfFin> EspEtNotTransfFin { get; set; }
        public virtual DbSet<EspEtatNav> EspEtatNav { get; set; }
        public virtual DbSet<EspEtatNavTmp1> EspEtatNavTmp1 { get; set; }
        public virtual DbSet<EspEtatSolde> EspEtatSolde { get; set; }
        public virtual DbSet<EspEtudiant> EspEtudiant { get; set; }
        public virtual DbSet<EspEtudiant2013> EspEtudiant2013 { get; set; }
        public virtual DbSet<EspEtudiantEnreg> EspEtudiantEnreg { get; set; }
        public virtual DbSet<EspEtudiantNoteGroupe> EspEtudiantNoteGroupe { get; set; }
        public virtual DbSet<EspEtudiantSeminaire> EspEtudiantSeminaire { get; set; }
        public virtual DbSet<EspEtudiantTmp> EspEtudiantTmp { get; set; }
        public virtual DbSet<EspEtudiantsDiplomes> EspEtudiantsDiplomes { get; set; }
        public virtual DbSet<EspEvalClModule> EspEvalClModule { get; set; }
        public virtual DbSet<EspEvalExamen> EspEvalExamen { get; set; }
        public virtual DbSet<EspEvaluation> EspEvaluation { get; set; }
        public virtual DbSet<EspEvaluationPrepa> EspEvaluationPrepa { get; set; }
        public virtual DbSet<EspEventCalendar> EspEventCalendar { get; set; }
        public virtual DbSet<EspExamen> EspExamen { get; set; }
        public virtual DbSet<EspFiliere> EspFiliere { get; set; }
        public virtual DbSet<EspFormateur> EspFormateur { get; set; }
        public virtual DbSet<EspFormation> EspFormation { get; set; }
        public virtual DbSet<EspGoogleMeet> EspGoogleMeet { get; set; }
        public virtual DbSet<EspGoogleUsers> EspGoogleUsers { get; set; }
        public virtual DbSet<EspGpProjet> EspGpProjet { get; set; }
        public virtual DbSet<EspGroupeMail> EspGroupeMail { get; set; }
        public virtual DbSet<EspGroupeProjet> EspGroupeProjet { get; set; }
        public virtual DbSet<EspGroupeTarif> EspGroupeTarif { get; set; }
        public virtual DbSet<EspIdMoodle> EspIdMoodle { get; set; }
        public virtual DbSet<EspImportscore> EspImportscore { get; set; }
        public virtual DbSet<EspInscri> EspInscri { get; set; }
        public virtual DbSet<EspInscription> EspInscription { get; set; }
        public virtual DbSet<EspInscriptionRat> EspInscriptionRat { get; set; }
        public virtual DbSet<EspIntern170818> EspIntern170818 { get; set; }
        public virtual DbSet<EspJournalEtudiant> EspJournalEtudiant { get; set; }
        public virtual DbSet<EspJournalInscription> EspJournalInscription { get; set; }
        public virtual DbSet<EspJournalMdpEns> EspJournalMdpEns { get; set; }
        public virtual DbSet<EspJournalNivLanguesEtud> EspJournalNivLanguesEtud { get; set; }
        public virtual DbSet<EspJournalNote> EspJournalNote { get; set; }
        public virtual DbSet<EspJournalOpRubrique> EspJournalOpRubrique { get; set; }
        public virtual DbSet<EspJournalRglt> EspJournalRglt { get; set; }
        public virtual DbSet<EspMailEnseignant> EspMailEnseignant { get; set; }
        public virtual DbSet<EspMatriculeNumEt> EspMatriculeNumEt { get; set; }
        public virtual DbSet<EspModule> EspModule { get; set; }
        public virtual DbSet<EspModule0818> EspModule0818 { get; set; }
        public virtual DbSet<EspModuleEtudiant> EspModuleEtudiant { get; set; }
        public virtual DbSet<EspModulePanierClasseSaiso> EspModulePanierClasseSaiso { get; set; }
        public virtual DbSet<EspMoyModuleEtSemestriel> EspMoyModuleEtSemestriel { get; set; }
        public virtual DbSet<EspMoyModuleEtudiant> EspMoyModuleEtudiant { get; set; }
        public virtual DbSet<EspMoyPanierEtudiant> EspMoyPanierEtudiant { get; set; }
        public virtual DbSet<EspMoyUeEtudiant> EspMoyUeEtudiant { get; set; }
        public virtual DbSet<EspNiveauLangue> EspNiveauLangue { get; set; }
        public virtual DbSet<EspNote> EspNote { get; set; }
        public virtual DbSet<EspNoteAnglaisS2> EspNoteAnglaisS2 { get; set; }
        public virtual DbSet<EspNoteFrancaisS2> EspNoteFrancaisS2 { get; set; }
        public virtual DbSet<EspNoteQiS2New> EspNoteQiS2New { get; set; }
        public virtual DbSet<EspNoteRat> EspNoteRat { get; set; }
        public virtual DbSet<EspObservationEnseignant> EspObservationEnseignant { get; set; }
        public virtual DbSet<EspObservationEtudiant> EspObservationEtudiant { get; set; }
        public virtual DbSet<EspOption> EspOption { get; set; }
        public virtual DbSet<EspOrientation> EspOrientation { get; set; }
        public virtual DbSet<EspParametre> EspParametre { get; set; }
        public virtual DbSet<EspPrevision> EspPrevision { get; set; }
        public virtual DbSet<EspProjet> EspProjet { get; set; }
        public virtual DbSet<EspProjetEtudiant> EspProjetEtudiant { get; set; }
        public virtual DbSet<EspProjetN> EspProjetN { get; set; }
        public virtual DbSet<EspProjetNew> EspProjetNew { get; set; }
        public virtual DbSet<EspPvClasse> EspPvClasse { get; set; }
        public virtual DbSet<EspRdi> EspRdi { get; set; }
        public virtual DbSet<EspRealise> EspRealise { get; set; }
        public virtual DbSet<EspReclamation> EspReclamation { get; set; }
        public virtual DbSet<EspReglementOnline> EspReglementOnline { get; set; }
        public virtual DbSet<EspRemarqueAbsence> EspRemarqueAbsence { get; set; }
        public virtual DbSet<EspRepassageExam> EspRepassageExam { get; set; }
        public virtual DbSet<EspResponsableModule> EspResponsableModule { get; set; }
        public virtual DbSet<EspReunionRdi> EspReunionRdi { get; set; }
        public virtual DbSet<EspRubrique> EspRubrique { get; set; }
        public virtual DbSet<EspSaisonClasse> EspSaisonClasse { get; set; }
        public virtual DbSet<EspSaisonUniversitaire> EspSaisonUniversitaire { get; set; }
        public virtual DbSet<EspSalleClasse> EspSalleClasse { get; set; }
        public virtual DbSet<EspSalleDispo> EspSalleDispo { get; set; }
        public virtual DbSet<EspSalleExamen> EspSalleExamen { get; set; }
        public virtual DbSet<EspSatisfaction> EspSatisfaction { get; set; }
        public virtual DbSet<EspScoreSpecialite> EspScoreSpecialite { get; set; }
        public virtual DbSet<EspSeanceEns> EspSeanceEns { get; set; }
        public virtual DbSet<EspSeanceExamen> EspSeanceExamen { get; set; }
        public virtual DbSet<EspServEtdNavMirror> EspServEtdNavMirror { get; set; }
        public virtual DbSet<EspServNavMirror> EspServNavMirror { get; set; }
        public virtual DbSet<EspServiceEtudiantNav> EspServiceEtudiantNav { get; set; }
        public virtual DbSet<EspSession> EspSession { get; set; }
        public virtual DbSet<EspStage5eme> EspStage5eme { get; set; }
        public virtual DbSet<EspStageEte02> EspStageEte02 { get; set; }
        public virtual DbSet<EspStageEteEm> EspStageEteEm { get; set; }
        public virtual DbSet<EspStageEteGc> EspStageEteGc { get; set; }
        public virtual DbSet<EspStageEteLc> EspStageEteLc { get; set; }
        public virtual DbSet<EspSuiviProjetIndiv> EspSuiviProjetIndiv { get; set; }
        public virtual DbSet<EspSurveillantDispo> EspSurveillantDispo { get; set; }
        public virtual DbSet<EspSurveillantExamen> EspSurveillantExamen { get; set; }
        public virtual DbSet<EspTabPlanSalle> EspTabPlanSalle { get; set; }
        public virtual DbSet<EspTarifRubrique> EspTarifRubrique { get; set; }
        public virtual DbSet<EspTeacherClassroom> EspTeacherClassroom { get; set; }
        public virtual DbSet<EspTempEtudiantEnreg> EspTempEtudiantEnreg { get; set; }
        public virtual DbSet<EspTempEx> EspTempEx { get; set; }
        public virtual DbSet<EspTempEx2> EspTempEx2 { get; set; }
        public virtual DbSet<EspTempEx3> EspTempEx3 { get; set; }
        public virtual DbSet<EspTempEx4> EspTempEx4 { get; set; }
        public virtual DbSet<EspTempEx5> EspTempEx5 { get; set; }
        public virtual DbSet<EspTempEx6> EspTempEx6 { get; set; }
        public virtual DbSet<EspTempModifClasse> EspTempModifClasse { get; set; }
        public virtual DbSet<EspTempOrien> EspTempOrien { get; set; }
        public virtual DbSet<EspTempOrientation> EspTempOrientation { get; set; }
        public virtual DbSet<EspTempScore> EspTempScore { get; set; }
        public virtual DbSet<EspTestEns> EspTestEns { get; set; }
        public virtual DbSet<EspTestEtud> EspTestEtud { get; set; }
        public virtual DbSet<EspTicketInscription> EspTicketInscription { get; set; }
        public virtual DbSet<EspTmpApp> EspTmpApp { get; set; }
        public virtual DbSet<EspTmpOrientation2018> EspTmpOrientation2018 { get; set; }
        public virtual DbSet<EspTmpSimulRachat> EspTmpSimulRachat { get; set; }
        public virtual DbSet<EspToeicNb> EspToeicNb { get; set; }
        public virtual DbSet<EspTraceCorrectNumcpt> EspTraceCorrectNumcpt { get; set; }
        public virtual DbSet<EspTraceImpPiece> EspTraceImpPiece { get; set; }
        public virtual DbSet<EspTransportEt> EspTransportEt { get; set; }
        public virtual DbSet<EspTrvCours> EspTrvCours { get; set; }
        public virtual DbSet<EspTrvQuot> EspTrvQuot { get; set; }
        public virtual DbSet<EspUe> EspUe { get; set; }
        public virtual DbSet<EspUe5emetelinfo> EspUe5emetelinfo { get; set; }
        public virtual DbSet<EspUp> EspUp { get; set; }
        public virtual DbSet<EspWhiteList> EspWhiteList { get; set; }
        public virtual DbSet<EspritNavcustomersco> EspritNavcustomersco { get; set; }
        public virtual DbSet<EspritNew> EspritNew { get; set; }
        public virtual DbSet<EtDiplomeNew> EtDiplomeNew { get; set; }
        public virtual DbSet<EtatPaiement> EtatPaiement { get; set; }
        public virtual DbSet<Etud> Etud { get; set; }
        public virtual DbSet<EtudiantRatt2016> EtudiantRatt2016 { get; set; }
        public virtual DbSet<Fichepfe> Fichepfe { get; set; }
        public virtual DbSet<FormRate> FormRate { get; set; }
        public virtual DbSet<FormaEval> FormaEval { get; set; }
        public virtual DbSet<FrCursus> FrCursus { get; set; }
        public virtual DbSet<Groupe> Groupe { get; set; }
        public virtual DbSet<GroupeInscription> GroupeInscription { get; set; }
        public virtual DbSet<Groupuser> Groupuser { get; set; }
        public virtual DbSet<HistoriquePaiement> HistoriquePaiement { get; set; }
        public virtual DbSet<IdApprec> IdApprec { get; set; }
        public virtual DbSet<IdChoice> IdChoice { get; set; }
        public virtual DbSet<IdMeet> IdMeet { get; set; }
        public virtual DbSet<IdResume> IdResume { get; set; }
        public virtual DbSet<IdStuden> IdStuden { get; set; }
        public virtual DbSet<IdUtilis> IdUtilis { get; set; }
        public virtual DbSet<Jeton> Jeton { get; set; }
        public virtual DbSet<Mapdsex161711Ghazala> Mapdsex161711Ghazala { get; set; }
        public virtual DbSet<Mapx161711Ghazala> Mapx161711Ghazala { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Miseajour> Miseajour { get; set; }
        public virtual DbSet<Noteseminaire> Noteseminaire { get; set; }
        public virtual DbSet<Pbcatcol> Pbcatcol { get; set; }
        public virtual DbSet<Pbcatedt> Pbcatedt { get; set; }
        public virtual DbSet<Pbcatfmt> Pbcatfmt { get; set; }
        public virtual DbSet<Pbcattbl> Pbcattbl { get; set; }
        public virtual DbSet<Pbcatvld> Pbcatvld { get; set; }
        public virtual DbSet<Phase> Phase { get; set; }
        public virtual DbSet<PlanTable> PlanTable { get; set; }
        public virtual DbSet<Presidentjury> Presidentjury { get; set; }
        public virtual DbSet<Presoutenance> Presoutenance { get; set; }
        public virtual DbSet<Projet> Projet { get; set; }
        public virtual DbSet<PvDiplome201805> PvDiplome201805 { get; set; }
        public virtual DbSet<PvDiplome201901> PvDiplome201901 { get; set; }
        public virtual DbSet<Quitus> Quitus { get; set; }
        public virtual DbSet<Reclamationn> Reclamationn { get; set; }
        public virtual DbSet<Resume> Resume { get; set; }
        public virtual DbSet<Salle> Salle { get; set; }
        public virtual DbSet<SansPhoto> SansPhoto { get; set; }
        public virtual DbSet<Seance> Seance { get; set; }
        public virtual DbSet<Semestre> Semestre { get; set; }
        public virtual DbSet<Seminaire> Seminaire { get; set; }
        public virtual DbSet<Sequence> Sequence { get; set; }
        public virtual DbSet<ServiceEnseignant> ServiceEnseignant { get; set; }
        public virtual DbSet<Sessionetudiant> Sessionetudiant { get; set; }
        public virtual DbSet<Sessionpresoutenance> Sessionpresoutenance { get; set; }
        public virtual DbSet<Sessionsoutenance> Sessionsoutenance { get; set; }
        public virtual DbSet<Societe> Societe { get; set; }
        public virtual DbSet<Soutenance> Soutenance { get; set; }
        public virtual DbSet<Specialite> Specialite { get; set; }
        public virtual DbSet<StrNome> StrNome { get; set; }
        public virtual DbSet<TableImport> TableImport { get; set; }
        public virtual DbSet<TempAli> TempAli { get; set; }
        public virtual DbSet<TempCreditTic> TempCreditTic { get; set; }
        public virtual DbSet<Tes> Tes { get; set; }
        public virtual DbSet<TmpCorrectionCl> TmpCorrectionCl { get; set; }
        public virtual DbSet<TmpDiplome17anx2> TmpDiplome17anx2 { get; set; }
        public virtual DbSet<TmpEcoleOrigine> TmpEcoleOrigine { get; set; }
        public virtual DbSet<TmpEns> TmpEns { get; set; }
        public virtual DbSet<TmpOreintation2> TmpOreintation2 { get; set; }
        public virtual DbSet<TmpOrientation> TmpOrientation { get; set; }
        public virtual DbSet<TmpResultatEtud> TmpResultatEtud { get; set; }
        public virtual DbSet<TmpSoldeEtud2> TmpSoldeEtud2 { get; set; }
        public virtual DbSet<TmpTelephone> TmpTelephone { get; set; }
        public virtual DbSet<TypeMvt> TypeMvt { get; set; }
        public virtual DbSet<Up> Up { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));User Id=scopfeS;Password=esprit;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "SCOPFES");

            modelBuilder.Entity<Champ>(entity =>
            {
                entity.HasKey(e => new { e.CodeStr, e.CodeNome, e.CodeChamp });

                entity.ToTable("CHAMP");

                entity.Property(e => e.CodeStr)
                    .HasColumnName("CODE_STR")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeNome)
                    .HasColumnName("CODE_NOME")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodeChamp)
                    .HasColumnName("CODE_CHAMP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ChaCodeStr)
                    .HasColumnName("CHA_CODE_STR")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Valeur)
                    .HasColumnName("VALEUR")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChampStr>(entity =>
            {
                entity.HasKey(e => new { e.CodeStr, e.CodeChamp });

                entity.ToTable("CHAMP_STR");

                entity.Property(e => e.CodeStr)
                    .HasColumnName("CODE_STR")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeChamp)
                    .HasColumnName("CODE_CHAMP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MasqueChamp)
                    .HasColumnName("MASQUE_CHAMP")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NomChamp)
                    .HasColumnName("NOM_CHAMP")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Classe>(entity =>
            {
                entity.HasKey(e => e.CodeCl);

                entity.ToTable("CLASSE");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeScolaire)
                    .HasColumnName("ANNEE_SCOLAIRE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Categorie)
                    .HasColumnName("CATEGORIE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDept)
                    .HasColumnName("CODE_DEPT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeOption)
                    .HasColumnName("CODE_OPTION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeSpecialite)
                    .HasColumnName("CODE_SPECIALITE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentUser)
                    .HasColumnName("CURRENT_USER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateAffectMc)
                    .HasColumnName("DATE_AFFECT_MC")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.DateCr)
                    .HasColumnName("DATE_CR")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateDernModif)
                    .HasColumnName("DATE_DERN_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.DescriptionCl)
                    .HasColumnName("DESCRIPTION_CL")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Filiere)
                    .HasColumnName("FILIERE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FiliereNew)
                    .HasColumnName("FILIERE_NEW")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LibFiliere)
                    .HasColumnName("LIB_FILIERE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LibSpecialite)
                    .HasColumnName("LIB_SPECIALITE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LibelleCl)
                    .HasColumnName("LIBELLE_CL")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasColumnName("MAIL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NiveauAccees).HasColumnName("NIVEAU_ACCEES");

                entity.Property(e => e.Pole)
                    .HasColumnName("POLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SallePrincipale)
                    .HasColumnName("SALLE_PRINCIPALE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalleSecondaire2)
                    .HasColumnName("SALLE_SECONDAIRE_2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelleSecondaire1)
                    .HasColumnName("SELLE_SECONDAIRE_1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SiteEsp)
                    .HasColumnName("SITE_ESP")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Classe3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLASSE3");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasColumnType("FLOAT");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(255);

                entity.Property(e => e.Niveau)
                    .HasColumnName("NIVEAU")
                    .HasMaxLength(255);

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(255);

                entity.Property(e => e.Specialite)
                    .HasColumnName("SPECIALITE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Classes1516>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLASSES1516");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'2016' ");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Niveau)
                    .HasColumnName("NIVEAU")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Page)
                    .HasColumnName("PAGE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Specialite)
                    .HasColumnName("SPECIALITE")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CodeNomenclature>(entity =>
            {
                entity.HasKey(e => new { e.CodeStr, e.CodeNome });

                entity.ToTable("CODE_NOMENCLATURE");

                entity.Property(e => e.CodeStr)
                    .HasColumnName("CODE_STR")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeNome)
                    .HasColumnName("CODE_NOME")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LibNome)
                    .HasColumnName("LIB_NOME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comite>(entity =>
            {
                entity.HasKey(e => e.IdGrp)
                    .HasName("SYS_C0011245");

                entity.ToTable("COMITE");

                entity.Property(e => e.IdGrp)
                    .HasColumnName("ID_GRP")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dateethour)
                    .HasColumnName("DATEETHOUR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NomSpecialite)
                    .HasColumnName("NOM_SPECIALITE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Salle)
                    .HasColumnName("SALLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComiteSpecialite>(entity =>
            {
                entity.HasKey(e => new { e.ComiteIdGrp, e.SptsId })
                    .HasName("SYS_C0011252");

                entity.ToTable("COMITE_SPECIALITE");

                entity.HasIndex(e => e.SptsId)
                    .HasName("SYS_C0011254")
                    .IsUnique();

                entity.Property(e => e.ComiteIdGrp).HasColumnName("COMITE_ID_GRP");

                entity.Property(e => e.SptsId).HasColumnName("SPTS_ID");
            });

            modelBuilder.Entity<Comitevalidation>(entity =>
            {
                entity.HasKey(e => e.Idcomitevalidation)
                    .HasName("SYS_C0011248");

                entity.ToTable("COMITEVALIDATION");

                entity.Property(e => e.Idcomitevalidation)
                    .HasColumnName("IDCOMITEVALIDATION")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Specialite)
                    .HasColumnName("SPECIALITE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Commentaire>(entity =>
            {
                entity.HasKey(e => e.IdCommentaire)
                    .HasName("SYS_C0011258");

                entity.ToTable("COMMENTAIRE");

                entity.Property(e => e.IdCommentaire)
                    .HasColumnName("ID_COMMENTAIRE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Absence).HasColumnName("ABSENCE");

                entity.Property(e => e.CommentaireText)
                    .HasColumnName("COMMENTAIRE_TEXT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EtdIdEt)
                    .HasColumnName("ETD_ID_ET")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComptCert>(entity =>
            {
                entity.HasKey(e => new { e.Cpt, e.DateCert, e.Heure })
                    .HasName("PK_COMPT");

                entity.ToTable("COMPT_CERT");

                entity.Property(e => e.Cpt)
                    .HasColumnName("CPT")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateCert)
                    .HasColumnName("DATE_CERT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Heure)
                    .HasColumnName("HEURE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCert)
                    .HasColumnName("TYPE_CERT")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Compteur>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COMPTEUR");

                entity.Property(e => e.CodeCpt)
                    .HasColumnName("CODE_CPT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DateCr)
                    .HasColumnName("DATE_CR")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateLastModif)
                    .HasColumnName("DATE_LAST_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.LibCpt)
                    .HasColumnName("LIB_CPT")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConMoy0605>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CON_MOY_0605");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasColumnType("CHAR(255)");

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .HasColumnType("CHAR(255)");
            });

            modelBuilder.Entity<CreditFinal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CREDIT_FINAL");

                entity.Property(e => e.AdresseMailEsp)
                    .HasColumnName("ADRESSE_MAIL_ESP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Anglais)
                    .HasColumnName("ANGLAIS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ClasseActuelle)
                    .HasColumnName("CLASSE_ACTUELLE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClasseCredit)
                    .HasColumnName("CLASSE_CREDIT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .IsRequired()
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasColumnName("DESIGNATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FrançAis)
                    .HasColumnName("FRANçAIS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LibUe)
                    .HasColumnName("LIB_UE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MoyUe)
                    .HasColumnName("MOY_UE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM")
                    .HasMaxLength(71)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<Criterion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRITERION");

                entity.Property(e => e.Codecrt).HasColumnName("CODECRT");

                entity.Property(e => e.Libellecrt)
                    .HasColumnName("LIBELLECRT")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CriterionDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRITERION_DETAIL");

                entity.Property(e => e.CodeNom).HasColumnName("CODE_NOM");

                entity.Property(e => e.Codecrt).HasColumnName("CODECRT");

                entity.Property(e => e.LibelleNom)
                    .HasColumnName("LIBELLE_NOM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Specify)
                    .HasColumnName("SPECIFY")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Decid>(entity =>
            {
                entity.HasKey(e => e.IdDecid)
                    .HasName("CONSTRAINT1");

                entity.ToTable("DECID");

                entity.Property(e => e.IdDecid)
                    .HasColumnName("ID_DECID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtatDecid)
                    .HasColumnName("ETAT_DECID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomDecid)
                    .HasColumnName("NOM_DECID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PwdDecid)
                    .IsRequired()
                    .HasColumnName("PWD_DECID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TitreDecid)
                    .HasColumnName("TITRE_DECID")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetailSeance>(entity =>
            {
                entity.HasKey(e => e.IdDetailSeance)
                    .HasName("DETAIL_SEANCE_PK");

                entity.ToTable("DETAIL_SEANCE");

                entity.Property(e => e.IdDetailSeance)
                    .HasColumnName("ID_DETAIL_SEANCE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateModif)
                    .HasColumnName("DATE_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEns)
                    .IsRequired()
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdPhase)
                    .HasColumnName("ID_PHASE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdProjet)
                    .HasColumnName("ID_PROJET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdSeance)
                    .HasColumnName("ID_SEANCE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdUp)
                    .IsRequired()
                    .HasColumnName("ID_UP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Specification)
                    .HasColumnName("SPECIFICATION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TypeAffectation)
                    .HasColumnName("TYPE_AFFECTATION")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Diplome1617>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DIPLOME_1617");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.DateDelivrance)
                    .HasColumnName("DATE_DELIVRANCE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateNaisEt)
                    .HasColumnName("DATE_NAIS_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Inscrit)
                    .HasColumnName("INSCRIT")
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.LibSpecialiteEspEt)
                    .HasColumnName("LIB_SPECIALITE_ESP_ET")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.LieuDelivrance)
                    .HasColumnName("LIEU_DELIVRANCE")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LieuNaisEt)
                    .HasColumnName("LIEU_NAIS_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mmelle)
                    .HasColumnName("MMELLE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.N)
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.Nationalite)
                    .HasColumnName("NATIONALITE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nenee)
                    .HasColumnName("NENEE")
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NumCinPasseport)
                    .HasColumnName("NUM_CIN_PASSEPORT")
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Sexe)
                    .HasColumnName("SEXE")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMP");

                entity.Property(e => e.EmpCode)
                    .HasColumnName("EMP_CODE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNumP)
                    .HasColumnName("EMP_NUM_P")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EnsVaca>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ENS_VACA");

                entity.Property(e => e.Cin)
                    .HasColumnName("CIN")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DateRecrutement)
                    .HasColumnName("DATE_RECRUTEMENT")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DnEns)
                    .HasColumnName("DN_ENS")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.MailEns)
                    .HasColumnName("MAIL_ENS")
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.NomEns)
                    .HasColumnName("NOM_ENS")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasColumnName("TEL1")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasColumnName("TEL2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEns)
                    .HasColumnName("TYPE_ENS")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EnteteReclamation>(entity =>
            {
                entity.HasKey(e => new { e.IdEnteteReclamation, e.IdEns })
                    .HasName("CONSTRAINT4");

                entity.ToTable("ENTETE_RECLAMATION");

                entity.Property(e => e.IdEnteteReclamation)
                    .HasColumnName("ID_ENTETE_RECLAMATION")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateReclamation)
                    .HasColumnName("DATE_RECLAMATION")
                    .HasColumnType("DATE");

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasColumnName("DESIGNATION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NomEns)
                    .IsRequired()
                    .HasColumnName("NOM_ENS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TypeReclamation)
                    .IsRequired()
                    .HasColumnName("TYPE_RECLAMATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspANiveau>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_A_NIVEAU");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NewNiveau).HasColumnName("NEW_NIVEAU");

                entity.Property(e => e.Niv).HasColumnName("NIV");

                entity.Property(e => e.Niveau)
                    .HasColumnName("NIVEAU")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Photos)
                    .HasColumnName("PHOTOS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasColumnName("PRENOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAbsNotTransSite>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_ABS_NOT_TRANS_SITE");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateSeance)
                    .HasColumnName("DATE_SEANCE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateTransf)
                    .HasColumnName("DATE_TRANSF")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JustifNotTransf)
                    .HasColumnName("JUSTIF_NOT_TRANSF")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumSeance).HasColumnName("NUM_SEANCE");

                entity.Property(e => e.Transferrred)
                    .HasColumnName("TRANSFERRRED")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAbscence>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.CodeModule, e.CodeCl, e.AnneeDeb, e.DateSceance, e.NumSceance });

                entity.ToTable("ESP_ABSCENCE");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateSceance)
                    .HasColumnName("DATE_SCEANCE")
                    .HasColumnType("DATE");

                entity.Property(e => e.NumSceance)
                    .HasColumnName("NUM_SCEANCE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.AnneeFin)
                    .HasColumnName("ANNEE_FIN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeJustif)
                    .HasColumnName("CODE_JUSTIF")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Justification)
                    .HasColumnName("JUSTIFICATION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LibJustif)
                    .HasColumnName("LIB_JUSTIF")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumPanier)
                    .HasColumnName("NUM_PANIER")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAbsence>(entity =>
            {
                entity.ToTable("ESP_ABSENCE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Crenaux)
                    .HasColumnName("CRENAUX")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.IdClasse)
                    .HasColumnName("ID_CLASSE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdDate)
                    .HasColumnName("ID_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEleve)
                    .HasColumnName("ID_ELEVE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdMat)
                    .HasColumnName("ID_MAT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdProf)
                    .HasColumnName("ID_PROF")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Justifier)
                    .HasColumnName("JUSTIFIER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Motif)
                    .HasColumnName("MOTIF")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remarque)
                    .HasColumnName("REMARQUE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre)
                    .HasColumnName("SEMESTRE")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAbsenceEnseignant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_ABSENCE_ENSEIGNANT");

                entity.HasIndex(e => new { e.IdEns, e.CodeModule, e.AnneeDeb, e.CodeCl, e.Date })
                    .HasName("PK_ABSENCE_ENS")
                    .IsUnique();

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .IsRequired()
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .IsRequired()
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeMotif)
                    .HasColumnName("CODE_MOTIF")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEns)
                    .IsRequired()
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Motif)
                    .IsRequired()
                    .HasColumnName("MOTIF")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NbHeures)
                    .HasColumnName("NB_HEURES")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.NbMinutes)
                    .HasColumnName("NB_MINUTES")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.NumSceance).HasColumnName("NUM_SCEANCE");

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.TypeAbs)
                    .HasColumnName("TYPE_ABS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAbsenceList>(entity =>
            {
                entity.ToTable("ESP_ABSENCE_LIST");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dt)
                    .HasColumnName("DT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Idagent)
                    .HasColumnName("IDAGENT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idclasse)
                    .HasColumnName("IDCLASSE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idcreneau)
                    .HasColumnName("IDCRENEAU")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idmodule)
                    .HasColumnName("IDMODULE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idprof)
                    .HasColumnName("IDPROF")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre)
                    .HasColumnName("SEMESTRE")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAbsenceNew>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.CodeCl, e.AnneeDeb, e.NumSeance, e.DateSeance, e.CodeModule })
                    .HasName("ESP_ABSENCE_NEW_PK");

                entity.ToTable("ESP_ABSENCE_NEW");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NumSeance)
                    .HasColumnName("NUM_SEANCE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateSeance)
                    .HasColumnName("DATE_SEANCE")
                    .HasColumnType("DATE");

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AConvoquer)
                    .HasColumnName("A_CONVOQUER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.CodeJustif)
                    .HasColumnName("CODE_JUSTIF")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Justification)
                    .HasColumnName("JUSTIFICATION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.LibJustif)
                    .HasColumnName("LIB_JUSTIF")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewSemestre)
                    .HasColumnName("NEW_SEMESTRE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAbsenceTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_ABSENCE_TMP");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeFin)
                    .HasColumnName("ANNEE_FIN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSceance)
                    .HasColumnName("DATE_SCEANCE")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumPanier)
                    .HasColumnName("NUM_PANIER")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NumSceance)
                    .HasColumnName("NUM_SCEANCE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAcquisChapter>(entity =>
            {
                entity.HasKey(e => e.IdAcquis)
                    .HasName("ESP_ACQUIS_CHAPTERS_PK");

                entity.ToTable("ESP_ACQUIS_CHAPTER");

                entity.Property(e => e.IdAcquis)
                    .HasColumnName("ID_ACQUIS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeChapter)
                    .IsRequired()
                    .HasColumnName("CODE_CHAPTER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .IsRequired()
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateDernierModif)
                    .HasColumnName("DATE_DERNIER_MODIF")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Designation)
                    .HasColumnName("DESIGNATION")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.EtatAcquis)
                    .HasColumnName("ETAT_ACQUIS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.IdEnsModif)
                    .HasColumnName("ID_ENS_MODIF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumChapter)
                    .IsRequired()
                    .HasColumnName("NUM_CHAPTER")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAcquisModule>(entity =>
            {
                entity.HasKey(e => new { e.CodeModule, e.TitreChapter, e.AnneeDeb })
                    .HasName("ESP_AQUIS_MODULE_PK");

                entity.ToTable("ESP_ACQUIS_MODULE");

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TitreChapter)
                    .HasColumnName("TITRE_CHAPTER")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.HoraireChap)
                    .HasColumnName("HORAIRE_CHAP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumChapter)
                    .HasColumnName("NUM_CHAPTER")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAcquisValidEns>(entity =>
            {
                entity.HasKey(e => new { e.IdEns, e.IdAcquis, e.CodeCl })
                    .HasName("ESP_ACQUIS_VALID_ENS_PK");

                entity.ToTable("ESP_ACQUIS_VALID_ENS");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdAcquis)
                    .HasColumnName("ID_ACQUIS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .IsRequired()
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateModif)
                    .HasColumnName("DATE_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSeance)
                    .HasColumnName("DATE_SEANCE")
                    .HasMaxLength(35);

                entity.Property(e => e.Jour)
                    .HasColumnName("JOUR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProgCours)
                    .HasColumnName("PROG_COURS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProgCoursPercent)
                    .HasColumnName("PROG_COURS_PERCENT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RemarqueEns)
                    .HasColumnName("REMARQUE_ENS")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAdmission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_ADMISSION");

                entity.Property(e => e.AngScore)
                    .HasColumnName("ANG_SCORE")
                    .HasColumnType("NUMBER(15,6)");

                entity.Property(e => e.Anglais)
                    .HasColumnName("ANGLAIS")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.AnneeBac)
                    .HasColumnName("ANNEE_BAC")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Champ33)
                    .HasColumnName("CHAMP33")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CodeSpecOrigine)
                    .HasColumnName("CODE_SPEC_ORIGINE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Colonne1)
                    .HasColumnName("COLONNE1")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.Colonne2)
                    .HasColumnName("COLONNE2")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.CycleEt)
                    .HasColumnName("CYCLE_ET")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.DateBac)
                    .HasColumnName("DATE_BAC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateNaisEt)
                    .HasColumnName("DATE_NAIS_ET")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Entretien)
                    .HasColumnName("ENTRETIEN")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.EtabBac)
                    .HasColumnName("ETAB_BAC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EtabOrigine)
                    .HasColumnName("ETAB_ORIGINE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FrScore)
                    .HasColumnName("FR_SCORE")
                    .HasColumnType("NUMBER(15,6)");

                entity.Property(e => e.Francais)
                    .HasColumnName("FRANCAIS")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt2)
                    .HasColumnName("ID_ET2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LibSpecOrigine)
                    .HasColumnName("LIB_SPEC_ORIGINE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MoyBacEt)
                    .HasColumnName("MOY_BAC_ET")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.NatureBac)
                    .HasColumnName("NATURE_BAC")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.NiveauAcces)
                    .HasColumnName("NIVEAU_ACCES")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.NiveauDiplomeSupEt)
                    .HasColumnName("NIVEAU_DIPLOME_SUP_ET")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumLot).HasColumnName("NUM_LOT");

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Qi)
                    .HasColumnName("QI")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.QiScore)
                    .HasColumnName("QI_SCORE")
                    .HasColumnType("NUMBER(15,6)");

                entity.Property(e => e.ScoreFinal)
                    .HasColumnName("SCORE_FINAL")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.Scoreagebac)
                    .HasColumnName("SCOREAGEBAC")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.Scorebac)
                    .HasColumnName("SCOREBAC")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.Scoreentretien)
                    .HasColumnName("SCOREENTRETIEN")
                    .HasColumnType("NUMBER(15,6)");

                entity.Property(e => e.Scoreexam)
                    .HasColumnName("SCOREEXAM")
                    .HasColumnType("NUMBER(15,6)");

                entity.Property(e => e.Scorefinalentretien)
                    .HasColumnName("SCOREFINALENTRETIEN")
                    .HasColumnType("NUMBER(15,6)");

                entity.Property(e => e.Scoremoybac)
                    .HasColumnName("SCOREMOYBAC")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.SpecialiteEspEt)
                    .HasColumnName("SPECIALITE_ESP_ET")
                    .HasColumnType("NUMBER(15)");
            });

            modelBuilder.Entity<EspAdreeseMailEtudiant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_ADREESE_MAIL_ETUDIANT");

                entity.Property(e => e.AdresseMail)
                    .HasColumnName("ADRESSE_MAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAdresseMailEspEtudiant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_ADRESSE_MAIL_ESP_ETUDIANT");

                entity.Property(e => e.AdresseMailEsp)
                    .HasColumnName("ADRESSE_MAIL_ESP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAffGroupEtudiant>(entity =>
            {
                entity.HasKey(e => new { e.IdGroupe, e.AnneeDeb, e.IdEt })
                    .HasName("PK_AFF_GR");

                entity.ToTable("ESP_AFF_GROUP_ETUDIANT");

                entity.Property(e => e.IdGroupe)
                    .HasColumnName("ID_GROUPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateAffectation)
                    .HasColumnName("DATE_AFFECTATION")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");
            });

            modelBuilder.Entity<EspAffectationEmploi>(entity =>
            {
                entity.HasKey(e => new { e.CodeEmploi, e.AnneeDeb })
                    .HasName("ESP_AFFECTATION_EMPLOI_PK");

                entity.ToTable("ESP_AFFECTATION_EMPLOI");

                entity.Property(e => e.CodeEmploi)
                    .HasColumnName("CODE_EMPLOI")
                    .HasColumnType("NUMBER(25)");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .IsRequired()
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .IsRequired()
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cren1)
                    .HasColumnName("CREN_1")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Cren2)
                    .HasColumnName("CREN_2")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.IdEns)
                    .IsRequired()
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns2)
                    .HasColumnName("ID_ENS2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns3)
                    .HasColumnName("ID_ENS3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns4)
                    .HasColumnName("ID_ENS4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Jours)
                    .HasColumnName("JOURS")
                    .HasColumnType("DATE");

                entity.Property(e => e.SallePrincipale)
                    .HasColumnName("SALLE_PRINCIPALE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAppreciation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_APPRECIATION");

                entity.Property(e => e.Code).HasColumnName("CODE");

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspArchivageEtudiant>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.TypeArchivage, e.DateArchivage })
                    .HasName("PK_ARCHIVAGE_ET");

                entity.ToTable("ESP_ARCHIVAGE_ETUDIANT");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeArchivage)
                    .HasColumnName("TYPE_ARCHIVAGE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateArchivage)
                    .HasColumnName("DATE_ARCHIVAGE")
                    .HasColumnType("DATE");

                entity.Property(e => e.IpRchivage)
                    .HasColumnName("IP_RCHIVAGE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineArchivage)
                    .HasColumnName("MACHINE_ARCHIVAGE")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MotifArchivage)
                    .HasColumnName("MOTIF_ARCHIVAGE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RespArchivage)
                    .HasColumnName("RESP_ARCHIVAGE")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAssRubEtIns>(entity =>
            {
                entity.HasKey(e => new { e.CodeRub, e.IdEt, e.AnneeDeb, e.DateOp })
                    .HasName("PK_ASS_RUB_ET");

                entity.ToTable("ESP_ASS_RUB_ET_INS");

                entity.Property(e => e.CodeRub)
                    .HasColumnName("CODE_RUB")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateOp)
                    .HasColumnName("DATE_OP")
                    .HasColumnType("DATE");

                entity.Property(e => e.Banque)
                    .HasColumnName("BANQUE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastModif)
                    .HasColumnName("DATE_LAST_MODIF")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.DatePiece)
                    .HasColumnName("DATE_PIECE")
                    .HasColumnType("DATE");

                entity.Property(e => e.ModeRglt)
                    .HasColumnName("MODE_RGLT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MontantOp)
                    .HasColumnName("MONTANT_OP")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.NumPiece)
                    .HasColumnName("NUM_PIECE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumRecu)
                    .HasColumnName("NUM_RECU")
                    .HasColumnType("NUMBER(8)");

                entity.Property(e => e.Objet)
                    .HasColumnName("OBJET")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAuditAdmission>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.IdEt, e.DateOp })
                    .HasName("PK_AUDIT_ADMISSION");

                entity.ToTable("ESP_AUDIT_ADMISSION");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateOp)
                    .HasColumnName("DATE_OP")
                    .HasColumnType("DATE");

                entity.Property(e => e.AdresseIp)
                    .HasColumnName("ADRESSE_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComCol)
                    .HasColumnName("COM_COL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomMachine)
                    .HasColumnName("NOM_MACHINE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValFinal)
                    .HasColumnName("VAL_FINAL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValInit)
                    .HasColumnName("VAL_INIT")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAuditChangeClasse>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.IdEt, e.DateChangementCl })
                    .HasName("PK_CHANGE_CLASSE");

                entity.ToTable("ESP_AUDIT_CHANGE_CLASSE");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateChangementCl)
                    .HasColumnName("DATE_CHANGEMENT_CL")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateInscription)
                    .HasColumnName("DATE_INSCRIPTION")
                    .HasColumnType("DATE");

                entity.Property(e => e.IpMachine)
                    .HasColumnName("IP_MACHINE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewCl)
                    .HasColumnName("NEW_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomMachine)
                    .HasColumnName("NOM_MACHINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldCl)
                    .HasColumnName("OLD_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAuditChangeEnseignant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_AUDIT_CHANGE_ENSEIGNANT");

                entity.Property(e => e.AdresseIp)
                    .HasColumnName("ADRESSE_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComCol)
                    .HasColumnName("COM_COL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateOp)
                    .HasColumnName("DATE_OP")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomMachine)
                    .HasColumnName("NOM_MACHINE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValFinal)
                    .HasColumnName("VAL_FINAL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValInit)
                    .HasColumnName("VAL_INIT")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAuditConnexion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_AUDIT_CONNEXION");

                entity.Property(e => e.AdresseIp)
                    .HasColumnName("ADRESSE_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateConnect)
                    .HasColumnName("DATE_CONNECT")
                    .HasColumnType("DATE");

                entity.Property(e => e.NomMachine)
                    .HasColumnName("NOM_MACHINE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomProgram)
                    .HasColumnName("NOM_PROGRAM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAuditCredit>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.DateOp });

                entity.ToTable("ESP_AUDIT_CREDIT");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateOp)
                    .HasColumnName("DATE_OP")
                    .HasColumnType("DATE");

                entity.Property(e => e.AdresseIp)
                    .HasColumnName("ADRESSE_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Machine)
                    .HasColumnName("MACHINE")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NewValCredit)
                    .HasColumnName("NEW_VAL_CREDIT")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.OldValCredit)
                    .HasColumnName("OLD_VAL_CREDIT")
                    .HasColumnType("NUMBER(10,3)");
            });

            modelBuilder.Entity<EspAuditFailedEns>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_AUDIT_FAILED_ENS");

                entity.Property(e => e.CodeMat)
                    .HasColumnName("CODE_MAT")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ComCol)
                    .HasColumnName("COM_COL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateOp)
                    .HasColumnName("DATE_OP")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.IpAdress)
                    .HasColumnName("IP_ADRESS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Justification)
                    .HasColumnName("JUSTIFICATION")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomEns)
                    .HasColumnName("NOM_ENS")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.NomMachine)
                    .HasColumnName("NOM_MACHINE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PEns)
                    .HasColumnName("P_ENS")
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAuditLibDecisionpR>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_AUDIT_LIB_DECISIONP_R");

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .IsRequired()
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateOp)
                    .HasColumnName("DATE_OP")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnName("IP_ADDRESS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewCodeDecisionSessionP)
                    .HasColumnName("NEW_CODE_DECISION_SESSION_P")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NewCodeDecisionSessionRat)
                    .HasColumnName("NEW_CODE_DECISION_SESSION_RAT")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NewLibDecisionSessionP)
                    .HasColumnName("NEW_LIB_DECISION_SESSION_P")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NewLibDecisionSessionRat)
                    .HasColumnName("NEW_LIB_DECISION_SESSION_RAT")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NomMachine)
                    .IsRequired()
                    .HasColumnName("NOM_MACHINE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldCodeDecisionSessionP)
                    .HasColumnName("OLD_CODE_DECISION_SESSION_P")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.OldCodeDecisionSessionRat)
                    .HasColumnName("OLD_CODE_DECISION_SESSION_RAT")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.OldLibDecisionSessionP)
                    .HasColumnName("OLD_LIB_DECISION_SESSION_P")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.OldLibDecisionSessionRat)
                    .HasColumnName("OLD_LIB_DECISION_SESSION_RAT")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TypeOp)
                    .HasColumnName("TYPE_OP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Utilisateur)
                    .IsRequired()
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAuditModifPlan>(entity =>
            {
                entity.HasKey(e => new { e.DateModif, e.AnneeDeb, e.CodeCl, e.CodeModule })
                    .HasName("PK_JOURNAL_MODIF_OLAN");

                entity.ToTable("ESP_AUDIT_MODIF_PLAN");

                entity.Property(e => e.DateModif)
                    .HasColumnName("DATE_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Coef)
                    .HasColumnName("COEF")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.ExisteCc)
                    .HasColumnName("EXISTE_CC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ExisteTp)
                    .HasColumnName("EXISTE_TP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns2)
                    .HasColumnName("ID_ENS2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns3)
                    .HasColumnName("ID_ENS3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IpMachine)
                    .HasColumnName("IP_MACHINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NbEcts).HasColumnName("NB_ECTS");

                entity.Property(e => e.NbHeures)
                    .HasColumnName("NB_HEURES")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.NewCodeUe)
                    .HasColumnName("NEW_CODE_UE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NewCoef)
                    .HasColumnName("NEW_COEF")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.NewExisteCc)
                    .HasColumnName("NEW_EXISTE_CC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NewExisteTp)
                    .HasColumnName("NEW_EXISTE_TP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NewIdEns)
                    .HasColumnName("NEW_ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NewIdEns2)
                    .HasColumnName("NEW_ID_ENS2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NewIdEns3)
                    .HasColumnName("NEW_ID_ENS3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NewNbEcts).HasColumnName("NEW_NB_ECTS");

                entity.Property(e => e.NewNbHeures)
                    .HasColumnName("NEW_NB_HEURES")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.NewTypeEpreuve)
                    .HasColumnName("NEW_TYPE_EPREUVE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NewTypeEpreuveSr)
                    .HasColumnName("NEW_TYPE_EPREUVE_SR")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NomMachine)
                    .HasColumnName("NOM_MACHINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEpreuve)
                    .HasColumnName("TYPE_EPREUVE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEpreuveSr)
                    .HasColumnName("TYPE_EPREUVE_SR")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspAuditSociete>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.CodeSoc, e.NomColonne, e.TypeOp, e.DateOp, e.Utilisateur });

                entity.ToTable("ESP_AUDIT_SOCIETE");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeSoc)
                    .HasColumnName("CODE_SOC")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NomColonne)
                    .HasColumnName("NOM_COLONNE")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOp)
                    .HasColumnName("TYPE_OP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateOp)
                    .HasColumnName("DATE_OP")
                    .HasColumnType("DATE");

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AdresseIp)
                    .HasColumnName("ADRESSE_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Machine)
                    .HasColumnName("MACHINE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValeurFinal)
                    .HasColumnName("VALEUR_FINAL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ValeurInit)
                    .HasColumnName("VALEUR_INIT")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspBilanPrepa>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.CodeCl, e.CodeModule, e.AnneeDeb })
                    .HasName("ESP_BILAN_PREPA_PK");

                entity.ToTable("ESP_BILAN_PREPA");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BilanQ1)
                    .HasColumnName("BILAN_Q1")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.BilanQ10)
                    .HasColumnName("BILAN_Q10")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.BilanQ2)
                    .HasColumnName("BILAN_Q2")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.BilanQ3)
                    .HasColumnName("BILAN_Q3")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.BilanQ4)
                    .HasColumnName("BILAN_Q4")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.BilanQ5)
                    .HasColumnName("BILAN_Q5")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.BilanQ6)
                    .HasColumnName("BILAN_Q6")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.BilanQ7)
                    .HasColumnName("BILAN_Q7")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.BilanQ8)
                    .HasColumnName("BILAN_Q8")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.BilanQ9)
                    .HasColumnName("BILAN_Q9")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateMiseJour)
                    .HasColumnName("DATE_MISE_JOUR")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");
            });

            modelBuilder.Entity<EspBlacklist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_BLACKLIST");

                entity.Property(e => e.CaAnnuel)
                    .HasColumnName("CA_ANNUEL")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MontFrais)
                    .HasColumnName("MONT_FRAIS")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.MontRegle)
                    .HasColumnName("MONT_REGLE")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumCpt)
                    .HasColumnName("NUM_CPT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Paiement)
                    .HasColumnName("PAIEMENT")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ResteSurTaux60)
                    .HasColumnName("RESTE_SUR_TAUX60")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.SoldeActuel)
                    .HasColumnName("SOLDE_ACTUEL")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.Taux60)
                    .HasColumnName("TAUX_60")
                    .HasColumnType("NUMBER(10,3)");
            });

            modelBuilder.Entity<EspCahierClasse>(entity =>
            {
                entity.HasKey(e => new { e.CodeModule, e.IdEns, e.AnneeDeb, e.NumSemestre, e.CodeCl, e.DateSeance })
                    .HasName("ESP_CAHIER_DE_cLASSE_PK");

                entity.ToTable("ESP_CAHIER_CLASSE");

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NumSemestre)
                    .HasColumnName("NUM_SEMESTRE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateSeance)
                    .HasColumnName("DATE_SEANCE")
                    .HasColumnType("DATE");

                entity.Property(e => e.ContenuTraite)
                    .HasColumnName("CONTENU_TRAITE")
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql(@"sysdate 
");

                entity.Property(e => e.Duree)
                    .HasColumnName("DUREE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HeureDebut)
                    .HasColumnName("HEURE_DEBUT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HeureFin)
                    .HasColumnName("HEURE_FIN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NumSeance)
                    .HasColumnName("NUM_SEANCE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remarque)
                    .HasColumnName("REMARQUE")
                    .IsUnicode(false);

                entity.Property(e => e.Titre)
                    .HasColumnName("TITRE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspCahierDeTexte>(entity =>
            {
                entity.HasKey(e => new { e.CodeModule, e.IdEns, e.AnneeDeb, e.NumSemestre, e.CodeCl })
                    .HasName("ESP_CAHIER_DE_TEXT_PK");

                entity.ToTable("ESP_CAHIER_DE_TEXTE");

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NumSemestre)
                    .HasColumnName("NUM_SEMESTRE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContenuTraite)
                    .HasColumnName("CONTENU_TRAITE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql(@"sysdate 
");

                entity.Property(e => e.DateSeance)
                    .HasColumnName("DATE_SEANCE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Duree)
                    .HasColumnName("DUREE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HeureDebut)
                    .HasColumnName("HEURE_DEBUT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HeureFin)
                    .HasColumnName("HEURE_FIN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NumSeance)
                    .HasColumnName("NUM_SEANCE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remarque)
                    .HasColumnName("REMARQUE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspCalcul>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_CALCUL");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScoreAnglais)
                    .HasColumnName("SCORE_ANGLAIS")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreDossier)
                    .HasColumnName("SCORE_DOSSIER")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreEntretien)
                    .HasColumnName("SCORE_ENTRETIEN")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreFinal)
                    .HasColumnName("SCORE_FINAL")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreFrancais)
                    .HasColumnName("SCORE_FRANCAIS")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreQi)
                    .HasColumnName("SCORE_QI")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreTest)
                    .HasColumnName("SCORE_TEST")
                    .HasColumnType("NUMBER(10,6)");
            });

            modelBuilder.Entity<EspCandForm>(entity =>
            {
                entity.HasKey(e => new { e.Idfromation, e.IdEns })
                    .HasName("ESP_CAND_FORM_PK2");

                entity.ToTable("ESP_CAND_FORM");

                entity.Property(e => e.Idfromation)
                    .HasColumnName("IDFROMATION")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Datemaj)
                    .HasColumnName("DATEMAJ")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql(@"sysdate 
");

                entity.Property(e => e.Etatins)
                    .HasColumnName("ETATINS")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Pesence)
                    .HasColumnName("PESENCE")
                    .HasColumnType("CHAR(1)");
            });

            modelBuilder.Entity<EspCcna>(entity =>
            {
                entity.HasKey(e => e.IdInscription)
                    .HasName("ESP_CCNA_PK");

                entity.ToTable("ESP_CCNA");

                entity.Property(e => e.IdInscription)
                    .HasColumnName("ID_INSCRIPTION")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.AdresseEt)
                    .HasColumnName("ADRESSE_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateIns)
                    .HasColumnName("DATE_INS")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateMisejour)
                    .HasColumnName("DATE_MISEJOUR")
                    .HasColumnType("DATE");

                entity.Property(e => e.HeureIns)
                    .HasColumnName("HEURE_INS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomEt)
                    .IsRequired()
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomJeton)
                    .IsRequired()
                    .HasColumnName("NOM_JETON")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomEt)
                    .IsRequired()
                    .HasColumnName("PRENOM_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCcna)
                    .HasColumnName("TYPE_CCNA")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspCertif>(entity =>
            {
                entity.HasKey(e => e.NomJeton);

                entity.ToTable("ESP_CERTIF");

                entity.Property(e => e.NomJeton)
                    .HasColumnName("NOM_JETON")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdresseEt)
                    .IsRequired()
                    .HasColumnName("ADRESSE_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateIns)
                    .HasColumnName("DATE_INS")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateMisejour)
                    .HasColumnName("DATE_MISEJOUR")
                    .HasColumnType("DATE");

                entity.Property(e => e.HeureIns)
                    .IsRequired()
                    .HasColumnName("HEURE_INS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomEt)
                    .IsRequired()
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoteExam)
                    .HasColumnName("NOTE_EXAM")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.PrenomEt)
                    .IsRequired()
                    .HasColumnName("PRENOM_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspChoix>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_CHOIX");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspCompteur>(entity =>
            {
                entity.HasKey(e => new { e.CodeCpt, e.AnneeCpt })
                    .HasName("PK_COMPTEUR");

                entity.ToTable("ESP_COMPTEUR");

                entity.Property(e => e.CodeCpt)
                    .HasColumnName("CODE_CPT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeCpt)
                    .HasColumnName("ANNEE_CPT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AutoCpt)
                    .HasColumnName("AUTO_CPT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreation)
                    .HasColumnName("DATE_CREATION")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateLastModif)
                    .HasColumnName("DATE_LAST_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.DesignationCpt)
                    .HasColumnName("DESIGNATION_CPT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumAuto).HasColumnName("NUM_AUTO");

                entity.Property(e => e.TailleCpt)
                    .HasColumnName("TAILLE_CPT")
                    .HasColumnType("NUMBER(4)");
            });

            modelBuilder.Entity<EspContrat>(entity =>
            {
                entity.HasKey(e => e.Numord)
                    .HasName("PK_CONTRAT");

                entity.ToTable("ESP_CONTRAT");

                entity.Property(e => e.Numord)
                    .HasColumnName("NUMORD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Annee)
                    .IsRequired()
                    .HasColumnName("ANNEE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateEtab)
                    .HasColumnName("DATE_ETAB")
                    .HasColumnType("DATE");

                entity.Property(e => e.Diplome)
                    .IsRequired()
                    .HasColumnName("DIPLOME")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Grade)
                    .IsRequired()
                    .HasColumnName("GRADE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .IsRequired()
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Institution)
                    .IsRequired()
                    .HasColumnName("INSTITUTION")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspConvocation>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.IdEt, e.DateGeneration })
                    .HasName("PK_CONVOCATION");

                entity.ToTable("ESP_CONVOCATION");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DateGeneration)
                    .HasColumnName("DATE_GENERATION")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ConvocationParent)
                    .HasColumnName("CONVOCATION_PARENT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateConvocation)
                    .HasColumnName("DATE_CONVOCATION")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateEnvoiMailTel)
                    .HasColumnName("DATE_ENVOI_MAIL_TEL")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateReception)
                    .HasColumnName("DATE_RECEPTION")
                    .HasColumnType("DATE");

                entity.Property(e => e.Generation)
                    .HasColumnName("GENERATION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ModeConvocation)
                    .HasColumnName("MODE_CONVOCATION")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MoisGen)
                    .HasColumnName("MOIS_GEN")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MotifConvocation)
                    .HasColumnName("MOTIF_CONVOCATION")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Moyenne)
                    .HasColumnName("MOYENNE")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NbMinJour).HasColumnName("NB_MIN_JOUR");

                entity.Property(e => e.NbMinSeance).HasColumnName("NB_MIN_SEANCE");

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ReponseEt)
                    .HasColumnName("REPONSE_ET")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspCoordinateur>(entity =>
            {
                entity.HasKey(e => new { e.CodeModule, e.AnneeDeb, e.CodeCl, e.NumSemestre })
                    .HasName("ESP_COORDINATEUR_PK");

                entity.ToTable("ESP_COORDINATEUR");

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumSemestre)
                    .HasColumnName("NUM_SEMESTRE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Categorie)
                    .IsRequired()
                    .HasColumnName("CATEGORIE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeSpecialite)
                    .HasColumnName("CODE_SPECIALITE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Designation)
                    .HasColumnName("DESIGNATION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .IsRequired()
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEnsChefDept)
                    .HasColumnName("ID_ENS_CHEF_DEPT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomEns)
                    .HasColumnName("NOM_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspCorEtab>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_COR_ETAB");

                entity.Property(e => e.CodeDest)
                    .HasColumnName("CODE_DEST")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodeInit)
                    .HasColumnName("CODE_INIT")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspCorrespEt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_CORRESP_ET");

                entity.Property(e => e.Customerpricegroup)
                    .HasColumnName("CUSTOMERPRICEGROUP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspCorrespIdetCompte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_CORRESP_IDET_COMPTE");

                entity.Property(e => e.Compte)
                    .HasColumnName("COMPTE")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasColumnType("CHAR(10)");
            });

            modelBuilder.Entity<EspCreditPanier>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_CREDIT_PANIER");

                entity.HasIndex(e => new { e.IdEt, e.NiveauEtCredit, e.NumPanier, e.AnneeDeb, e.TypeCredit })
                    .HasName("ESP_CREDIT_PANIER_X")
                    .IsUnique();

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasColumnType("CHAR(4)");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.DateValidation)
                    .HasColumnName("DATE_VALIDATION")
                    .HasColumnType("DATE");

                entity.Property(e => e.EtatCredit)
                    .HasColumnName("ETAT_CREDIT")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.LibPanier)
                    .HasColumnName("LIB_PANIER")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NiveauEtCredit).HasColumnName("NIVEAU_ET_CREDIT");

                entity.Property(e => e.NumPanier)
                    .IsRequired()
                    .HasColumnName("NUM_PANIER")
                    .HasColumnType("CHAR(5)");

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.TypeCredit)
                    .IsRequired()
                    .HasColumnName("TYPE_CREDIT")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasColumnType("CHAR(16)");
            });

            modelBuilder.Entity<EspCreditUeSp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_CREDIT_UE_SP");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LibUe)
                    .HasColumnName("LIB_UE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Moyenne)
                    .HasColumnName("MOYENNE")
                    .HasColumnType("NUMBER(10,2)");
            });

            modelBuilder.Entity<EspCreditUeSp4eme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_CREDIT_UE_SP_4EME");

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LibUe)
                    .HasColumnName("LIB_UE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Moyenne)
                    .HasColumnName("MOYENNE")
                    .HasColumnType("NUMBER(10,2)");
            });

            modelBuilder.Entity<EspCritereEval>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_CRITERE_EVAL");

                entity.HasIndex(e => e.CodeCritere)
                    .HasName("ESP_CRITERE_EVAL_X")
                    .IsUnique();

                entity.Property(e => e.CodeCritere)
                    .IsRequired()
                    .HasColumnName("CODE_CRITERE")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.LibCritere)
                    .HasColumnName("LIB_CRITERE")
                    .HasColumnType("CHAR(30)");
            });

            modelBuilder.Entity<EspDept>(entity =>
            {
                entity.HasKey(e => e.CodeDept)
                    .HasName("ESP_DEPT_PK");

                entity.ToTable("ESP_DEPT");

                entity.Property(e => e.CodeDept)
                    .HasColumnName("CODE_DEPT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeTrie)
                    .HasColumnName("CODE_TRIE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateCr)
                    .HasColumnName("DATE_CR")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateDernierModif)
                    .HasColumnName("DATE_DERNIER_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.LibelleDept)
                    .HasColumnName("LIBELLE_DEPT")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspDerogation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_DEROGATION");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspDetailContrat>(entity =>
            {
                entity.HasKey(e => new { e.Numord, e.CodeCl, e.CodeModule })
                    .HasName("PK_DETAIL_CONTRAT");

                entity.ToTable("ESP_DETAIL_CONTRAT");

                entity.Property(e => e.Numord)
                    .HasColumnName("NUMORD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NbHeures).HasColumnName("NB_HEURES");

                entity.Property(e => e.Periode)
                    .IsRequired()
                    .HasColumnName("PERIODE")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspDioplome2018>(entity =>
            {
                entity.HasKey(e => e.Num)
                    .HasName("SYS_C0011452");

                entity.ToTable("ESP_DIOPLOME_2018");

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .IsRequired()
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateDéDition)
                    .HasColumnName("DATE_DéDITION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LibSession)
                    .IsRequired()
                    .HasColumnName("LIB_SESSION")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspDiplome2017>(entity =>
            {
                entity.HasKey(e => e.Num)
                    .HasName("SYS_C0011457");

                entity.ToTable("ESP_DIPLOME_2017");

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .IsRequired()
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DateDéDition)
                    .HasColumnName("DATE_DéDITION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Field7)
                    .HasColumnName("FIELD7")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LibSession)
                    .IsRequired()
                    .HasColumnName("LIB_SESSION")
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspDirection>(entity =>
            {
                entity.HasKey(e => e.IdDr)
                    .HasName("PK_DIRECTION");

                entity.ToTable("ESP_DIRECTION");

                entity.Property(e => e.IdDr)
                    .HasColumnName("ID_DR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdresseMailEsp)
                    .IsRequired()
                    .HasColumnName("ADRESSE_MAIL_ESP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CinPass)
                    .IsRequired()
                    .HasColumnName("CIN_PASS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateRec)
                    .HasColumnName("DATE_REC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Diplome)
                    .IsRequired()
                    .HasColumnName("DIPLOME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomDr)
                    .IsRequired()
                    .HasColumnName("NOM_DR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PnomDr)
                    .IsRequired()
                    .HasColumnName("PNOM_DR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasColumnName("TEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TitreDr)
                    .IsRequired()
                    .HasColumnName("TITRE_DR")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspDispenseEtudiant>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.CodeModule, e.AnneeDeb, e.Semestre })
                    .HasName("PK_DISPENSE");

                entity.ToTable("ESP_DISPENSE_ETUDIANT");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.DateDebutDispense)
                    .HasColumnName("DATE_DEBUT_DISPENSE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Moyenne)
                    .HasColumnName("MOYENNE")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspDisponibiliteEns>(entity =>
            {
                entity.HasKey(e => new { e.IdDispo, e.AnneeDeb })
                    .HasName("PK_DISPO");

                entity.ToTable("ESP_DISPONIBILITE_ENS");

                entity.Property(e => e.IdDispo)
                    .HasColumnName("ID_DISPO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Disponible)
                    .HasColumnName("DISPONIBLE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Jours)
                    .HasColumnName("JOURS")
                    .HasColumnType("DATE");

                entity.Property(e => e.SeanceD)
                    .HasColumnName("SEANCE_D")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SeanceF)
                    .HasColumnName("SEANCE_F")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<EspDsExam>(entity =>
            {
                entity.HasKey(e => new { e.CodeCl, e.CodeModule, e.AnneeDeb, e.NumSeance, e.DateSaisie })
                    .HasName("ESP_DS_EXAM_PK");

                entity.ToTable("ESP_DS_EXAM");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NumSeance)
                    .HasColumnName("NUM_SEANCE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"sysdate
   ");

                entity.Property(e => e.AProgrammer)
                    .HasColumnName("A_PROGRAMMER")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DsExam)
                    .HasColumnName("DS_EXAM")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NumPeriode).HasColumnName("NUM_PERIODE");

                entity.Property(e => e.NumSemestre).HasColumnName("NUM_SEMESTRE");

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeExam)
                    .HasColumnName("TYPE_EXAM")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEncadProjetRq>(entity =>
            {
                entity.HasKey(e => e.IdEncadrement)
                    .HasName("ESP_ENCAD_PROJET_RQ_PK");

                entity.ToTable("ESP_ENCAD_PROJET_RQ");

                entity.Property(e => e.IdEncadrement)
                    .HasColumnName("ID_ENCADREMENT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Absent)
                    .HasColumnName("ABSENT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AvencementTech)
                    .HasColumnName("AVENCEMENT_TECH")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ConformiteCc)
                    .HasColumnName("CONFORMITE_CC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateProchainRdv)
                    .HasColumnName("DATE_PROCHAIN_RDV")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSeance)
                    .HasColumnName("DATE_SEANCE")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdGroupe)
                    .HasColumnName("ID_GROUPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NiveauAng)
                    .HasColumnName("NIVEAU_ANG")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NiveauFr)
                    .HasColumnName("NIVEAU_FR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RqCc)
                    .HasColumnName("RQ_CC")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RqNiveauAng)
                    .HasColumnName("RQ_NIVEAU_ANG")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RqNiveauFr)
                    .HasColumnName("RQ_NIVEAU_FR")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RqTechnique)
                    .HasColumnName("RQ_TECHNIQUE")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre)
                    .HasColumnName("SEMESTRE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.TacheAFaire)
                    .HasColumnName("TACHE_A_FAIRE")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEncadrement>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.DateEnc })
                    .HasName("CONSTRAINT19");

                entity.ToTable("ESP_ENCADREMENT");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateEnc)
                    .HasColumnName("DATE_ENC")
                    .HasColumnType("DATE");

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AvAng)
                    .HasColumnName("AV_ANG")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AvCc).HasColumnName("AV_CC");

                entity.Property(e => e.AvFr)
                    .HasColumnName("AV_FR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AvRapport).HasColumnName("AV_RAPPORT");

                entity.Property(e => e.AvTech).HasColumnName("AV_TECH");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comportement)
                    .HasColumnName("COMPORTEMENT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DateProchainEncad)
                    .HasColumnName("DATE_PROCHAIN_ENCAD")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql(@"sysdate 
");

                entity.Property(e => e.Duree)
                    .HasColumnName("DUREE")
                    .HasColumnType("DATE");

                entity.Property(e => e.HeureDeb)
                    .HasColumnName("HEURE_DEB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HeureFin)
                    .HasColumnName("HEURE_FIN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HeureProchain)
                    .HasColumnName("HEURE_PROCHAIN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .IsRequired()
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdProjet)
                    .IsRequired()
                    .HasColumnName("ID_PROJET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObsAnglais)
                    .HasColumnName("OBS_ANGLAIS")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCc)
                    .HasColumnName("OBS_CC")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ObsFrancais)
                    .HasColumnName("OBS_FRANCAIS")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ObsRapport)
                    .HasColumnName("OBS_RAPPORT")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ObsTech)
                    .HasColumnName("OBS_TECH")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RemarqueObs)
                    .HasColumnName("REMARQUE_OBS")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TravauxDemande)
                    .HasColumnName("TRAVAUX_DEMANDE")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TypeProjet)
                    .IsRequired()
                    .HasColumnName("TYPE_PROJET")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEncadrement1>(entity =>
            {
                entity.HasKey(e => new { e.IdProjet, e.IdEt, e.DateEnc })
                    .HasName("CONSTRAINT18");

                entity.ToTable("ESP_ENCADREMENT1");

                entity.Property(e => e.IdProjet)
                    .HasColumnName("ID_PROJET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateEnc)
                    .HasColumnName("DATE_ENC")
                    .HasColumnType("DATE");

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AvAng)
                    .HasColumnName("AV_ANG")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AvCc).HasColumnName("AV_CC");

                entity.Property(e => e.AvFr)
                    .HasColumnName("AV_FR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AvRapport).HasColumnName("AV_RAPPORT");

                entity.Property(e => e.AvTech).HasColumnName("AV_TECH");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comportement)
                    .HasColumnName("COMPORTEMENT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Duree)
                    .HasColumnName("DUREE")
                    .HasColumnType("DATE");

                entity.Property(e => e.HeureDeb)
                    .HasColumnName("HEURE_DEB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HeureFin)
                    .HasColumnName("HEURE_FIN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .IsRequired()
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ObsAnglais)
                    .HasColumnName("OBS_ANGLAIS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCc)
                    .HasColumnName("OBS_CC")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ObsFrancais)
                    .HasColumnName("OBS_FRANCAIS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ObsRapport)
                    .HasColumnName("OBS_RAPPORT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ObsTech)
                    .HasColumnName("OBS_TECH")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemarqueObs)
                    .HasColumnName("REMARQUE_OBS")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TravauxDemande)
                    .HasColumnName("TRAVAUX_DEMANDE")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TypeProjet)
                    .IsRequired()
                    .HasColumnName("TYPE_PROJET")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEncadrementGp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_ENCADREMENT_GP");

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AvAng).HasColumnName("AV_ANG");

                entity.Property(e => e.AvCc).HasColumnName("AV_CC");

                entity.Property(e => e.AvFr).HasColumnName("AV_FR");

                entity.Property(e => e.AvRapport).HasColumnName("AV_RAPPORT");

                entity.Property(e => e.AvTech).HasColumnName("AV_TECH");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comportement)
                    .HasColumnName("COMPORTEMENT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DateEnc)
                    .HasColumnName("DATE_ENC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Duree)
                    .HasColumnName("DUREE")
                    .HasColumnType("DATE");

                entity.Property(e => e.HeureDeb)
                    .HasColumnName("HEURE_DEB")
                    .HasColumnType("DATE");

                entity.Property(e => e.HeureFin)
                    .HasColumnName("HEURE_FIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEns)
                    .IsRequired()
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdGroupeProjet)
                    .HasColumnName("ID_GROUPE_PROJET")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.IdProjet)
                    .IsRequired()
                    .HasColumnName("ID_PROJET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoteGroupe).HasColumnName("NOTE_GROUPE");

                entity.Property(e => e.RemarqueObs)
                    .HasColumnName("REMARQUE_OBS")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TravauxDemande)
                    .HasColumnName("TRAVAUX_DEMANDE")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TypeProjet)
                    .IsRequired()
                    .HasColumnName("TYPE_PROJET")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEnseignant>(entity =>
            {
                entity.HasKey(e => e.IdEns);

                entity.ToTable("ESP_ENSEIGNANT");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeEns)
                    .HasColumnName("CHARGE_ENS")
                    .HasColumnType("NUMBER(7,2)");

                entity.Property(e => e.Cin)
                    .HasColumnName("CIN")
                    .HasColumnType("NUMBER(19,2)");

                entity.Property(e => e.CnssEns)
                    .HasColumnName("CNSS_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeGradeActuel)
                    .HasColumnName("CODE_GRADE_ACTUEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeGradeEntree)
                    .HasColumnName("CODE_GRADE_ENTREE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateModifyJwtPwd)
                    .HasColumnName("DATE_MODIFY_JWT_PWD")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.DateRec)
                    .HasColumnName("DATE_REC")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCivilEns)
                    .HasColumnName("ETAT_CIVIL_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LibGradeActuelle)
                    .HasColumnName("LIB_GRADE_ACTUELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LibGradeEntree)
                    .HasColumnName("LIB_GRADE_ENTREE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailEns)
                    .HasColumnName("MAIL_ENS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NbHeureEns)
                    .HasColumnName("NB_HEURE_ENS")
                    .HasColumnType("NUMBER(7,2)");

                entity.Property(e => e.Niveau)
                    .HasColumnName("NIVEAU")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomEns)
                    .HasColumnName("NOM_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomEns)
                    .HasColumnName("PRENOM_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PwdEns)
                    .HasColumnName("PWD_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PwdInit)
                    .HasColumnName("PWD_INIT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PwdJwtEnseignant)
                    .HasColumnName("PWD_JWT_ENSEIGNANT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SexeEns)
                    .HasColumnName("SEXE_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("TEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEns)
                    .HasColumnName("TYPE_ENS")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEnseignantFichepfe>(entity =>
            {
                entity.HasKey(e => new { e.EspEnseignantIdEns, e.FichepfesIdFiche })
                    .HasName("SYS_C0011507");

                entity.ToTable("ESP_ENSEIGNANT_FICHEPFE");

                entity.HasIndex(e => e.FichepfesIdFiche)
                    .HasName("SYS_C0011509")
                    .IsUnique();

                entity.Property(e => e.EspEnseignantIdEns)
                    .HasColumnName("ESP_ENSEIGNANT_ID_ENS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FichepfesIdFiche).HasColumnName("FICHEPFES_ID_FICHE");
            });

            modelBuilder.Entity<EspEnteteAbsence>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.CodeModule, e.NumSeance, e.DateSeance, e.CodeCl })
                    .HasName("PK_ENTETE_ABSENCE_ESP_ENTE");

                entity.ToTable("ESP_ENTETE_ABSENCE");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumSeance)
                    .HasColumnName("NUM_SEANCE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateSeance)
                    .HasColumnName("DATE_SEANCE")
                    .HasColumnType("DATE");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastModif)
                    .HasColumnName("DATE_LAST_MODIF")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NewSemestre)
                    .HasColumnName("NEW_SEMESTRE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEnteteNote>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.CodeCl, e.CodeModule, e.Semestre });

                entity.ToTable("ESP_ENTETE_NOTE");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.AnneeFin)
                    .HasColumnName("ANNEE_FIN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Coef)
                    .HasColumnName("COEF")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.ConfRattrapage)
                    .HasColumnName("CONF_RATTRAPAGE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmNew)
                    .HasColumnName("CONFIRM_NEW")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Confirmation)
                    .HasColumnName("CONFIRMATION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateConfRatt)
                    .HasColumnName("DATE_CONF_RATT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateConfirmation)
                    .HasColumnName("DATE_CONFIRMATION")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateDeroulement)
                    .HasColumnName("DATE_DEROULEMENT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateLastModif)
                    .HasColumnName("DATE_LAST_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateRatrap)
                    .HasColumnName("DATE_RATRAP")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.ExisteNoteCc)
                    .HasColumnName("EXISTE_NOTE_CC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ExisteNoteTp)
                    .HasColumnName("EXISTE_NOTE_TP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .IsRequired()
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleFantome)
                    .HasColumnName("MODULE_FANTOME")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.NatureNote)
                    .HasColumnName("NATURE_NOTE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NbHeure)
                    .HasColumnName("NB_HEURE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.NumPanier)
                    .HasColumnName("NUM_PANIER")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Numpromotioncs)
                    .HasColumnName("NUMPROMOTIONCS")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TatouageEns)
                    .HasColumnName("TATOUAGE_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TauxCc)
                    .HasColumnName("TAUX_CC")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TauxCcLang)
                    .HasColumnName("TAUX_CC_LANG")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TauxEcritLang)
                    .HasColumnName("TAUX_ECRIT_LANG")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TauxExam)
                    .HasColumnName("TAUX_EXAM")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TauxOralLang)
                    .HasColumnName("TAUX_ORAL_LANG")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TauxTp)
                    .HasColumnName("TAUX_TP")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TypeSession)
                    .HasColumnName("TYPE_SESSION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserConfirm)
                    .HasColumnName("USER_CONFIRM")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.UserConfirmRatt)
                    .HasColumnName("USER_CONFIRM_RATT")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.UserLastModif)
                    .HasColumnName("USER_LAST_MODIF")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEnteteNoteRat>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.CodeModule, e.TypeRat, e.DateDeroulement })
                    .HasName("PK_ENTETE_NOTE_RAT");

                entity.ToTable("ESP_ENTETE_NOTE_RAT");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeRat)
                    .HasColumnName("TYPE_RAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateDeroulement)
                    .HasColumnName("DATE_DEROULEMENT")
                    .HasColumnType("DATE");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NbHeure)
                    .HasColumnName("NB_HEURE")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEtNotTransfFin>(entity =>
            {
                entity.HasKey(e => e.IdEt)
                    .HasName("PK_ET_NOT_TRANS");

                entity.ToTable("ESP_ET_NOT_TRANSF_FIN");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateTransf)
                    .HasColumnName("DATE_TRANSF")
                    .HasColumnType("DATE");

                entity.Property(e => e.JustifNotTransf)
                    .HasColumnName("JUSTIF_NOT_TRANSF")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Numcompte)
                    .HasColumnName("NUMCOMPTE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Transferrred)
                    .HasColumnName("TRANSFERRRED")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEtatNav>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_ETAT_NAV");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'F' ");

                entity.Property(e => e.Formule)
                    .HasColumnName("FORMULE")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.IdentifiantEtudiant)
                    .HasColumnName("IDENTIFIANT_ETUDIANT")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.NumCompte)
                    .HasColumnName("NUM_COMPTE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SoldeDs)
                    .HasColumnName("SOLDE_DS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SoldeEt)
                    .HasColumnName("SOLDE_ET")
                    .HasColumnType("NUMBER(10,3)");
            });

            modelBuilder.Entity<EspEtatNavTmp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_ETAT_NAV_TMP1");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Formule)
                    .HasColumnName("FORMULE")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.IdentifiantEtudiant)
                    .HasColumnName("IDENTIFIANT_ETUDIANT")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.NumCompte)
                    .HasColumnName("NUM_COMPTE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SoldeDs)
                    .HasColumnName("SOLDE_DS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEtatSolde>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_ETAT_SOLDE");

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEtudiant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_ETUDIANT");

                entity.Property(e => e.AdresseEt)
                    .HasColumnName("ADRESSE_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdresseMailEsp)
                    .HasColumnName("ADRESSE_MAIL_ESP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdresseParent)
                    .HasColumnName("ADRESSE_PARENT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Agent)
                    .HasColumnName("AGENT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeBac)
                    .HasColumnName("ANNEE_BAC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDiplome)
                    .HasColumnName("ANNEE_DIPLOME")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeEntreeEspEt)
                    .HasColumnName("ANNEE_ENTREE_ESP_ET")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Banque)
                    .HasColumnName("BANQUE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatEtabOrigine)
                    .HasColumnName("CAT_ETAB_ORIGINE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ChoixAB)
                    .HasColumnName("CHOIX_A_B")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ClasseCouranteEt)
                    .HasColumnName("CLASSE_COURANTE_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClassePrecEt)
                    .HasColumnName("CLASSE_PREC_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeBarre)
                    .HasColumnName("CODE_BARRE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDecisionSessionPAp1)
                    .HasColumnName("CODE_DECISION_SESSION_P_AP1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDecisionSessionPAp2)
                    .HasColumnName("CODE_DECISION_SESSION_P_AP2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDecisionSessionPAp3)
                    .HasColumnName("CODE_DECISION_SESSION_P_AP3")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDecisionSessionRAp1)
                    .HasColumnName("CODE_DECISION_SESSION_R_AP1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDecisionSessionRAp2)
                    .HasColumnName("CODE_DECISION_SESSION_R_AP2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDecisionSessionRAp3)
                    .HasColumnName("CODE_DECISION_SESSION_R_AP3")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeEtabOrigine)
                    .HasColumnName("CODE_ETAB_ORIGINE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeGouvernorat)
                    .HasColumnName("CODE_GOUVERNORAT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeNationalite)
                    .HasColumnName("CODE_NATIONALITE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeRfid)
                    .HasColumnName("CODE_RFID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeSpecOrigine)
                    .HasColumnName("CODE_SPEC_ORIGINE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ComiteIdGrp).HasColumnName("COMITE_ID_GRP");

                entity.Property(e => e.CpEt)
                    .HasColumnName("CP_ET")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CpParent)
                    .HasColumnName("CP_PARENT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CycleEt)
                    .HasColumnName("CYCLE_ET")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DateBac)
                    .HasColumnName("DATE_BAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateDelivrance)
                    .HasColumnName("DATE_DELIVRANCE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateDernModif)
                    .HasColumnName("DATE_DERN_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateEntreeEspEt)
                    .HasColumnName("DATE_ENTREE_ESP_ET")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateHeureCreation)
                    .HasColumnName("DATE_HEURE_CREATION")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastChangeEtat)
                    .HasColumnName("DATE_LAST_CHANGE_ETAT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateLieuNais)
                    .HasColumnName("DATE_LIEU_NAIS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateNaisEt)
                    .HasColumnName("DATE_NAIS_ET")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateSortieEt)
                    .HasColumnName("DATE_SORTIE_ET")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateTransfPreinscrit)
                    .HasColumnName("DATE_TRANSF_PREINSCRIT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Dateentr)
                    .HasColumnName("DATEENTR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DernUtilisateur)
                    .HasColumnName("DERN_UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DiplomeObtenuEspEt)
                    .HasColumnName("DIPLOME_OBTENU_ESP_ET")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DiplomeSupArb)
                    .HasColumnName("DIPLOME_SUP_ARB")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DiplomeSupEt)
                    .HasColumnName("DIPLOME_SUP_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EMailEt)
                    .HasColumnName("E_MAIL_ET")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.EMailParent)
                    .HasColumnName("E_MAIL_PARENT")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.EmailMereEt)
                    .HasColumnName("EMAIL_MERE_ET")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmailPereEt)
                    .HasColumnName("EMAIL_PERE_ET")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EnsIdEns)
                    .HasColumnName("ENS_ID_ENS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EntretienAnglais)
                    .HasColumnName("ENTRETIEN_ANGLAIS")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.EntretienFrancais)
                    .HasColumnName("ENTRETIEN_FRANCAIS")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.EtabBac)
                    .HasColumnName("ETAB_BAC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtabOriginNew)
                    .HasColumnName("ETAB_ORIGIN_NEW")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EtabOrigine)
                    .HasColumnName("ETAB_ORIGINE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtabOrigineArb)
                    .HasColumnName("ETAB_ORIGINE_ARB")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.FilierePrepa)
                    .HasColumnName("FILIERE_PREPA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FkEns)
                    .HasColumnName("FK_ENS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FkEnsei)
                    .HasColumnName("FK_ENSEI")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FonctionEt)
                    .HasColumnName("FONCTION_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FonctionMereEt)
                    .HasColumnName("FONCTION_MERE_ET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FonctionPereEt)
                    .HasColumnName("FONCTION_PERE_ET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gouvernorat)
                    .HasColumnName("GOUVERNORAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupeTarif)
                    .HasColumnName("GROUPE_TARIF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEleveEduserv)
                    .HasColumnName("ID_ELEVE_EDUSERV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEtNew)
                    .HasColumnName("ID_ET_NEW")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEtOrigin)
                    .HasColumnName("ID_ET_ORIGIN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEtOrigine)
                    .HasColumnName("ID_ET_ORIGINE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JustifEtat)
                    .HasColumnName("JUSTIF_ETAT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LibDecisionSessionPAp1)
                    .HasColumnName("LIB_DECISION_SESSION_P_AP1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LibDecisionSessionPAp2)
                    .HasColumnName("LIB_DECISION_SESSION_P_AP2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LibDecisionSessionPAp3)
                    .HasColumnName("LIB_DECISION_SESSION_P_AP3")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LibDecisionSessionRAp1)
                    .HasColumnName("LIB_DECISION_SESSION_R_AP1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LibDecisionSessionRAp2)
                    .HasColumnName("LIB_DECISION_SESSION_R_AP2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LibDecisionSessionRAp3)
                    .HasColumnName("LIB_DECISION_SESSION_R_AP3")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LibFilierePrepa)
                    .HasColumnName("LIB_FILIERE_PREPA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LibJustifEtat)
                    .HasColumnName("LIB_JUSTIF_ETAT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LibSpecOrigine)
                    .HasColumnName("LIB_SPEC_ORIGINE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LieuDelivrance)
                    .HasColumnName("LIEU_DELIVRANCE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LieuNaisArb)
                    .HasColumnName("LIEU_NAIS_ARB")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LieuNaisEt)
                    .HasColumnName("LIEU_NAIS_ET")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasColumnName("LOGIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MoyBac)
                    .HasColumnName("MOY_BAC")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyBacEt)
                    .HasColumnName("MOY_BAC_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MoyBacEt2)
                    .HasColumnName("MOY_BAC_ET2")
                    .HasColumnType("NUMBER(5,2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MoyPAp1)
                    .HasColumnName("MOY_P_AP1")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyPAp2)
                    .HasColumnName("MOY_P_AP2")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyPAp3)
                    .HasColumnName("MOY_P_AP3")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyRAp1)
                    .HasColumnName("MOY_R_AP1")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyRAp2)
                    .HasColumnName("MOY_R_AP2")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyRAp3)
                    .HasColumnName("MOY_R_AP3")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyenneDernSemestreEt)
                    .HasColumnName("MOYENNE_DERN_SEMESTRE_ET")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.Mp08)
                    .HasColumnName("MP08")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nationalite)
                    .HasColumnName("NATIONALITE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NatureBac)
                    .HasColumnName("NATURE_BAC")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NatureBacArb)
                    .HasColumnName("NATURE_BAC_ARB")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NatureCours)
                    .HasColumnName("NATURE_COURS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NatureEt)
                    .HasColumnName("NATURE_ET")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NaturePieceId)
                    .HasColumnName("NATURE_PIECE_ID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NbImpReleve)
                    .HasColumnName("NB_IMP_RELEVE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.NiveauAcces).HasColumnName("NIVEAU_ACCES");

                entity.Property(e => e.NiveauCourantAng)
                    .HasColumnName("NIVEAU_COURANT_ANG")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NiveauCourantEt).HasColumnName("NIVEAU_COURANT_ET");

                entity.Property(e => e.NiveauCourantFr)
                    .HasColumnName("NIVEAU_COURANT_FR")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NiveauDiplomeSupEt)
                    .HasColumnName("NIVEAU_DIPLOME_SUP_ET")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.NomArb)
                    .HasColumnName("NOM_ARB")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.NomMereEt)
                    .HasColumnName("NOM_MERE_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomPereEt)
                    .HasColumnName("NOM_PERE_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumAnnexe)
                    .HasColumnName("NUM_ANNEXE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.NumAnnuelDiplome)
                    .HasColumnName("NUM_ANNUEL_DIPLOME")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NumBacEt)
                    .HasColumnName("NUM_BAC_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumCinPasseport)
                    .HasColumnName("NUM_CIN_PASSEPORT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumLot).HasColumnName("NUM_LOT");

                entity.Property(e => e.NumOrd)
                    .HasColumnName("NUM_ORD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Numcompte)
                    .HasColumnName("NUMCOMPTE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Numpromotioncs)
                    .HasColumnName("NUMPROMOTIONCS")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.ObservationEt)
                    .HasColumnName("OBSERVATION_ET")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OraRowscn)
                    .HasColumnName("ORA_ROWSCN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Orientation)
                    .HasColumnName("ORIENTATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaysEt)
                    .HasColumnName("PAYS_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaysParent)
                    .HasColumnName("PAYS_PARENT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PnomArb)
                    .HasColumnName("PNOM_ARB")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PwdEt)
                    .HasColumnName("PWD_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PwdEtInit)
                    .HasColumnName("PWD_ET_INIT")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PwdParent)
                    .HasColumnName("PWD_PARENT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Recommandation)
                    .HasColumnName("RECOMMANDATION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ResultatFinalEt)
                    .HasColumnName("RESULTAT_FINAL_ET")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RibBanque)
                    .HasColumnName("RIB_BANQUE")
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.ScoreFinal)
                    .HasColumnName("SCORE_FINAL")
                    .HasColumnType("NUMBER(10,3)")
                    .HasDefaultValueSql("66.66");

                entity.Property(e => e.ScoreMinAdmin)
                    .HasColumnName("SCORE_MIN_ADMIN")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.Sexe)
                    .HasColumnName("SEXE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SituationFinanciereEt)
                    .HasColumnName("SITUATION_FINANCIERE_ET")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialiteEspEt)
                    .HasColumnName("SPECIALITE_ESP_ET")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SuiviParticulier)
                    .HasColumnName("SUIVI_PARTICULIER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.TelEt)
                    .HasColumnName("TEL_ET")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.TelEt1)
                    .HasColumnName("TEL_ET1")
                    .HasColumnType("NUMBER(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TelMereEt)
                    .HasColumnName("TEL_MERE_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelParent)
                    .HasColumnName("TEL_PARENT")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TelParentEt)
                    .HasColumnName("TEL_PARENT_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TelPereEt)
                    .HasColumnName("TEL_PERE_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEnregEt)
                    .HasColumnName("TYPE_ENREG_ET")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEt)
                    .HasColumnName("TYPE_ET")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserTransfPreinscrit)
                    .HasColumnName("USER_TRANSF_PREINSCRIT")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VilleEt)
                    .HasColumnName("VILLE_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VilleParent)
                    .HasColumnName("VILLE_PARENT")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEtudiant2013>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_ETUDIANT_2013");

                entity.Property(e => e.AdresseEt)
                    .HasColumnName("ADRESSE_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdresseMailEsp)
                    .HasColumnName("ADRESSE_MAIL_ESP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .IsRequired()
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeClPrec)
                    .HasColumnName("CODE_CL_PREC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EMailEt)
                    .HasColumnName("E_MAIL_ET")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumCinPasseport)
                    .HasColumnName("NUM_CIN_PASSEPORT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialiteEspEt)
                    .HasColumnName("SPECIALITE_ESP_ET")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TelEt)
                    .HasColumnName("TEL_ET")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEtudiantEnreg>(entity =>
            {
                entity.HasKey(e => e.IdEt)
                    .HasName("ESP_ETUDIANT_ENREG_PK");

                entity.ToTable("ESP_ETUDIANT_ENREG");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasColumnType("CHAR(16)");

                entity.Property(e => e.Admis)
                    .HasColumnName("ADMIS")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.AdresseEt)
                    .HasColumnName("ADRESSE_ET")
                    .HasColumnType("CHAR(100)");

                entity.Property(e => e.AdresseParent)
                    .HasColumnName("ADRESSE_PARENT")
                    .HasColumnType("CHAR(100)");

                entity.Property(e => e.Agent)
                    .HasColumnName("AGENT")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.AnneeAdmission)
                    .HasColumnName("ANNEE_ADMISSION")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeBac)
                    .HasColumnName("ANNEE_BAC")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.AnneeDiplome)
                    .HasColumnName("ANNEE_DIPLOME")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.AnneeEntreeEspEt)
                    .HasColumnName("ANNEE_ENTREE_ESP_ET")
                    .HasColumnType("CHAR(4)");

                entity.Property(e => e.Banque)
                    .HasColumnName("BANQUE")
                    .HasColumnType("CHAR(50)");

                entity.Property(e => e.ClasseCouranteEt)
                    .HasColumnName("CLASSE_COURANTE_ET")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.ClassePrecEt)
                    .HasColumnName("CLASSE_PREC_ET")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.CodeBarre)
                    .HasColumnName("CODE_BARRE")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.CodeDecision)
                    .HasColumnName("CODE_DECISION")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDecisionSessionPAp1)
                    .HasColumnName("CODE_DECISION_SESSION_P_AP1")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.CodeDecisionSessionPAp2)
                    .HasColumnName("CODE_DECISION_SESSION_P_AP2")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.CodeDecisionSessionPAp3)
                    .HasColumnName("CODE_DECISION_SESSION_P_AP3")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.CodeDecisionSessionRAp1)
                    .HasColumnName("CODE_DECISION_SESSION_R_AP1")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.CodeDecisionSessionRAp2)
                    .HasColumnName("CODE_DECISION_SESSION_R_AP2")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.CodeDecisionSessionRAp3)
                    .HasColumnName("CODE_DECISION_SESSION_R_AP3")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.CodeDecisionTemp)
                    .HasColumnName("CODE_DECISION_TEMP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeEtabOrigine)
                    .HasColumnName("CODE_ETAB_ORIGINE")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.CodeNationalite)
                    .HasColumnName("CODE_NATIONALITE")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.CodeSpecOrigine)
                    .HasColumnName("CODE_SPEC_ORIGINE")
                    .HasColumnType("CHAR(3)");

                entity.Property(e => e.ComiteIdGrp).HasColumnName("COMITE_ID_GRP");

                entity.Property(e => e.Convocation)
                    .HasColumnName("CONVOCATION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ConvocationEntretien)
                    .HasColumnName("CONVOCATION_ENTRETIEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.CpEt)
                    .HasColumnName("CP_ET")
                    .HasColumnType("CHAR(6)");

                entity.Property(e => e.CpParent)
                    .HasColumnName("CP_PARENT")
                    .HasColumnType("CHAR(6)");

                entity.Property(e => e.CycleEt)
                    .HasColumnName("CYCLE_ET")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.DateBac)
                    .HasColumnName("DATE_BAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateCalculScoreF)
                    .HasColumnName("DATE_CALCUL_SCORE_F")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateConvocation)
                    .HasColumnName("DATE_CONVOCATION")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateDelivrance)
                    .HasColumnName("DATE_DELIVRANCE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateDernModif)
                    .HasColumnName("DATE_DERN_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateEntreeEspEt)
                    .HasColumnName("DATE_ENTREE_ESP_ET")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateEnvoieDecision)
                    .HasColumnName("DATE_ENVOIE_DECISION")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateLastChangeEtat)
                    .HasColumnName("DATE_LAST_CHANGE_ETAT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateLieuNais)
                    .HasColumnName("DATE_LIEU_NAIS")
                    .HasColumnType("CHAR(50)");

                entity.Property(e => e.DateNaisEt)
                    .HasColumnName("DATE_NAIS_ET")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSortieEt)
                    .HasColumnName("DATE_SORTIE_ET")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateTest)
                    .HasColumnName("DATE_TEST")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateTranspo)
                    .HasColumnName("DATE_TRANSPO")
                    .HasColumnType("DATE");

                entity.Property(e => e.Dateentr)
                    .HasColumnName("DATEENTR")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.DecisionEnvoyee)
                    .HasColumnName("DECISION_ENVOYEE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DernUtilisateur)
                    .HasColumnName("DERN_UTILISATEUR")
                    .HasColumnType("CHAR(16)");

                entity.Property(e => e.DiplomeObtenuEspEt)
                    .HasColumnName("DIPLOME_OBTENU_ESP_ET")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.DiplomeSupEt)
                    .HasColumnName("DIPLOME_SUP_ET")
                    .HasColumnType("CHAR(100)");

                entity.Property(e => e.EMailEt)
                    .HasColumnName("E_MAIL_ET")
                    .HasColumnType("CHAR(60)");

                entity.Property(e => e.EMailParent)
                    .HasColumnName("E_MAIL_PARENT")
                    .HasColumnType("CHAR(60)");

                entity.Property(e => e.EmailMereEt)
                    .HasColumnName("EMAIL_MERE_ET")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.EmailPereEt)
                    .HasColumnName("EMAIL_PERE_ET")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.EnsIdEns)
                    .HasColumnName("ENS_ID_ENS")
                    .HasColumnType("CHAR(255)");

                entity.Property(e => e.EntretienAnglais)
                    .HasColumnName("ENTRETIEN_ANGLAIS")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.EntretienFrancais)
                    .HasColumnName("ENTRETIEN_FRANCAIS")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.EnvoiDossier)
                    .HasColumnName("ENVOI_DOSSIER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.EtabBac)
                    .HasColumnName("ETAB_BAC")
                    .HasColumnType("CHAR(100)");

                entity.Property(e => e.EtabOrigine)
                    .HasColumnName("ETAB_ORIGINE")
                    .HasColumnType("CHAR(100)");

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.FkEns)
                    .HasColumnName("FK_ENS")
                    .HasColumnType("CHAR(255)");

                entity.Property(e => e.FkEnsei)
                    .HasColumnName("FK_ENSEI")
                    .HasColumnType("CHAR(255)");

                entity.Property(e => e.FonctionEt)
                    .HasColumnName("FONCTION_ET")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.FonctionMereEt)
                    .HasColumnName("FONCTION_MERE_ET")
                    .HasColumnType("CHAR(50)");

                entity.Property(e => e.FonctionPereEt)
                    .HasColumnName("FONCTION_PERE_ET")
                    .HasColumnType("CHAR(50)");

                entity.Property(e => e.Gouvernorat)
                    .HasColumnName("GOUVERNORAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEnsEntretien)
                    .HasColumnName("ID_ENS_ENTRETIEN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEtNew)
                    .HasColumnName("ID_ET_NEW")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.IdEtOrigin)
                    .HasColumnName("ID_ET_ORIGIN")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.IdEtOrigine)
                    .HasColumnName("ID_ET_ORIGINE")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.JustifEtat)
                    .HasColumnName("JUSTIF_ETAT")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.LibDecision)
                    .HasColumnName("LIB_DECISION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LibDecisionSessionPAp1)
                    .HasColumnName("LIB_DECISION_SESSION_P_AP1")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.LibDecisionSessionPAp2)
                    .HasColumnName("LIB_DECISION_SESSION_P_AP2")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.LibDecisionSessionPAp3)
                    .HasColumnName("LIB_DECISION_SESSION_P_AP3")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.LibDecisionSessionRAp1)
                    .HasColumnName("LIB_DECISION_SESSION_R_AP1")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.LibDecisionSessionRAp2)
                    .HasColumnName("LIB_DECISION_SESSION_R_AP2")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.LibDecisionSessionRAp3)
                    .HasColumnName("LIB_DECISION_SESSION_R_AP3")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.LibJustifEtat)
                    .HasColumnName("LIB_JUSTIF_ETAT")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.LibSpecOrigine)
                    .HasColumnName("LIB_SPEC_ORIGINE")
                    .HasColumnType("CHAR(100)");

                entity.Property(e => e.LieuDelivrance)
                    .HasColumnName("LIEU_DELIVRANCE")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.LieuNaisEt)
                    .HasColumnName("LIEU_NAIS_ET")
                    .HasColumnType("CHAR(50)");

                entity.Property(e => e.Login)
                    .HasColumnName("LOGIN")
                    .HasColumnType("CHAR(50)");

                entity.Property(e => e.MoyBac)
                    .HasColumnName("MOY_BAC")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.MoyBacEt)
                    .HasColumnName("MOY_BAC_ET")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.MoyBacEt2)
                    .HasColumnName("MOY_BAC_ET2")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyPAp1)
                    .HasColumnName("MOY_P_AP1")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyPAp2)
                    .HasColumnName("MOY_P_AP2")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyPAp3)
                    .HasColumnName("MOY_P_AP3")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyRAp1)
                    .HasColumnName("MOY_R_AP1")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyRAp2)
                    .HasColumnName("MOY_R_AP2")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyRAp3)
                    .HasColumnName("MOY_R_AP3")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyenneDernSemestreEt)
                    .HasColumnName("MOYENNE_DERN_SEMESTRE_ET")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.Mp08)
                    .HasColumnName("MP08")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.Nationalite)
                    .HasColumnName("NATIONALITE")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.NatureBac)
                    .HasColumnName("NATURE_BAC")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.NatureCours)
                    .HasColumnName("NATURE_COURS")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.NatureEt)
                    .HasColumnName("NATURE_ET")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.NaturePieceId)
                    .HasColumnName("NATURE_PIECE_ID")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.NbImpReleve)
                    .HasColumnName("NB_IMP_RELEVE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.NiveauAcces).HasColumnName("NIVEAU_ACCES");

                entity.Property(e => e.NiveauCourantEt).HasColumnName("NIVEAU_COURANT_ET");

                entity.Property(e => e.NiveauDiplomeSupEt)
                    .HasColumnName("NIVEAU_DIPLOME_SUP_ET")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.NomMereEt)
                    .HasColumnName("NOM_MERE_ET")
                    .HasColumnType("CHAR(35)");

                entity.Property(e => e.NomPereEt)
                    .HasColumnName("NOM_PERE_ET")
                    .HasColumnType("CHAR(35)");

                entity.Property(e => e.NumBacEt)
                    .HasColumnName("NUM_BAC_ET")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.NumCinPasseport)
                    .HasColumnName("NUM_CIN_PASSEPORT")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.NumOrd)
                    .HasColumnName("NUM_ORD")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.NumSession).HasColumnName("NUM_SESSION");

                entity.Property(e => e.Numcompte)
                    .HasColumnName("NUMCOMPTE")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.Numpromotioncs)
                    .HasColumnName("NUMPROMOTIONCS")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.ObservationEt)
                    .HasColumnName("OBSERVATION_ET")
                    .HasColumnType("CHAR(1000)");

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasColumnType("CHAR(50)");

                entity.Property(e => e.PaysEt)
                    .HasColumnName("PAYS_ET")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.PaysParent)
                    .HasColumnName("PAYS_PARENT")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.ResultatFinalEt)
                    .HasColumnName("RESULTAT_FINAL_ET")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.RibBanque)
                    .HasColumnName("RIB_BANQUE")
                    .HasColumnType("CHAR(22)");

                entity.Property(e => e.ScoreAnglais)
                    .HasColumnName("SCORE_ANGLAIS")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreDossier)
                    .HasColumnName("SCORE_DOSSIER")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreEntretien)
                    .HasColumnName("SCORE_ENTRETIEN")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreEpEcrite)
                    .HasColumnName("SCORE_EP_ECRITE")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreFinal)
                    .HasColumnName("SCORE_FINAL")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.ScoreFinalInit)
                    .HasColumnName("SCORE_FINAL_INIT")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.ScoreFrancais)
                    .HasColumnName("SCORE_FRANCAIS")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreQi)
                    .HasColumnName("SCORE_QI")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreTest).HasColumnName("SCORE_TEST");

                entity.Property(e => e.Sexe)
                    .HasColumnName("SEXE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.SituationFinanciereEt)
                    .HasColumnName("SITUATION_FINANCIERE_ET")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.SpecialiteEspEt)
                    .HasColumnName("SPECIALITE_ESP_ET")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.TelEt)
                    .HasColumnName("TEL_ET")
                    .HasColumnType("CHAR(120)");

                entity.Property(e => e.TelEt1)
                    .HasColumnName("TEL_ET1")
                    .HasColumnType("NUMBER(20)");

                entity.Property(e => e.TelMereEt)
                    .HasColumnName("TEL_MERE_ET")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.TelParent)
                    .HasColumnName("TEL_PARENT")
                    .HasColumnType("CHAR(40)");

                entity.Property(e => e.TelParentEt)
                    .HasColumnName("TEL_PARENT_ET")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.TelPereEt)
                    .HasColumnName("TEL_PERE_ET")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.TypeDecision)
                    .HasColumnName("TYPE_DECISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.TypeEnregEt)
                    .HasColumnName("TYPE_ENREG_ET")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.TypeEt)
                    .HasColumnName("TYPE_ET")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.VilleEt)
                    .HasColumnName("VILLE_ET")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.VilleParent)
                    .HasColumnName("VILLE_PARENT")
                    .HasColumnType("CHAR(30)");
            });

            modelBuilder.Entity<EspEtudiantNoteGroupe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_ETUDIANT_NOTE_GROUPE");

                entity.Property(e => e.AbsEt)
                    .HasColumnName("ABS_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateEval)
                    .HasColumnName("DATE_EVAL")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdGroupeProjet)
                    .IsRequired()
                    .HasColumnName("ID_GROUPE_PROJET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoteEt).HasColumnName("NOTE_ET");

                entity.Property(e => e.Remarque)
                    .HasColumnName("REMARQUE")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEtudiantSeminaire>(entity =>
            {
                entity.HasKey(e => new { e.SeminaireIdseminaire, e.EtdsIdEt })
                    .HasName("SYS_C0011543");

                entity.ToTable("ESP_ETUDIANT_SEMINAIRE");

                entity.Property(e => e.SeminaireIdseminaire).HasColumnName("SEMINAIRE_IDSEMINAIRE");

                entity.Property(e => e.EtdsIdEt)
                    .HasColumnName("ETDS_ID_ET")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.SeminaireIdseminaireNavigation)
                    .WithMany(p => p.EspEtudiantSeminaire)
                    .HasForeignKey(d => d.SeminaireIdseminaire)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SPTDNTSEMINAIRESMNRIDSEMINAIRE");
            });

            modelBuilder.Entity<EspEtudiantTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_ETUDIANT_TMP");

                entity.Property(e => e.Admis)
                    .HasColumnName("ADMIS")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.AdresseEt)
                    .HasColumnName("ADRESSE_ET")
                    .HasColumnType("CHAR(100)");

                entity.Property(e => e.AdresseParent)
                    .HasColumnName("ADRESSE_PARENT")
                    .HasColumnType("CHAR(100)");

                entity.Property(e => e.Agent)
                    .HasColumnName("AGENT")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.AnneeAdmission)
                    .HasColumnName("ANNEE_ADMISSION")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeBac)
                    .HasColumnName("ANNEE_BAC")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.AnneeDiplome)
                    .HasColumnName("ANNEE_DIPLOME")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.AnneeEntreeEspEt)
                    .HasColumnName("ANNEE_ENTREE_ESP_ET")
                    .HasColumnType("CHAR(4)");

                entity.Property(e => e.Banque)
                    .HasColumnName("BANQUE")
                    .HasColumnType("CHAR(50)");

                entity.Property(e => e.ClasseCouranteEt)
                    .HasColumnName("CLASSE_COURANTE_ET")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.ClassePrecEt)
                    .HasColumnName("CLASSE_PREC_ET")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.CodeBarre)
                    .HasColumnName("CODE_BARRE")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.CodeDecision)
                    .HasColumnName("CODE_DECISION")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDecisionSessionPAp1)
                    .HasColumnName("CODE_DECISION_SESSION_P_AP1")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.CodeDecisionSessionPAp2)
                    .HasColumnName("CODE_DECISION_SESSION_P_AP2")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.CodeDecisionSessionPAp3)
                    .HasColumnName("CODE_DECISION_SESSION_P_AP3")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.CodeDecisionSessionRAp1)
                    .HasColumnName("CODE_DECISION_SESSION_R_AP1")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.CodeDecisionSessionRAp2)
                    .HasColumnName("CODE_DECISION_SESSION_R_AP2")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.CodeDecisionSessionRAp3)
                    .HasColumnName("CODE_DECISION_SESSION_R_AP3")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.CodeDecisionTemp)
                    .HasColumnName("CODE_DECISION_TEMP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeEtabOrigine)
                    .HasColumnName("CODE_ETAB_ORIGINE")
                    .HasColumnType("CHAR(3)");

                entity.Property(e => e.CodeNationalite)
                    .HasColumnName("CODE_NATIONALITE")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.CodeSpecOrigine)
                    .HasColumnName("CODE_SPEC_ORIGINE")
                    .HasColumnType("CHAR(3)");

                entity.Property(e => e.ComiteIdGrp).HasColumnName("COMITE_ID_GRP");

                entity.Property(e => e.Convocation)
                    .HasColumnName("CONVOCATION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ConvocationEntretien)
                    .HasColumnName("CONVOCATION_ENTRETIEN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CpEt)
                    .HasColumnName("CP_ET")
                    .HasColumnType("CHAR(6)");

                entity.Property(e => e.CpParent)
                    .HasColumnName("CP_PARENT")
                    .HasColumnType("CHAR(6)");

                entity.Property(e => e.CycleEt)
                    .HasColumnName("CYCLE_ET")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.DateBac)
                    .HasColumnName("DATE_BAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateCalculScoreF)
                    .HasColumnName("DATE_CALCUL_SCORE_F")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateConvocation)
                    .HasColumnName("DATE_CONVOCATION")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateDelivrance)
                    .HasColumnName("DATE_DELIVRANCE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateDernModif)
                    .HasColumnName("DATE_DERN_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateEntreeEspEt)
                    .HasColumnName("DATE_ENTREE_ESP_ET")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateEnvoieDecision)
                    .HasColumnName("DATE_ENVOIE_DECISION")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateLastChangeEtat)
                    .HasColumnName("DATE_LAST_CHANGE_ETAT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateLieuNais)
                    .HasColumnName("DATE_LIEU_NAIS")
                    .HasColumnType("CHAR(50)");

                entity.Property(e => e.DateNaisEt)
                    .HasColumnName("DATE_NAIS_ET")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSortieEt)
                    .HasColumnName("DATE_SORTIE_ET")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateTest)
                    .HasColumnName("DATE_TEST")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateTranspo)
                    .HasColumnName("DATE_TRANSPO")
                    .HasColumnType("DATE");

                entity.Property(e => e.Dateentr)
                    .HasColumnName("DATEENTR")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.DecisionEnvoyee)
                    .HasColumnName("DECISION_ENVOYEE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DernUtilisateur)
                    .HasColumnName("DERN_UTILISATEUR")
                    .HasColumnType("CHAR(16)");

                entity.Property(e => e.DiplomeObtenuEspEt)
                    .HasColumnName("DIPLOME_OBTENU_ESP_ET")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.DiplomeSupEt)
                    .HasColumnName("DIPLOME_SUP_ET")
                    .HasColumnType("CHAR(100)");

                entity.Property(e => e.EMailEt)
                    .HasColumnName("E_MAIL_ET")
                    .HasColumnType("CHAR(60)");

                entity.Property(e => e.EMailParent)
                    .HasColumnName("E_MAIL_PARENT")
                    .HasColumnType("CHAR(60)");

                entity.Property(e => e.EmailMereEt)
                    .HasColumnName("EMAIL_MERE_ET")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.EmailPereEt)
                    .HasColumnName("EMAIL_PERE_ET")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.EnsIdEns)
                    .HasColumnName("ENS_ID_ENS")
                    .HasColumnType("CHAR(255)");

                entity.Property(e => e.EntretienAnglais)
                    .HasColumnName("ENTRETIEN_ANGLAIS")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.EntretienFrancais)
                    .HasColumnName("ENTRETIEN_FRANCAIS")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.EnvoiDossier)
                    .HasColumnName("ENVOI_DOSSIER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtabBac)
                    .HasColumnName("ETAB_BAC")
                    .HasColumnType("CHAR(100)");

                entity.Property(e => e.EtabOrigine)
                    .HasColumnName("ETAB_ORIGINE")
                    .HasColumnType("CHAR(100)");

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.FkEns)
                    .HasColumnName("FK_ENS")
                    .HasColumnType("CHAR(255)");

                entity.Property(e => e.FkEnsei)
                    .HasColumnName("FK_ENSEI")
                    .HasColumnType("CHAR(255)");

                entity.Property(e => e.FonctionEt)
                    .HasColumnName("FONCTION_ET")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.FonctionMereEt)
                    .HasColumnName("FONCTION_MERE_ET")
                    .HasColumnType("CHAR(50)");

                entity.Property(e => e.FonctionPereEt)
                    .HasColumnName("FONCTION_PERE_ET")
                    .HasColumnType("CHAR(50)");

                entity.Property(e => e.Gouvernorat)
                    .HasColumnName("GOUVERNORAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEnsEntretien)
                    .HasColumnName("ID_ENS_ENTRETIEN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasColumnType("CHAR(16)");

                entity.Property(e => e.IdEtNew)
                    .HasColumnName("ID_ET_NEW")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.IdEtOrigin)
                    .HasColumnName("ID_ET_ORIGIN")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.IdEtOrigine)
                    .HasColumnName("ID_ET_ORIGINE")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.JustifEtat)
                    .HasColumnName("JUSTIF_ETAT")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.LibDecision)
                    .HasColumnName("LIB_DECISION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LibDecisionSessionPAp1)
                    .HasColumnName("LIB_DECISION_SESSION_P_AP1")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.LibDecisionSessionPAp2)
                    .HasColumnName("LIB_DECISION_SESSION_P_AP2")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.LibDecisionSessionPAp3)
                    .HasColumnName("LIB_DECISION_SESSION_P_AP3")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.LibDecisionSessionRAp1)
                    .HasColumnName("LIB_DECISION_SESSION_R_AP1")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.LibDecisionSessionRAp2)
                    .HasColumnName("LIB_DECISION_SESSION_R_AP2")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.LibDecisionSessionRAp3)
                    .HasColumnName("LIB_DECISION_SESSION_R_AP3")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.LibJustifEtat)
                    .HasColumnName("LIB_JUSTIF_ETAT")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.LibSpecOrigine)
                    .HasColumnName("LIB_SPEC_ORIGINE")
                    .HasColumnType("CHAR(100)");

                entity.Property(e => e.LieuDelivrance)
                    .HasColumnName("LIEU_DELIVRANCE")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.LieuNaisEt)
                    .HasColumnName("LIEU_NAIS_ET")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.Login)
                    .HasColumnName("LOGIN")
                    .HasColumnType("CHAR(50)");

                entity.Property(e => e.MoyBac)
                    .HasColumnName("MOY_BAC")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.MoyBacEt)
                    .HasColumnName("MOY_BAC_ET")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.MoyBacEt2)
                    .HasColumnName("MOY_BAC_ET2")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyPAp1)
                    .HasColumnName("MOY_P_AP1")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyPAp2)
                    .HasColumnName("MOY_P_AP2")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyPAp3)
                    .HasColumnName("MOY_P_AP3")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyRAp1)
                    .HasColumnName("MOY_R_AP1")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyRAp2)
                    .HasColumnName("MOY_R_AP2")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyRAp3)
                    .HasColumnName("MOY_R_AP3")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyenneDernSemestreEt)
                    .HasColumnName("MOYENNE_DERN_SEMESTRE_ET")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.Mp08)
                    .HasColumnName("MP08")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.Nationalite)
                    .HasColumnName("NATIONALITE")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.NatureBac)
                    .HasColumnName("NATURE_BAC")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.NatureCours)
                    .HasColumnName("NATURE_COURS")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.NatureEt)
                    .HasColumnName("NATURE_ET")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.NaturePieceId)
                    .HasColumnName("NATURE_PIECE_ID")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.NbImpReleve)
                    .HasColumnName("NB_IMP_RELEVE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.NiveauAcces).HasColumnName("NIVEAU_ACCES");

                entity.Property(e => e.NiveauCourantEt).HasColumnName("NIVEAU_COURANT_ET");

                entity.Property(e => e.NiveauDiplomeSupEt)
                    .HasColumnName("NIVEAU_DIPLOME_SUP_ET")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.NomMereEt)
                    .HasColumnName("NOM_MERE_ET")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.NomPereEt)
                    .HasColumnName("NOM_PERE_ET")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.NumBacEt)
                    .HasColumnName("NUM_BAC_ET")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.NumCinPasseport)
                    .HasColumnName("NUM_CIN_PASSEPORT")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.NumOrd)
                    .HasColumnName("NUM_ORD")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.NumSession).HasColumnName("NUM_SESSION");

                entity.Property(e => e.Numcompte)
                    .HasColumnName("NUMCOMPTE")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.Numpromotioncs)
                    .HasColumnName("NUMPROMOTIONCS")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.ObservationEt)
                    .HasColumnName("OBSERVATION_ET")
                    .HasColumnType("CHAR(1000)");

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasColumnType("CHAR(50)");

                entity.Property(e => e.PaysEt)
                    .HasColumnName("PAYS_ET")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.PaysParent)
                    .HasColumnName("PAYS_PARENT")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.ResultatFinalEt)
                    .HasColumnName("RESULTAT_FINAL_ET")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.RibBanque)
                    .HasColumnName("RIB_BANQUE")
                    .HasColumnType("CHAR(22)");

                entity.Property(e => e.ScoreAnglais)
                    .HasColumnName("SCORE_ANGLAIS")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreDossier)
                    .HasColumnName("SCORE_DOSSIER")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreEntretien)
                    .HasColumnName("SCORE_ENTRETIEN")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreEpEcrite)
                    .HasColumnName("SCORE_EP_ECRITE")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreFinal)
                    .HasColumnName("SCORE_FINAL")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.ScoreFinalInit)
                    .HasColumnName("SCORE_FINAL_INIT")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.ScoreFrancais)
                    .HasColumnName("SCORE_FRANCAIS")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreQi)
                    .HasColumnName("SCORE_QI")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.ScoreTest).HasColumnName("SCORE_TEST");

                entity.Property(e => e.Sexe)
                    .HasColumnName("SEXE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.SituationFinanciereEt)
                    .HasColumnName("SITUATION_FINANCIERE_ET")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.SpecialiteEspEt)
                    .HasColumnName("SPECIALITE_ESP_ET")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.TelEt)
                    .HasColumnName("TEL_ET")
                    .HasColumnType("CHAR(120)");

                entity.Property(e => e.TelEt1)
                    .HasColumnName("TEL_ET1")
                    .HasColumnType("NUMBER(20)");

                entity.Property(e => e.TelMereEt)
                    .HasColumnName("TEL_MERE_ET")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.TelParent)
                    .HasColumnName("TEL_PARENT")
                    .HasColumnType("CHAR(40)");

                entity.Property(e => e.TelParentEt)
                    .HasColumnName("TEL_PARENT_ET")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.TelPereEt)
                    .HasColumnName("TEL_PERE_ET")
                    .HasColumnType("CHAR(20)");

                entity.Property(e => e.TypeDecision)
                    .HasColumnName("TYPE_DECISION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEnregEt)
                    .HasColumnName("TYPE_ENREG_ET")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.TypeEt)
                    .HasColumnName("TYPE_ET")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.VilleEt)
                    .HasColumnName("VILLE_ET")
                    .HasColumnType("CHAR(30)");

                entity.Property(e => e.VilleParent)
                    .HasColumnName("VILLE_PARENT")
                    .HasColumnType("CHAR(30)");
            });

            modelBuilder.Entity<EspEtudiantsDiplomes>(entity =>
            {
                entity.HasKey(e => e.IdEt)
                    .HasName("PK_ETUDIANT_DIP");

                entity.ToTable("ESP_ETUDIANTS_DIPLOMES");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.NatureEtude)
                    .HasColumnName("NATURE_ETUDE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NotePfe)
                    .HasColumnName("NOTE_PFE")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.Specialite)
                    .HasColumnName("SPECIALITE")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEvalClModule>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.CodeCl, e.CodeModule, e.CodeCritere })
                    .HasName("PK_EVAL_CL");

                entity.ToTable("ESP_EVAL_CL_MODULE");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasColumnType("CHAR(4)");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.CodeCritere)
                    .HasColumnName("CODE_CRITERE")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.IdEns2)
                    .HasColumnName("ID_ENS2")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.NbPalier1)
                    .HasColumnName("NB_PALIER1")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NbPalier2)
                    .HasColumnName("NB_PALIER2")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NbPalier3)
                    .HasColumnName("NB_PALIER3")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NbPalier4)
                    .HasColumnName("NB_PALIER4")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NbPalier5)
                    .HasColumnName("NB_PALIER5")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NumSemestre).HasColumnName("NUM_SEMESTRE");
            });

            modelBuilder.Entity<EspEvalExamen>(entity =>
            {
                entity.HasKey(e => new { e.CodeModule, e.AnneeDeb, e.IdUser })
                    .HasName("ESP_EVAL_EXAMEN_PK");

                entity.ToTable("ESP_EVAL_EXAMEN");

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Explication)
                    .HasColumnName("EXPLICATION")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ModeEval)
                    .HasColumnName("MODE_EVAL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuotaDs)
                    .HasColumnName("QUOTA_DS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuotaExam)
                    .HasColumnName("QUOTA_EXAM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuotaQcm)
                    .HasColumnName("QUOTA_QCM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuotaTest)
                    .HasColumnName("QUOTA_TEST")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuotaTp)
                    .HasColumnName("QUOTA_TP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeDs)
                    .HasColumnName("TYPE_DS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeExam)
                    .HasColumnName("TYPE_EXAM")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEvaluation>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.AnneeDeb, e.CodeModule, e.CodeCl, e.NumSemestre });

                entity.ToTable("ESP_EVALUATION");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumSemestre).HasColumnName("NUM_SEMESTRE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Ev1).HasColumnName("EV1");

                entity.Property(e => e.Ev2).HasColumnName("EV2");

                entity.Property(e => e.Ev3).HasColumnName("EV3");

                entity.Property(e => e.Ev4).HasColumnName("EV4");

                entity.Property(e => e.Ev5).HasColumnName("EV5");

                entity.Property(e => e.Ev6).HasColumnName("EV6");

                entity.Property(e => e.Proposition)
                    .HasColumnName("PROPOSITION")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PtFaible)
                    .HasColumnName("PT_FAIBLE")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PtFort)
                    .HasColumnName("PT_FORT")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeModuleNavigation)
                    .WithMany(p => p.EspEvaluation)
                    .HasForeignKey(d => d.CodeModule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESP_EVALUATION");
            });

            modelBuilder.Entity<EspEvaluationPrepa>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.CodeCl, e.CodeModule, e.IdEt })
                    .HasName("ESP_EVALUATION_PREPA_PK");

                entity.ToTable("ESP_EVALUATION_PREPA");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AQ1)
                    .HasColumnName("A_Q1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AQ2)
                    .HasColumnName("A_Q2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AQ3)
                    .HasColumnName("A_Q3")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.BQ1)
                    .HasColumnName("B_Q1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BQ2)
                    .HasColumnName("B_Q2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BQ3)
                    .HasColumnName("B_Q3")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BQ4)
                    .HasColumnName("B_Q4")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BQ5)
                    .HasColumnName("B_Q5")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BQ51)
                    .HasColumnName("B_Q51")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.BQ6)
                    .HasColumnName("B_Q6")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.BQ7)
                    .HasColumnName("B_Q7")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.BQ8)
                    .HasColumnName("B_Q8")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CQ1)
                    .HasColumnName("C_Q1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CQ2)
                    .HasColumnName("C_Q2")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CQ3)
                    .HasColumnName("C_Q3")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CQ4)
                    .HasColumnName("C_Q4")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CQ5)
                    .HasColumnName("C_Q5")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DQ1)
                    .HasColumnName("D_Q1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DQ2)
                    .HasColumnName("D_Q2")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DateMiseJour)
                    .HasColumnName("DATE_MISE_JOUR")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.EQ1)
                    .HasColumnName("E_Q1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EQ21)
                    .HasColumnName("E_Q21")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EQ22)
                    .HasColumnName("E_Q22")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FQ1)
                    .HasColumnName("F_Q1")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.GQ1)
                    .HasColumnName("G_Q1")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HQ1)
                    .HasColumnName("H_Q1")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspEventCalendar>(entity =>
            {
                entity.HasKey(e => e.IdEvent)
                    .HasName("SYS_C0011568");

                entity.ToTable("ESP_EVENT_CALENDAR");

                entity.Property(e => e.IdEvent)
                    .HasColumnName("ID_EVENT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Attachments)
                    .HasColumnName("ATTACHMENTS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Attendees)
                    .HasColumnName("ATTENDEES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ConferenceData)
                    .HasColumnName("CONFERENCE_DATA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateEnd)
                    .HasColumnName("DATE_END")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateStart)
                    .HasColumnName("DATE_START")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("DATE_UPDATED")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Etag)
                    .HasColumnName("ETAG")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HangoutLink)
                    .HasColumnName("HANGOUT_LINK")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Summary)
                    .HasColumnName("SUMMARY")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspExamen>(entity =>
            {
                entity.HasKey(e => new { e.NumSession, e.AnneeDeb, e.AnneeFin });

                entity.ToTable("ESP_EXAMEN");

                entity.Property(e => e.NumSession)
                    .HasColumnName("NUM_SESSION")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeFin)
                    .HasColumnName("ANNEE_FIN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateDebut)
                    .HasColumnName("DATE_DEBUT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateFin)
                    .HasColumnName("DATE_FIN")
                    .HasColumnType("DATE");

                entity.HasOne(d => d.AnneeDebNavigation)
                    .WithMany(p => p.EspExamen)
                    .HasForeignKey(d => d.AnneeDeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESP_EXAM_REFERENCE_ESP_SAIS");
            });

            modelBuilder.Entity<EspFiliere>(entity =>
            {
                entity.HasKey(e => e.CodeFiliere)
                    .HasName("PK_FILIERE");

                entity.ToTable("ESP_FILIERE");

                entity.Property(e => e.CodeFiliere)
                    .HasColumnName("CODE_FILIERE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LibFiliere)
                    .HasColumnName("LIB_FILIERE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspFormateur>(entity =>
            {
                entity.ToTable("ESP_FORMATEUR");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Autreinformation)
                    .HasColumnName("AUTREINFORMATION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idformation)
                    .HasColumnName("IDFORMATION")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasColumnName("PRENOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdformationNavigation)
                    .WithMany(p => p.EspFormateur)
                    .HasForeignKey(d => d.Idformation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ESP_FORMATEUR_FK2");
            });

            modelBuilder.Entity<EspFormation>(entity =>
            {
                entity.ToTable("ESP_FORMATION");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Aquisdapprentissages)
                    .HasColumnName("AQUISDAPPRENTISSAGES")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Dascriptiondate)
                    .HasColumnName("DASCRIPTIONDATE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Datedebut)
                    .HasColumnName("DATEDEBUT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Datefin)
                    .HasColumnName("DATEFIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.Domaine)
                    .HasColumnName("DOMAINE")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Etatform)
                    .IsRequired()
                    .HasColumnName("ETATFORM")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Impact)
                    .HasColumnName("IMPACT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Indicateure)
                    .HasColumnName("INDICATEURE")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Intitule)
                    .HasColumnName("INTITULE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Lieurealisation)
                    .HasColumnName("LIEUREALISATION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nombremax)
                    .HasColumnName("NOMBREMAX")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Objectifs)
                    .HasColumnName("OBJECTIFS")
                    .IsUnicode(false);

                entity.Property(e => e.References)
                    .HasColumnName("REFERENCES")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Theme)
                    .HasColumnName("THEME")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspGoogleMeet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_GOOGLE_MEET");

                entity.Property(e => e.CodeMeet)
                    .HasColumnName("CODE_MEET")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateMeet)
                    .IsRequired()
                    .HasColumnName("DATE_MEET")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizerMail)
                    .HasColumnName("ORGANIZER_MAIL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParticipantName)
                    .HasColumnName("PARTICIPANT_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspGoogleUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_GOOGLE_USERS");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasColumnName("FULL_NAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OrgUnitPath)
                    .HasColumnName("ORG_UNIT_PATH")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(26)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspGpProjet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_GP_PROJET");

                entity.Property(e => e.CodeCl)
                    .IsRequired()
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdGroupeProjet)
                    .IsRequired()
                    .HasColumnName("ID_GROUPE_PROJET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomGroupe)
                    .IsRequired()
                    .HasColumnName("NOM_GROUPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumGroupe).HasColumnName("NUM_GROUPE");

                entity.Property(e => e.Sujet)
                    .IsRequired()
                    .HasColumnName("SUJET")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspGroupeMail>(entity =>
            {
                entity.HasKey(e => new { e.IdGroupe, e.IdEns })
                    .HasName("ESP_GROUPE_MAIL_PK");

                entity.ToTable("ESP_GROUPE_MAIL");

                entity.Property(e => e.IdGroupe)
                    .HasColumnName("ID_GROUPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateModif)
                    .HasColumnName("DATE_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Designation)
                    .HasColumnName("DESIGNATION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspGroupeProjet>(entity =>
            {
                entity.HasKey(e => new { e.IdGroupe, e.AnneeDeb })
                    .HasName("PK_GROUPE_PR");

                entity.ToTable("ESP_GROUPE_PROJET");

                entity.Property(e => e.IdGroupe)
                    .HasColumnName("ID_GROUPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdProjet)
                    .HasColumnName("ID_PROJET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomGroupe)
                    .HasColumnName("NOM_GROUPE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeClNavigation)
                    .WithMany(p => p.EspGroupeProjet)
                    .HasForeignKey(d => d.CodeCl)
                    .HasConstraintName("FK_CLASSE_PR");

                entity.HasOne(d => d.IdProjetNavigation)
                    .WithMany(p => p.EspGroupeProjet)
                    .HasForeignKey(d => d.IdProjet)
                    .HasConstraintName("FK_GROUPE_PR");
            });

            modelBuilder.Entity<EspGroupeTarif>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.CodeGrp })
                    .HasName("PK_GROUPE_TARIF");

                entity.ToTable("ESP_GROUPE_TARIF");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeGrp)
                    .HasColumnName("CODE_GRP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDevise)
                    .HasColumnName("CODE_DEVISE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateMaj)
                    .HasColumnName("DATE_MAJ")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.EcheanceTranche1)
                    .HasColumnName("ECHEANCE_TRANCHE1")
                    .HasColumnType("DATE");

                entity.Property(e => e.EcheanceTranche2)
                    .HasColumnName("ECHEANCE_TRANCHE2")
                    .HasColumnType("DATE");

                entity.Property(e => e.LibelleGrp)
                    .HasColumnName("LIBELLE_GRP")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MontantTarif)
                    .HasColumnName("MONTANT_TARIF")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.MontantTranche1)
                    .HasColumnName("MONTANT_TRANCHE1")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.MontantTranche2)
                    .HasColumnName("MONTANT_TRANCHE2")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.MontantTtc)
                    .HasColumnName("MONTANT_TTC")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.MontantTva)
                    .HasColumnName("MONTANT_TVA")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.TauxTva)
                    .HasColumnName("TAUX_TVA")
                    .HasColumnType("NUMBER(5,2)");

                entity.HasOne(d => d.AnneeDebNavigation)
                    .WithMany(p => p.EspGroupeTarif)
                    .HasForeignKey(d => d.AnneeDeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GROUPE_TARIF_ANNEE");
            });

            modelBuilder.Entity<EspIdMoodle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_ID_MOODLE");

                entity.HasIndex(e => e.IdMoodle)
                    .HasName("ID_MOODLE")
                    .IsUnique();

                entity.Property(e => e.F7)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdMoodle)
                    .HasColumnName("ID_MOODLE")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspImportscore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_IMPORTSCORE");

                entity.Property(e => e.Matricule)
                    .HasColumnName("MATRICULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoteAng)
                    .HasColumnName("NOTE_ANG")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.NoteFran)
                    .HasColumnName("NOTE_FRAN")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Noteqi)
                    .HasColumnName("NOTEQI")
                    .HasMaxLength(18)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspInscri>(entity =>
            {
                entity.HasKey(e => e.IdInscription);

                entity.ToTable("ESP_INSCRI");

                entity.Property(e => e.IdInscription)
                    .HasColumnName("ID_INSCRIPTION")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.AdresseEt)
                    .HasColumnName("ADRESSE_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateIns)
                    .HasColumnName("DATE_INS")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateMisejour)
                    .HasColumnName("DATE_MISEJOUR")
                    .HasColumnType("DATE");

                entity.Property(e => e.HeureIns)
                    .HasColumnName("HEURE_INS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomEt)
                    .IsRequired()
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomJeton)
                    .IsRequired()
                    .HasColumnName("NOM_JETON")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomEt)
                    .IsRequired()
                    .HasColumnName("PRENOM_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCcna)
                    .HasColumnName("TYPE_CCNA")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspInscription>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.IdEt });

                entity.ToTable("ESP_INSCRIPTION");

                entity.HasIndex(e => e.CodeCl1)
                    .HasName("IDX_INSCRIPTION_CODECL1");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdmisRach)
                    .HasColumnName("ADMIS_RACH")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AdmisTs)
                    .HasColumnName("ADMIS_TS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.AnneeFin)
                    .HasColumnName("ANNEE_FIN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .IsRequired()
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl1)
                    .HasColumnName("CODE_CL1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl2)
                    .HasColumnName("CODE_CL2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeClLangue)
                    .HasColumnName("CODE_CL_LANGUE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDecisionSessionP)
                    .HasColumnName("CODE_DECISION_SESSION_P")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDecisionSessionRat)
                    .HasColumnName("CODE_DECISION_SESSION_RAT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDecisionSessionRat2)
                    .HasColumnName("CODE_DECISION_SESSION_RAT2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDev)
                    .HasColumnName("CODE_DEV")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CoefPfe)
                    .HasColumnName("COEF_PFE")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.CoutAnnuel)
                    .HasColumnName("COUT_ANNUEL")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.CoutDev)
                    .HasColumnName("COUT_DEV")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.CreditAnt)
                    .HasColumnName("CREDIT_ANT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreditRglt)
                    .HasColumnName("CREDIT_RGLT")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.DateInsc)
                    .HasColumnName("DATE_INSC")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateLastMajDecisionPrinc)
                    .HasColumnName("DATE_LAST_MAJ_DECISION_PRINC")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateLastMajDecisionRatt)
                    .HasColumnName("DATE_LAST_MAJ_DECISION_RATT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateLastModifRat2)
                    .HasColumnName("DATE_LAST_MODIF_RAT2")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateLimProlongRglt)
                    .HasColumnName("DATE_LIM_PROLONG_RGLT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DatePreinsc)
                    .HasColumnName("DATE_PREINSC")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateTestAng)
                    .HasColumnName("DATE_TEST_ANG")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateTestFr)
                    .HasColumnName("DATE_TEST_FR")
                    .HasColumnType("DATE");

                entity.Property(e => e.DernUtilisateur)
                    .HasColumnName("DERN_UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.EtatEntretien)
                    .HasColumnName("ETAT_ENTRETIEN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatFinancier)
                    .HasColumnName("ETAT_FINANCIER")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EtatInsTestNiv)
                    .IsRequired()
                    .HasColumnName("ETAT_INS_TEST_NIV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.FraisIns)
                    .HasColumnName("FRAIS_INS")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.GroupeTarif)
                    .HasColumnName("GROUPE_TARIF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LibDecisionSessionP)
                    .HasColumnName("LIB_DECISION_SESSION_P")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LibDecisionSessionRat)
                    .HasColumnName("LIB_DECISION_SESSION_RAT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LibDecisionSessionRat2)
                    .HasColumnName("LIB_DECISION_SESSION_RAT2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MajNiveauDefinitif)
                    .HasColumnName("MAJ_NIVEAU_DEFINITIF")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MgSeved)
                    .HasColumnName("MG_SEVED")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.ModeRglt)
                    .HasColumnName("MODE_RGLT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MoyGenAvPfe)
                    .HasColumnName("MOY_GEN_AV_PFE")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.MoyGenAvPfeSp)
                    .HasColumnName("MOY_GEN_AV_PFE_SP")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.MoyGenAvPfeSr)
                    .HasColumnName("MOY_GEN_AV_PFE_SR")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.MoyGeneral)
                    .HasColumnName("MOY_GENERAL")
                    .HasColumnType("NUMBER(7,4)");

                entity.Property(e => e.MoyRat2)
                    .HasColumnName("MOY_RAT2")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoyRatAvRach)
                    .HasColumnName("MOY_RAT_AV_RACH")
                    .HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.MoyRatt)
                    .HasColumnName("MOY_RATT")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MoySem1)
                    .HasColumnName("MOY_SEM1")
                    .HasColumnType("NUMBER(7,4)");

                entity.Property(e => e.MoySem2)
                    .HasColumnName("MOY_SEM2")
                    .HasColumnType("NUMBER(7,4)");

                entity.Property(e => e.NbCreditModule)
                    .HasColumnName("NB_CREDIT_MODULE")
                    .HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.NbEctsAvPfe)
                    .HasColumnName("NB_ECTS_AV_PFE")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NbEctsSp)
                    .HasColumnName("NB_ECTS_SP")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.NbEctsSr)
                    .HasColumnName("NB_ECTS_SR")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.NbImpAttestReussite)
                    .HasColumnName("NB_IMP_ATTEST_REUSSITE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.NbImpReleve)
                    .HasColumnName("NB_IMP_RELEVE")
                    .HasColumnType("NUMBER(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NivAcquisAnglais)
                    .HasColumnName("NIV_ACQUIS_ANGLAIS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NivAcquisFrancais)
                    .HasColumnName("NIV_ACQUIS_FRANCAIS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NivLangue)
                    .HasColumnName("NIV_LANGUE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NiveauAccees).HasColumnName("NIVEAU_ACCEES");

                entity.Property(e => e.NotePfe)
                    .HasColumnName("NOTE_PFE")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.NumAnnexe)
                    .HasColumnName("NUM_ANNEXE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.NumAnnuelDiplome)
                    .HasColumnName("NUM_ANNUEL_DIPLOME")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Numpromotioncs)
                    .HasColumnName("NUMPROMOTIONCS")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PrepToeic)
                    .IsRequired()
                    .HasColumnName("PREP_TOEIC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.RachatUeEt)
                    .HasColumnName("RACHAT_UE_ET")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.RangSp).HasColumnName("RANG_SP");

                entity.Property(e => e.Reserve)
                    .HasColumnName("RESERVE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Resultat)
                    .HasColumnName("RESULTAT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.SitRglt)
                    .HasColumnName("SIT_RGLT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TemNum).HasColumnName("TEM_NUM");

                entity.Property(e => e.TestToeic)
                    .IsRequired()
                    .HasColumnName("TEST_TOEIC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.TypeInsc)
                    .IsRequired()
                    .HasColumnName("TYPE_INSC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeRglt)
                    .HasColumnName("TYPE_RGLT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UserLangModif)
                    .HasColumnName("USER_LANG_MODIF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.AnneeDebNavigation)
                    .WithMany(p => p.EspInscription)
                    .HasForeignKey(d => d.AnneeDeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESP_INSC_REFERENCE_ESP_SAIS");

                entity.HasOne(d => d.EspSaisonClasse)
                    .WithMany(p => p.EspInscription)
                    .HasForeignKey(d => new { d.AnneeDeb, d.Semestre, d.CodeCl })
                    .HasConstraintName("FK_ESP_INSC_CLASSE");
            });

            modelBuilder.Entity<EspInscriptionRat>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.CodeModule, e.AnneeDeb })
                    .HasName("ESP_INSCRIPTION_RAT_PK");

                entity.ToTable("ESP_INSCRIPTION_RAT");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .IsRequired()
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateDemande)
                    .HasColumnName("DATE_DEMANDE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.DateRat)
                    .HasColumnName("DATE_RAT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.HeureRat)
                    .HasColumnName("HEURE_RAT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TypeRat)
                    .HasColumnName("TYPE_RAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspIntern170818>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_INTERN_170818");

                entity.Property(e => e.DateNaisEt)
                    .HasColumnName("DATE_NAIS_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt2)
                    .HasColumnName("ID_ET2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LibSpecialiteEspEt)
                    .HasColumnName("LIB_SPECIALITE_ESP_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LieuNaisEt)
                    .HasColumnName("LIEU_NAIS_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NiveauAcces).HasColumnName("NIVEAU_ACCES");

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexe)
                    .HasColumnName("SEXE")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspJournalEtudiant>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.NomColonne, e.TypeOp, e.DateOp });

                entity.ToTable("ESP_JOURNAL_ETUDIANT");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomColonne)
                    .HasColumnName("NOM_COLONNE")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOp)
                    .HasColumnName("TYPE_OP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateOp)
                    .HasColumnName("DATE_OP")
                    .HasColumnType("DATE");

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ValeurFinal)
                    .HasColumnName("VALEUR_FINAL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValeurInit)
                    .HasColumnName("VALEUR_INIT")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspJournalInscription>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.CodeCl, e.IdEt, e.NomColonne, e.TypeOp, e.DateOp, e.Utilisateur });

                entity.ToTable("ESP_JOURNAL_INSCRIPTION");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomColonne)
                    .HasColumnName("NOM_COLONNE")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOp)
                    .HasColumnName("TYPE_OP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateOp)
                    .HasColumnName("DATE_OP")
                    .HasColumnType("DATE");

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'system'");

                entity.Property(e => e.AdresseIp)
                    .HasColumnName("ADRESSE_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Machine)
                    .HasColumnName("MACHINE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValeurFinal)
                    .HasColumnName("VALEUR_FINAL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ValeurInit)
                    .HasColumnName("VALEUR_INIT")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspJournalMdpEns>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_JOURNAL_MDP_ENS");

                entity.Property(e => e.DateModif)
                    .HasColumnName("DATE_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEns)
                    .IsRequired()
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IpModif)
                    .HasColumnName("IP_MODIF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineModif)
                    .HasColumnName("MACHINE_MODIF")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewMdp)
                    .HasColumnName("NEW_MDP")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OldMdp)
                    .HasColumnName("OLD_MDP")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspJournalNivLanguesEtud>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.NomColonne, e.TypeOp, e.DateOp })
                    .HasName("PK_ESP_NIV_LANG_ETUD");

                entity.ToTable("ESP_JOURNAL_NIV_LANGUES_ETUD");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomColonne)
                    .HasColumnName("NOM_COLONNE")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOp)
                    .HasColumnName("TYPE_OP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateOp)
                    .HasColumnName("DATE_OP")
                    .HasColumnType("DATE");

                entity.Property(e => e.HostName)
                    .HasColumnName("HOST_NAME")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ValFinalang)
                    .HasColumnName("VAL_FINALANG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ValFinalfr)
                    .HasColumnName("VAL_FINALFR")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ValInitang)
                    .HasColumnName("VAL_INITANG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ValInitfr)
                    .HasColumnName("VAL_INITFR")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspJournalNote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_JOURNAL_NOTE");

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .IsRequired()
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .IsRequired()
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateOp)
                    .HasColumnName("DATE_OP")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnName("IP_ADDRESS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewNoteCc)
                    .HasColumnName("NEW_NOTE_CC")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NewNoteExam)
                    .HasColumnName("NEW_NOTE_EXAM")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NewNoteTp)
                    .HasColumnName("NEW_NOTE_TP")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NomMachine)
                    .IsRequired()
                    .HasColumnName("NOM_MACHINE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldNoteCc)
                    .HasColumnName("OLD_NOTE_CC")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.OldNoteExam)
                    .HasColumnName("OLD_NOTE_EXAM")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.OldNoteTp)
                    .HasColumnName("OLD_NOTE_TP")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.TypeNote)
                    .HasColumnName("TYPE_NOTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'P'");

                entity.Property(e => e.TypeOp)
                    .HasColumnName("TYPE_OP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Utilisateur)
                    .IsRequired()
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspJournalOpRubrique>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.IdEt, e.DateOp, e.TypeOp })
                    .HasName("PK_OP_RUBRIQUE");

                entity.ToTable("ESP_JOURNAL_OP_RUBRIQUE");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateOp)
                    .HasColumnName("DATE_OP")
                    .HasColumnType("DATE");

                entity.Property(e => e.TypeOp)
                    .HasColumnName("TYPE_OP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodeRub)
                    .HasColumnName("CODE_RUB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NewValue)
                    .HasColumnName("NEW_VALUE")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.OldValue)
                    .HasColumnName("OLD_VALUE")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspJournalRglt>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.CodeCl, e.IdEt, e.DateLimRglt, e.DateOp })
                    .HasName("ESP_JOURNAL_RGLT_PK");

                entity.ToTable("ESP_JOURNAL_RGLT");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateLimRglt)
                    .HasColumnName("DATE_LIM_RGLT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateOp)
                    .HasColumnName("DATE_OP")
                    .HasColumnType("DATE");

                entity.Property(e => e.AdresseIp)
                    .HasColumnName("ADRESSE_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Machine)
                    .HasColumnName("MACHINE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Utilisateur)
                    .IsRequired()
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ValeurFinal)
                    .HasColumnName("VALEUR_FINAL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ValeurInit)
                    .HasColumnName("VALEUR_INIT")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspMailEnseignant>(entity =>
            {
                entity.ToTable("ESP_MAIL_ENSEIGNANT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("FLOAT");

                entity.Property(e => e.MailEns)
                    .HasColumnName("MAIL_ENS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomEns)
                    .HasColumnName("NOM_ENS")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspMatriculeNumEt>(entity =>
            {
                entity.HasKey(e => e.NumMat)
                    .HasName("ESP_MATRICULE_NUM_ET_PK");

                entity.ToTable("ESP_MATRICULE_NUM_ET");

                entity.Property(e => e.NumMat)
                    .HasColumnName("NUM_MAT")
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.Identifiant)
                    .HasColumnName("IDENTIFIANT")
                    .HasMaxLength(26)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspModule>(entity =>
            {
                entity.HasKey(e => e.CodeModule);

                entity.ToTable("ESP_MODULE");

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AEvaluer)
                    .HasColumnName("A_EVALUER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'O'");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeMatiereEduserv)
                    .HasColumnName("CODE_MATIERE_EDUSERV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Coef)
                    .HasColumnName("COEF")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasColumnName("DESIGNATION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.NbHeures)
                    .HasColumnName("NB_HEURES")
                    .HasColumnType("NUMBER(5,1)");

                entity.Property(e => e.NumPanier)
                    .HasColumnName("NUM_PANIER")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEpreuve)
                    .HasColumnName("TYPE_EPREUVE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEpreuveSr)
                    .HasColumnName("TYPE_EPREUVE_SR")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TypeModule)
                    .HasColumnName("TYPE_MODULE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"'O'
");

                entity.Property(e => e.Up)
                    .HasColumnName("UP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UpNavigation)
                    .WithMany(p => p.EspModule)
                    .HasForeignKey(d => d.Up)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UP_MODULE");

                entity.HasOne(d => d.EspUe)
                    .WithMany(p => p.EspModule)
                    .HasForeignKey(d => new { d.CodeUe, d.AnneeDeb })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ESP_UE_MODULE");
            });

            modelBuilder.Entity<EspModule0818>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_MODULE_0818");

                entity.HasIndex(e => e.CodeModule)
                    .HasName("ESP_MODULE_X")
                    .IsUnique();

                entity.Property(e => e.AEvaluer)
                    .HasColumnName("A_EVALUER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodeMatiereEduserv)
                    .HasColumnName("CODE_MATIERE_EDUSERV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .IsRequired()
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Coef)
                    .HasColumnName("COEF")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasColumnName("DESIGNATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NbHeures)
                    .HasColumnName("NB_HEURES")
                    .HasColumnType("NUMBER(5,1)");

                entity.Property(e => e.NumPanier)
                    .HasColumnName("NUM_PANIER")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEpreuve)
                    .HasColumnName("TYPE_EPREUVE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEpreuveSr)
                    .HasColumnName("TYPE_EPREUVE_SR")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Up)
                    .HasColumnName("UP")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspModuleEtudiant>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.CodeModule, e.NumPanier, e.CodeCl, e.AnneeDeb, e.AnneeFin });

                entity.ToTable("ESP_MODULE_ETUDIANT");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumPanier)
                    .HasColumnName("NUM_PANIER")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeFin)
                    .HasColumnName("ANNEE_FIN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MoyennePrincipale)
                    .HasColumnName("MOYENNE_PRINCIPALE")
                    .HasColumnType("NUMBER(7,4)");

                entity.Property(e => e.MoyenneRat)
                    .HasColumnName("MOYENNE_RAT")
                    .HasColumnType("NUMBER(7,4)");

                entity.Property(e => e.NbAbscence)
                    .HasColumnName("NB_ABSCENCE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.NumSession)
                    .HasColumnName("NUM_SESSION")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Situation)
                    .HasColumnName("SITUATION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeModuleNavigation)
                    .WithMany(p => p.EspModuleEtudiant)
                    .HasForeignKey(d => d.CodeModule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MODULE_ET_MODULE");

                entity.HasOne(d => d.EspExamen)
                    .WithMany(p => p.EspModuleEtudiant)
                    .HasForeignKey(d => new { d.NumSession, d.AnneeDeb, d.AnneeFin })
                    .HasConstraintName("FK_ESP_MODU_REFERENCE_ESP_EXAM");
            });

            modelBuilder.Entity<EspModulePanierClasseSaiso>(entity =>
            {
                entity.HasKey(e => new { e.CodeModule, e.CodeCl, e.AnneeDeb, e.NumSemestre })
                    .HasName("PK_MODULE_CLASSE_SAISON");

                entity.ToTable("ESP_MODULE_PANIER_CLASSE_SAISO");

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NumSemestre)
                    .HasColumnName("NUM_SEMESTRE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Acomptabiliser)
                    .HasColumnName("ACOMPTABILISER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeFin)
                    .HasColumnName("ANNEE_FIN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ApCs).HasColumnName("AP_CS");

                entity.Property(e => e.CalculRat)
                    .HasColumnName("CALCUL_RAT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'SP'");

                entity.Property(e => e.ChargeEns1P1)
                    .HasColumnName("CHARGE_ENS1_P1")
                    .HasColumnType("NUMBER(5,1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChargeEns1P2)
                    .HasColumnName("CHARGE_ENS1_P2")
                    .HasColumnType("NUMBER(5,1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChargeEns2P1)
                    .HasColumnName("CHARGE_ENS2_P1")
                    .HasColumnType("NUMBER(5,1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChargeEns2P2)
                    .HasColumnName("CHARGE_ENS2_P2")
                    .HasColumnType("NUMBER(5,1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChargeEns3P1)
                    .HasColumnName("CHARGE_ENS3_P1")
                    .HasColumnType("NUMBER(5,1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChargeEns3P2)
                    .HasColumnName("CHARGE_ENS3_P2")
                    .HasColumnType("NUMBER(5,1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChargeEns4P1)
                    .HasColumnName("CHARGE_ENS4_P1")
                    .HasColumnType("NUMBER(5,1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChargeEns4P2)
                    .HasColumnName("CHARGE_ENS4_P2")
                    .HasColumnType("NUMBER(5,1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChargeEns5P1)
                    .HasColumnName("CHARGE_ENS5_P1")
                    .HasColumnType("NUMBER(5,1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChargeEns5P2)
                    .HasColumnName("CHARGE_ENS5_P2")
                    .HasColumnType("NUMBER(5,1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChargeP1)
                    .HasColumnName("CHARGE_P1")
                    .HasColumnType("NUMBER(5,1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChargeP2)
                    .HasColumnName("CHARGE_P2")
                    .HasColumnType("NUMBER(5,1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Chargep1add)
                    .HasColumnName("CHARGEP1ADD")
                    .HasColumnType("NUMBER(19,2)");

                entity.Property(e => e.Chargep2add)
                    .HasColumnName("CHARGEP2ADD")
                    .HasColumnType("NUMBER(19,2)");

                entity.Property(e => e.CodePlan).HasColumnName("CODE_PLAN");

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Coef)
                    .HasColumnName("COEF")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("DATE_CREATION")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateDebut)
                    .HasColumnName("DATE_DEBUT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateExamen)
                    .HasColumnName("DATE_EXAMEN")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateFin)
                    .HasColumnName("DATE_FIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateRat)
                    .HasColumnName("DATE_RAT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateRattrapage)
                    .HasColumnName("DATE_RATTRAPAGE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DaterLastMaj)
                    .HasColumnName("DATER_LAST_MAJ")
                    .HasColumnType("DATE");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationNew)
                    .HasColumnName("DESIGNATION_NEW")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExisteCc)
                    .HasColumnName("EXISTE_CC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ExisteTp)
                    .HasColumnName("EXISTE_TP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.HeureExam)
                    .HasColumnName("HEURE_EXAM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HeureFinSp)
                    .HasColumnName("HEURE_FIN_SP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HeureFinSr)
                    .HasColumnName("HEURE_FIN_SR")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HeureRat)
                    .HasColumnName("HEURE_RAT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'V-463-12'");

                entity.Property(e => e.IdEns2)
                    .HasColumnName("ID_ENS2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns3)
                    .HasColumnName("ID_ENS3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns4)
                    .HasColumnName("ID_ENS4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns5)
                    .HasColumnName("ID_ENS5")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NbEcts).HasColumnName("NB_ECTS");

                entity.Property(e => e.NbHeures)
                    .HasColumnName("NB_HEURES")
                    .HasColumnType("NUMBER(5,1)");

                entity.Property(e => e.NbHeuresEns)
                    .HasColumnName("NB_HEURES_ENS")
                    .HasColumnType("NUMBER(5,1)");

                entity.Property(e => e.NbHeuresEns2)
                    .HasColumnName("NB_HEURES_ENS2")
                    .HasColumnType("NUMBER(5,1)");

                entity.Property(e => e.NbHoraireRealises)
                    .HasColumnName("NB_HORAIRE_REALISES")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Nbheuradd)
                    .HasColumnName("NBHEURADD")
                    .HasColumnType("NUMBER(19,2)");

                entity.Property(e => e.NumPanier)
                    .HasColumnName("NUM_PANIER")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NumPeriodfe)
                    .HasColumnName("NUM_PERIODFE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Numpromotioncs)
                    .HasColumnName("NUMPROMOTIONCS")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Periode)
                    .HasColumnName("PERIODE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Salle)
                    .HasColumnName("SALLE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Salle1Rat)
                    .HasColumnName("SALLE1_RAT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Salle2Rat)
                    .HasColumnName("SALLE2_RAT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalleExam)
                    .HasColumnName("SALLE_EXAM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalleExam2)
                    .HasColumnName("SALLE_EXAM2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SeanceUnique)
                    .HasColumnName("SEANCE_UNIQUE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.Surveillant)
                    .HasColumnName("SURVEILLANT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Surveillant2)
                    .HasColumnName("SURVEILLANT2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEns)
                    .HasColumnName("TYPE_ENS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEpreuve)
                    .HasColumnName("TYPE_EPREUVE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'01' ");

                entity.Property(e => e.TypeEpreuveSr)
                    .HasColumnName("TYPE_EPREUVE_SR")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'01' ");

                entity.Property(e => e.UeFantome)
                    .HasColumnName("UE_FANTOME")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeClNavigation)
                    .WithMany(p => p.EspModulePanierClasseSaiso)
                    .HasForeignKey(d => d.CodeCl)
                    .HasConstraintName("FK_CLASSE");

                entity.HasOne(d => d.CodeModuleNavigation)
                    .WithMany(p => p.EspModulePanierClasseSaiso)
                    .HasForeignKey(d => d.CodeModule)
                    .HasConstraintName("FK_MOD_PAN_MOD_CL_SAISON");

                entity.HasOne(d => d.IdEnsNavigation)
                    .WithMany(p => p.EspModulePanierClasseSaiso)
                    .HasForeignKey(d => d.IdEns)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ENS");
            });

            modelBuilder.Entity<EspMoyModuleEtSemestriel>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.IdEt, e.CodeModule, e.Semestre })
                    .HasName("PK_MOY_MODULE_SEMESTRIEL");

                entity.ToTable("ESP_MOY_MODULE_ET_SEMESTRIEL");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Coef)
                    .HasColumnName("COEF")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.DateDernMaj)
                    .HasColumnName("DATE_DERN_MAJ")
                    .HasColumnType("DATE");

                entity.Property(e => e.DesignationModule)
                    .HasColumnName("DESIGNATION_MODULE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Moyenne)
                    .HasColumnName("MOYENNE")
                    .HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.NbHeures).HasColumnName("NB_HEURES");

                entity.Property(e => e.TypeMoy)
                    .HasColumnName("TYPE_MOY")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspMoyModuleEtudiant>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.IdEt, e.CodeModule, e.TypeMoy, e.CodeCl })
                    .HasName("PK_MOY_MODULE_ET");

                entity.ToTable("ESP_MOY_MODULE_ETUDIANT");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeMoy)
                    .HasColumnName("TYPE_MOY")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Coef)
                    .HasColumnName("COEF")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.ConfRat)
                    .HasColumnName("CONF_RAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateDernMaj)
                    .HasColumnName("DATE_DERN_MAJ")
                    .HasColumnType("DATE");

                entity.Property(e => e.DesignationModule)
                    .HasColumnName("DESIGNATION_MODULE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtatRat)
                    .HasColumnName("ETAT_RAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Moyenne)
                    .HasColumnName("MOYENNE")
                    .HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.NbHeures).HasColumnName("NB_HEURES");

                entity.Property(e => e.NiveauAcces).HasColumnName("NIVEAU_ACCES");

                entity.Property(e => e.NumPanier)
                    .HasColumnName("NUM_PANIER")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeModuleNavigation)
                    .WithMany(p => p.EspMoyModuleEtudiant)
                    .HasForeignKey(d => d.CodeModule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOY_ET_MODULE");

                entity.HasOne(d => d.EspMoyPanierEtudiant)
                    .WithMany(p => p.EspMoyModuleEtudiant)
                    .HasForeignKey(d => new { d.AnneeDeb, d.IdEt, d.NumPanier, d.TypeMoy })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_LINK_MODULE_PANIER");
            });

            modelBuilder.Entity<EspMoyPanierEtudiant>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.IdEt, e.NumPanier, e.TypeMoy })
                    .HasName("PK_MOY_PANIER_ET");

                entity.ToTable("ESP_MOY_PANIER_ETUDIANT");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumPanier)
                    .HasColumnName("NUM_PANIER")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TypeMoy)
                    .HasColumnName("TYPE_MOY")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Coef)
                    .HasColumnName("COEF")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.DesignationPanier)
                    .HasColumnName("DESIGNATION_PANIER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtIdEt)
                    .HasColumnName("ET_ID_ET")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Moyenne)
                    .HasColumnName("MOYENNE")
                    .HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.NbHeures).HasColumnName("NB_HEURES");

                entity.Property(e => e.NiveauAcces).HasColumnName("NIVEAU_ACCES");

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspMoyUeEtudiant>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.IdEt, e.CodeCl, e.CodeUe, e.TypeMoy })
                    .HasName("PK_MOY_UE_ET");

                entity.ToTable("ESP_MOY_UE_ETUDIANT");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.TypeMoy)
                    .HasColumnName("TYPE_MOY")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MoyUeSavedP)
                    .HasColumnName("MOY_UE_SAVED_P")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.Moyenne)
                    .HasColumnName("MOYENNE")
                    .HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.NbEcts)
                    .HasColumnName("NB_ECTS")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.NiveauAcces).HasColumnName("NIVEAU_ACCES");

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.EspUe)
                    .WithMany(p => p.EspMoyUeEtudiant)
                    .HasForeignKey(d => new { d.CodeUe, d.AnneeDeb })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOY_UE_REF_UE");
            });

            modelBuilder.Entity<EspNiveauLangue>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.DateNiveau, e.Langue })
                    .HasName("ESP_NIVEAU_LANGUE_PK");

                entity.ToTable("ESP_NIVEAU_LANGUE");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateNiveau)
                    .HasColumnName("DATE_NIVEAU")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate  ");

                entity.Property(e => e.Langue)
                    .HasColumnName("LANGUE")
                    .HasMaxLength(20);

                entity.Property(e => e.AncienNiveau)
                    .HasColumnName("ANCIEN_NIVEAU")
                    .HasMaxLength(20);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NiveauActuel)
                    .HasColumnName("NIVEAU_ACTUEL")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EspNote>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.CodeCl, e.CodeModule, e.Semestre, e.IdEt });

                entity.ToTable("ESP_NOTE");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Absent)
                    .HasColumnName("ABSENT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AbsentCc)
                    .HasColumnName("ABSENT_CC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AbsentEcrit)
                    .HasColumnName("ABSENT_ECRIT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AbsentExam)
                    .HasColumnName("ABSENT_EXAM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AbsentOrale)
                    .HasColumnName("ABSENT_ORALE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AbsentTp)
                    .HasColumnName("ABSENT_TP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AdresseIp)
                    .HasColumnName("ADRESSE_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeFin)
                    .HasColumnName("ANNEE_FIN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateDeroulement)
                    .HasColumnName("DATE_DEROULEMENT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateLastModif)
                    .HasColumnName("DATE_LAST_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Dispense)
                    .HasColumnName("DISPENSE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Justif)
                    .HasColumnName("JUSTIF")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureNote)
                    .HasColumnName("NATURE_NOTE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NbHeure)
                    .HasColumnName("NB_HEURE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.NivAcquisAnglais)
                    .HasColumnName("NIV_ACQUIS_ANGLAIS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NiveauAcquis)
                    .HasColumnName("NIVEAU_ACQUIS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NiveauActuel)
                    .HasColumnName("NIVEAU_ACTUEL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NomMachine)
                    .HasColumnName("NOM_MACHINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoteCc)
                    .HasColumnName("NOTE_CC")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NoteCcLang)
                    .HasColumnName("NOTE_CC_LANG")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NoteEcrit)
                    .HasColumnName("NOTE_ECRIT")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NoteEcritLang)
                    .HasColumnName("NOTE_ECRIT_LANG")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NoteEsb01)
                    .HasColumnName("NOTE_ESB_01")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.NoteEsb02)
                    .HasColumnName("NOTE_ESB_02")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.NoteExam)
                    .HasColumnName("NOTE_EXAM")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NoteOrale)
                    .HasColumnName("NOTE_ORALE")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NoteOraleLang)
                    .HasColumnName("NOTE_ORALE_LANG")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NoteRatrap)
                    .HasColumnName("NOTE_RATRAP")
                    .HasColumnType("NUMBER(5,2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NoteTp)
                    .HasColumnName("NOTE_TP")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NumPanier)
                    .HasColumnName("NUM_PANIER")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Numpromotioncs)
                    .HasColumnName("NUMPROMOTIONCS")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TauxCcLang)
                    .HasColumnName("TAUX_CC_LANG")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TauxEcritLang)
                    .HasColumnName("TAUX_ECRIT_LANG")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TauxNote)
                    .HasColumnName("TAUX_NOTE")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TauxOraleLang)
                    .HasColumnName("TAUX_ORALE_LANG")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TypeNote)
                    .HasColumnName("TYPE_NOTE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TypeSession)
                    .HasColumnName("TYPE_SESSION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.EspEnteteNote)
                    .WithMany(p => p.EspNote)
                    .HasForeignKey(d => new { d.AnneeDeb, d.CodeCl, d.CodeModule, d.Semestre })
                    .HasConstraintName("FK_NOTE_REF_ENTETE_NOTE");
            });

            modelBuilder.Entity<EspNoteAnglaisS2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_NOTE_ANGLAIS_S2");

                entity.HasIndex(e => e.IdMoodle)
                    .HasName("ESP_NOTE_ANGLAIS_S2_X")
                    .IsUnique();

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdMoodle)
                    .HasColumnName("ID_MOODLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoteAnglais)
                    .HasColumnName("NOTE_ANGLAIS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspNoteFrancaisS2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_NOTE_FRANCAIS_S2");

                entity.HasIndex(e => e.IdMoodle)
                    .HasName("ESP_NOTE_FRANCAIS_S2_X")
                    .IsUnique();

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdMoodle)
                    .HasColumnName("ID_MOODLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoteFrancais)
                    .HasColumnName("NOTE_FRANCAIS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspNoteQiS2New>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_NOTE_QI_S2_NEW");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdMoodle)
                    .HasColumnName("ID_MOODLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoteQi)
                    .HasColumnName("NOTE_QI")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspNoteRat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_NOTE_RAT");

                entity.HasIndex(e => new { e.AnneeDeb, e.CodeModule, e.DateDeroulement, e.IdEt, e.TypeRat })
                    .HasName("PK_NOTE_RAT")
                    .IsUnique();

                entity.Property(e => e.AnneeCredit)
                    .HasColumnName("ANNEE_CREDIT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .IsRequired()
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateDeroulement)
                    .HasColumnName("DATE_DEROULEMENT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.NbHeure)
                    .HasColumnName("NB_HEURE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasColumnType("NUMBER(5,2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.TypeRat)
                    .HasColumnName("TYPE_RAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeModuleNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CodeModule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NOTE_RAT_MODULE");
            });

            modelBuilder.Entity<EspObservationEnseignant>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.DateSaisieObs, e.IdEns })
                    .HasName("PK_OBSERVATION_ENSEIGNANT");

                entity.ToTable("ESP_OBSERVATION_ENSEIGNANT");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisieObs)
                    .HasColumnName("DATE_SAISIE_OBS")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdResp)
                    .HasColumnName("ID_RESP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.QualiteResp)
                    .HasColumnName("QUALITE_RESP")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspObservationEtudiant>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.AnneeDeb, e.IdEns, e.DateObs })
                    .HasName("PK_OBSERVATION_ET");

                entity.ToTable("ESP_OBSERVATION_ETUDIANT");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateObs)
                    .HasColumnName("DATE_OBS")
                    .HasColumnType("DATE");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspOption>(entity =>
            {
                entity.HasKey(e => new { e.CodeOption, e.AnneeDeb })
                    .HasName("PK_OPTION");

                entity.ToTable("ESP_OPTION");

                entity.Property(e => e.CodeOption)
                    .HasColumnName("CODE_OPTION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreation)
                    .HasColumnName("DATE_CREATION")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateMaj)
                    .HasColumnName("DATE_MAJ")
                    .HasColumnType("DATE");

                entity.Property(e => e.LibOption)
                    .HasColumnName("LIB_OPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspOrientation>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.IdEt });

                entity.ToTable("ESP_ORIENTATION");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ch1)
                    .HasColumnName("CH1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ch10)
                    .HasColumnName("CH10")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ch11)
                    .HasColumnName("CH11")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ch12)
                    .HasColumnName("CH12")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ch2)
                    .HasColumnName("CH2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ch3)
                    .HasColumnName("CH3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ch4)
                    .HasColumnName("CH4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ch5)
                    .HasColumnName("CH5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ch6)
                    .HasColumnName("CH6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ch7)
                    .HasColumnName("CH7")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ch8)
                    .HasColumnName("CH8")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ch9)
                    .HasColumnName("CH9")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Chfinal)
                    .HasColumnName("CHFINAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.Numchoix)
                    .HasColumnName("NUMCHOIX")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Reorientation)
                    .HasColumnName("REORIENTATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Scorchfinal)
                    .HasColumnName("SCORCHFINAL")
                    .HasColumnType("FLOAT");

                entity.Property(e => e.Scorech1)
                    .HasColumnName("SCORECH1")
                    .HasColumnType("FLOAT")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Scorech10)
                    .HasColumnName("SCORECH10")
                    .HasColumnType("FLOAT")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Scorech11)
                    .HasColumnName("SCORECH11")
                    .HasColumnType("FLOAT");

                entity.Property(e => e.Scorech12)
                    .HasColumnName("SCORECH12")
                    .HasColumnType("FLOAT");

                entity.Property(e => e.Scorech2)
                    .HasColumnName("SCORECH2")
                    .HasColumnType("FLOAT")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Scorech3)
                    .HasColumnName("SCORECH3")
                    .HasColumnType("FLOAT")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Scorech4)
                    .HasColumnName("SCORECH4")
                    .HasColumnType("FLOAT")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Scorech5)
                    .HasColumnName("SCORECH5")
                    .HasColumnType("FLOAT")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Scorech6)
                    .HasColumnName("SCORECH6")
                    .HasColumnType("FLOAT")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Scorech7)
                    .HasColumnName("SCORECH7")
                    .HasColumnType("FLOAT")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Scorech8)
                    .HasColumnName("SCORECH8")
                    .HasColumnType("FLOAT")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Scorech9)
                    .HasColumnName("SCORECH9")
                    .HasColumnType("FLOAT")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Specialite)
                    .HasColumnName("SPECIALITE")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspParametre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_PARAMETRE");

                entity.Property(e => e.Annee0)
                    .HasColumnName("ANNEE_0")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeEnCours)
                    .HasColumnName("ANNEE_EN_COURS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeFin)
                    .HasColumnName("ANNEE_FIN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NumPeriode)
                    .HasColumnName("NUM_PERIODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NumSemestre).HasColumnName("NUM_SEMESTRE");
            });

            modelBuilder.Entity<EspPrevision>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.CategorieClasse, e.NiveauAcces })
                    .HasName("PK_PREVISION");

                entity.ToTable("ESP_PREVISION");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CategorieClasse)
                    .HasColumnName("CATEGORIE_CLASSE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NiveauAcces).HasColumnName("NIVEAU_ACCES");

                entity.Property(e => e.CodeSpecialite)
                    .HasColumnName("CODE_SPECIALITE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastModif)
                    .HasColumnName("DATE_LAST_MODIF")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.EffectifPrevue)
                    .HasColumnName("EFFECTIF_PREVUE")
                    .HasColumnType("NUMBER(6)");

                entity.Property(e => e.EffectifReel)
                    .HasColumnName("EFFECTIF_REEL")
                    .HasColumnType("NUMBER(6)");

                entity.Property(e => e.NbClasse).HasColumnName("NB_CLASSE");

                entity.Property(e => e.NbEtudiantRejet)
                    .HasColumnName("NB_ETUDIANT_REJET")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NbEtudiantS2)
                    .HasColumnName("NB_ETUDIANT_S2")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NbEtudiantVentile)
                    .HasColumnName("NB_ETUDIANT_VENTILE")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.ScoreMinAdmis)
                    .HasColumnName("SCORE_MIN_ADMIS")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.ScoreMinS2)
                    .HasColumnName("SCORE_MIN_S2")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.ScoreRejet)
                    .HasColumnName("SCORE_REJET")
                    .HasColumnType("NUMBER(10,3)");
            });

            modelBuilder.Entity<EspProjet>(entity =>
            {
                entity.HasKey(e => e.IdProjet)
                    .HasName("PK_PROJET");

                entity.ToTable("ESP_PROJET");

                entity.Property(e => e.IdProjet)
                    .HasColumnName("ID_PROJET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionProjet)
                    .HasColumnName("DESCRIPTION_PROJET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdEnseignant)
                    .HasColumnName("ID_ENSEIGNANT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Methodologie)
                    .HasColumnName("METHODOLOGIE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Niveau)
                    .HasColumnName("NIVEAU")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomProjet)
                    .HasColumnName("NOM_PROJET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Technologies)
                    .HasColumnName("TECHNOLOGIES")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TypeProjet)
                    .HasColumnName("TYPE_PROJET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.AnneeDebNavigation)
                    .WithMany(p => p.EspProjet)
                    .HasForeignKey(d => d.AnneeDeb)
                    .HasConstraintName("FK_ANNEE_PROJET");

                entity.HasOne(d => d.CodeModuleNavigation)
                    .WithMany(p => p.EspProjet)
                    .HasForeignKey(d => d.CodeModule)
                    .HasConstraintName("FK_MODULE_PROJET");
            });

            modelBuilder.Entity<EspProjetEtudiant>(entity =>
            {
                entity.HasKey(e => new { e.IdProjet, e.IdEt })
                    .HasName("KEY_PROJ_ET");

                entity.ToTable("ESP_PROJET_ETUDIANT");

                entity.Property(e => e.IdProjet)
                    .HasColumnName("ID_PROJET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateDebut)
                    .HasColumnName("DATE_DEBUT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateDernModif)
                    .HasColumnName("DATE_DERN_MODIF")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql(@"sysdate 
");

                entity.Property(e => e.DateFin)
                    .HasColumnName("DATE_FIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspProjetN>(entity =>
            {
                entity.HasKey(e => e.IdProjet)
                    .HasName("PK_PROJ");

                entity.ToTable("ESP_PROJET_N");

                entity.Property(e => e.IdProjet)
                    .HasColumnName("ID_PROJET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql(@"sysdate 
");

                entity.Property(e => e.DescriptionProjet)
                    .HasColumnName("DESCRIPTION_PROJET")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Methodologie)
                    .HasColumnName("METHODOLOGIE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NomProjet)
                    .HasColumnName("NOM_PROJET")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Technologies)
                    .HasColumnName("TECHNOLOGIES")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TypeProjet)
                    .IsRequired()
                    .HasColumnName("TYPE_PROJET")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspProjetNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_PROJET_NEW");

                entity.HasIndex(e => new { e.AnneeDeb, e.IdProjet, e.TypeProjet })
                    .HasName("ESP_PROJET_NEW_X")
                    .IsUnique();

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionProjet)
                    .HasColumnName("DESCRIPTION_PROJET")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Duree)
                    .HasColumnName("DUREE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.IdGroupeProjet)
                    .HasColumnName("ID_GROUPE_PROJET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdProjet)
                    .IsRequired()
                    .HasColumnName("ID_PROJET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Methodologie)
                    .HasColumnName("METHODOLOGIE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NiveauEtudiant).HasColumnName("NIVEAU_ETUDIANT");

                entity.Property(e => e.NomProjet)
                    .HasColumnName("NOM_PROJET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Periode).HasColumnName("PERIODE");

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.Technologies)
                    .HasColumnName("TECHNOLOGIES")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TypeProjet)
                    .IsRequired()
                    .HasColumnName("TYPE_PROJET")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspPvClasse>(entity =>
            {
                entity.HasKey(e => new { e.CodeCl, e.IdEt, e.Annee });

                entity.ToTable("ESP_PV_CLASSE");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Annee)
                    .HasColumnName("ANNEE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ApCs).HasColumnName("AP_CS");

                entity.Property(e => e.CodeDecision)
                    .HasColumnName("CODE_DECISION")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDecisionRat2)
                    .HasColumnName("CODE_DECISION_RAT2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDecisionRatt)
                    .HasColumnName("CODE_DECISION_RATT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CoefCol1)
                    .HasColumnName("COEF_COL_1")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol10)
                    .HasColumnName("COEF_COL_10")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol11)
                    .HasColumnName("COEF_COL_11")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol12)
                    .HasColumnName("COEF_COL_12")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol13)
                    .HasColumnName("COEF_COL_13")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol14)
                    .HasColumnName("COEF_COL_14")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol15)
                    .HasColumnName("COEF_COL_15")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol16)
                    .HasColumnName("COEF_COL_16")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol17)
                    .HasColumnName("COEF_COL_17")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol18)
                    .HasColumnName("COEF_COL_18")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol19)
                    .HasColumnName("COEF_COL_19")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol2)
                    .HasColumnName("COEF_COL_2")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol20)
                    .HasColumnName("COEF_COL_20")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol21)
                    .HasColumnName("COEF_COL_21")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol22)
                    .HasColumnName("COEF_COL_22")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol23)
                    .HasColumnName("COEF_COL_23")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol24)
                    .HasColumnName("COEF_COL_24")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol25)
                    .HasColumnName("COEF_COL_25")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol26)
                    .HasColumnName("COEF_COL_26")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol27)
                    .HasColumnName("COEF_COL_27")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol28)
                    .HasColumnName("COEF_COL_28")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol29)
                    .HasColumnName("COEF_COL_29")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol3)
                    .HasColumnName("COEF_COL_3")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol30)
                    .HasColumnName("COEF_COL_30")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol31)
                    .HasColumnName("COEF_COL_31")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol32)
                    .HasColumnName("COEF_COL_32")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol33)
                    .HasColumnName("COEF_COL_33")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol34)
                    .HasColumnName("COEF_COL_34")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol35)
                    .HasColumnName("COEF_COL_35")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol36)
                    .HasColumnName("COEF_COL_36")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol37)
                    .HasColumnName("COEF_COL_37")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol38)
                    .HasColumnName("COEF_COL_38")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol39)
                    .HasColumnName("COEF_COL_39")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol4)
                    .HasColumnName("COEF_COL_4")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol40)
                    .HasColumnName("COEF_COL_40")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol41)
                    .HasColumnName("COEF_COL_41")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol42)
                    .HasColumnName("COEF_COL_42")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol43)
                    .HasColumnName("COEF_COL_43")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol44)
                    .HasColumnName("COEF_COL_44")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol45)
                    .HasColumnName("COEF_COL_45")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol46)
                    .HasColumnName("COEF_COL_46")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol47)
                    .HasColumnName("COEF_COL_47")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol48)
                    .HasColumnName("COEF_COL_48")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol49)
                    .HasColumnName("COEF_COL_49")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol5)
                    .HasColumnName("COEF_COL_5")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol50)
                    .HasColumnName("COEF_COL_50")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol51)
                    .HasColumnName("COEF_COL_51")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol52)
                    .HasColumnName("COEF_COL_52")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol53)
                    .HasColumnName("COEF_COL_53")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol54)
                    .HasColumnName("COEF_COL_54")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol55)
                    .HasColumnName("COEF_COL_55")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol56)
                    .HasColumnName("COEF_COL_56")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol57)
                    .HasColumnName("COEF_COL_57")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol58)
                    .HasColumnName("COEF_COL_58")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol59)
                    .HasColumnName("COEF_COL_59")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol6)
                    .HasColumnName("COEF_COL_6")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol60)
                    .HasColumnName("COEF_COL_60")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.CoefCol7)
                    .HasColumnName("COEF_COL_7")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol8)
                    .HasColumnName("COEF_COL_8")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.CoefCol9)
                    .HasColumnName("COEF_COL_9")
                    .HasColumnType("NUMBER(4,2)");

                entity.Property(e => e.Credit1)
                    .HasColumnName("CREDIT_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Credit2)
                    .HasColumnName("CREDIT_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditRouge)
                    .HasColumnName("CREDIT_ROUGE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditVert)
                    .HasColumnName("CREDIT_VERT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DatePv)
                    .HasColumnName("DATE_PV")
                    .HasColumnType("DATE");

                entity.Property(e => e.EtatCol1)
                    .HasColumnName("ETAT_COL_1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol10)
                    .HasColumnName("ETAT_COL_10")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol11)
                    .HasColumnName("ETAT_COL_11")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol12)
                    .HasColumnName("ETAT_COL_12")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol13)
                    .HasColumnName("ETAT_COL_13")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol14)
                    .HasColumnName("ETAT_COL_14")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol15)
                    .HasColumnName("ETAT_COL_15")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol16)
                    .HasColumnName("ETAT_COL_16")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol17)
                    .HasColumnName("ETAT_COL_17")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol18)
                    .HasColumnName("ETAT_COL_18")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol19)
                    .HasColumnName("ETAT_COL_19")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol2)
                    .HasColumnName("ETAT_COL_2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol20)
                    .HasColumnName("ETAT_COL_20")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol21)
                    .HasColumnName("ETAT_COL_21")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol22)
                    .HasColumnName("ETAT_COL_22")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol23)
                    .HasColumnName("ETAT_COL_23")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol24)
                    .HasColumnName("ETAT_COL_24")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol25)
                    .HasColumnName("ETAT_COL_25")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol26)
                    .HasColumnName("ETAT_COL_26")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol27)
                    .HasColumnName("ETAT_COL_27")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol28)
                    .HasColumnName("ETAT_COL_28")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol29)
                    .HasColumnName("ETAT_COL_29")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol3)
                    .HasColumnName("ETAT_COL_3")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol30)
                    .HasColumnName("ETAT_COL_30")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol31)
                    .HasColumnName("ETAT_COL_31")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol32)
                    .HasColumnName("ETAT_COL_32")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol33)
                    .HasColumnName("ETAT_COL_33")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol34)
                    .HasColumnName("ETAT_COL_34")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol35)
                    .HasColumnName("ETAT_COL_35")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol36)
                    .HasColumnName("ETAT_COL_36")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol37)
                    .HasColumnName("ETAT_COL_37")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol38)
                    .HasColumnName("ETAT_COL_38")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol39)
                    .HasColumnName("ETAT_COL_39")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol4)
                    .HasColumnName("ETAT_COL_4")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol40)
                    .HasColumnName("ETAT_COL_40")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol41)
                    .HasColumnName("ETAT_COL_41")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol42)
                    .HasColumnName("ETAT_COL_42")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol43)
                    .HasColumnName("ETAT_COL_43")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol44)
                    .HasColumnName("ETAT_COL_44")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol45)
                    .HasColumnName("ETAT_COL_45")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol46)
                    .HasColumnName("ETAT_COL_46")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol47)
                    .HasColumnName("ETAT_COL_47")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol48)
                    .HasColumnName("ETAT_COL_48")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol49)
                    .HasColumnName("ETAT_COL_49")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol5)
                    .HasColumnName("ETAT_COL_5")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol50)
                    .HasColumnName("ETAT_COL_50")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol51)
                    .HasColumnName("ETAT_COL_51")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol52)
                    .HasColumnName("ETAT_COL_52")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol53)
                    .HasColumnName("ETAT_COL_53")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol54)
                    .HasColumnName("ETAT_COL_54")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol55)
                    .HasColumnName("ETAT_COL_55")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol56)
                    .HasColumnName("ETAT_COL_56")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol57)
                    .HasColumnName("ETAT_COL_57")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol58)
                    .HasColumnName("ETAT_COL_58")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol59)
                    .HasColumnName("ETAT_COL_59")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol6)
                    .HasColumnName("ETAT_COL_6")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol60)
                    .HasColumnName("ETAT_COL_60")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol7)
                    .HasColumnName("ETAT_COL_7")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol8)
                    .HasColumnName("ETAT_COL_8")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EtatCol9)
                    .HasColumnName("ETAT_COL_9")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol1)
                    .HasColumnName("ID_COL_1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol10)
                    .HasColumnName("ID_COL_10")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol11)
                    .HasColumnName("ID_COL_11")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol12)
                    .HasColumnName("ID_COL_12")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol13)
                    .HasColumnName("ID_COL_13")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol14)
                    .HasColumnName("ID_COL_14")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol15)
                    .HasColumnName("ID_COL_15")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol16)
                    .HasColumnName("ID_COL_16")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol17)
                    .HasColumnName("ID_COL_17")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol18)
                    .HasColumnName("ID_COL_18")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol19)
                    .HasColumnName("ID_COL_19")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol2)
                    .HasColumnName("ID_COL_2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol20)
                    .HasColumnName("ID_COL_20")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol21)
                    .HasColumnName("ID_COL_21")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol22)
                    .HasColumnName("ID_COL_22")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol23)
                    .HasColumnName("ID_COL_23")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol24)
                    .HasColumnName("ID_COL_24")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol25)
                    .HasColumnName("ID_COL_25")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol26)
                    .HasColumnName("ID_COL_26")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol27)
                    .HasColumnName("ID_COL_27")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol28)
                    .HasColumnName("ID_COL_28")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol29)
                    .HasColumnName("ID_COL_29")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol3)
                    .HasColumnName("ID_COL_3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol30)
                    .HasColumnName("ID_COL_30")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol31)
                    .HasColumnName("ID_COL_31")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol32)
                    .HasColumnName("ID_COL_32")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol33)
                    .HasColumnName("ID_COL_33")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol34)
                    .HasColumnName("ID_COL_34")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol35)
                    .HasColumnName("ID_COL_35")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol36)
                    .HasColumnName("ID_COL_36")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol37)
                    .HasColumnName("ID_COL_37")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol38)
                    .HasColumnName("ID_COL_38")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol39)
                    .HasColumnName("ID_COL_39")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol4)
                    .HasColumnName("ID_COL_4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol40)
                    .HasColumnName("ID_COL_40")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol41)
                    .HasColumnName("ID_COL_41")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol42)
                    .HasColumnName("ID_COL_42")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol43)
                    .HasColumnName("ID_COL_43")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol44)
                    .HasColumnName("ID_COL_44")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol45)
                    .HasColumnName("ID_COL_45")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol46)
                    .HasColumnName("ID_COL_46")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol47)
                    .HasColumnName("ID_COL_47")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol48)
                    .HasColumnName("ID_COL_48")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol49)
                    .HasColumnName("ID_COL_49")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol5)
                    .HasColumnName("ID_COL_5")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol50)
                    .HasColumnName("ID_COL_50")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol51)
                    .HasColumnName("ID_COL_51")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol52)
                    .HasColumnName("ID_COL_52")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol53)
                    .HasColumnName("ID_COL_53")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol54)
                    .HasColumnName("ID_COL_54")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol55)
                    .HasColumnName("ID_COL_55")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol56)
                    .HasColumnName("ID_COL_56")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol57)
                    .HasColumnName("ID_COL_57")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol58)
                    .HasColumnName("ID_COL_58")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol59)
                    .HasColumnName("ID_COL_59")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol6)
                    .HasColumnName("ID_COL_6")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol60)
                    .HasColumnName("ID_COL_60")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol7)
                    .HasColumnName("ID_COL_7")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol8)
                    .HasColumnName("ID_COL_8")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCol9)
                    .HasColumnName("ID_COL_9")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LibDecision)
                    .HasColumnName("LIB_DECISION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LibDecisionRat2)
                    .HasColumnName("LIB_DECISION_RAT2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LibDecisionRatt)
                    .HasColumnName("LIB_DECISION_RATT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MoyCol1)
                    .HasColumnName("MOY_COL_1")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol10)
                    .HasColumnName("MOY_COL_10")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol11)
                    .HasColumnName("MOY_COL_11")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol12)
                    .HasColumnName("MOY_COL_12")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol13)
                    .HasColumnName("MOY_COL_13")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol14)
                    .HasColumnName("MOY_COL_14")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol15)
                    .HasColumnName("MOY_COL_15")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol16)
                    .HasColumnName("MOY_COL_16")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol17)
                    .HasColumnName("MOY_COL_17")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol18)
                    .HasColumnName("MOY_COL_18")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol19)
                    .HasColumnName("MOY_COL_19")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol2)
                    .HasColumnName("MOY_COL_2")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol20)
                    .HasColumnName("MOY_COL_20")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol21)
                    .HasColumnName("MOY_COL_21")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol22)
                    .HasColumnName("MOY_COL_22")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol23)
                    .HasColumnName("MOY_COL_23")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol24)
                    .HasColumnName("MOY_COL_24")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol25)
                    .HasColumnName("MOY_COL_25")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol26)
                    .HasColumnName("MOY_COL_26")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol27)
                    .HasColumnName("MOY_COL_27")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol28)
                    .HasColumnName("MOY_COL_28")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol29)
                    .HasColumnName("MOY_COL_29")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol3)
                    .HasColumnName("MOY_COL_3")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol30)
                    .HasColumnName("MOY_COL_30")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol31)
                    .HasColumnName("MOY_COL_31")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol32)
                    .HasColumnName("MOY_COL_32")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol33)
                    .HasColumnName("MOY_COL_33")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol34)
                    .HasColumnName("MOY_COL_34")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol35)
                    .HasColumnName("MOY_COL_35")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol36)
                    .HasColumnName("MOY_COL_36")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol37)
                    .HasColumnName("MOY_COL_37")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol38)
                    .HasColumnName("MOY_COL_38")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol39)
                    .HasColumnName("MOY_COL_39")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol4)
                    .HasColumnName("MOY_COL_4")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol40)
                    .HasColumnName("MOY_COL_40")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol41)
                    .HasColumnName("MOY_COL_41")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol42)
                    .HasColumnName("MOY_COL_42")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol43)
                    .HasColumnName("MOY_COL_43")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol44)
                    .HasColumnName("MOY_COL_44")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol45)
                    .HasColumnName("MOY_COL_45")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol46)
                    .HasColumnName("MOY_COL_46")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol47)
                    .HasColumnName("MOY_COL_47")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol48)
                    .HasColumnName("MOY_COL_48")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol49)
                    .HasColumnName("MOY_COL_49")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol5)
                    .HasColumnName("MOY_COL_5")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol50)
                    .HasColumnName("MOY_COL_50")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol51)
                    .HasColumnName("MOY_COL_51")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol52)
                    .HasColumnName("MOY_COL_52")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol53)
                    .HasColumnName("MOY_COL_53")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol54)
                    .HasColumnName("MOY_COL_54")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol55)
                    .HasColumnName("MOY_COL_55")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol56)
                    .HasColumnName("MOY_COL_56")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol57)
                    .HasColumnName("MOY_COL_57")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol58)
                    .HasColumnName("MOY_COL_58")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol59)
                    .HasColumnName("MOY_COL_59")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol6)
                    .HasColumnName("MOY_COL_6")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol60)
                    .HasColumnName("MOY_COL_60")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol7)
                    .HasColumnName("MOY_COL_7")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol8)
                    .HasColumnName("MOY_COL_8")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.MoyCol9)
                    .HasColumnName("MOY_COL_9")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.Moygen)
                    .HasColumnName("MOYGEN")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.Moyratt)
                    .HasColumnName("MOYRATT")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.NatureUe1)
                    .HasColumnName("NATURE_UE_1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe10)
                    .HasColumnName("NATURE_UE_10")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe11)
                    .HasColumnName("NATURE_UE_11")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe12)
                    .HasColumnName("NATURE_UE_12")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe13)
                    .HasColumnName("NATURE_UE_13")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe14)
                    .HasColumnName("NATURE_UE_14")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe15)
                    .HasColumnName("NATURE_UE_15")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe16)
                    .HasColumnName("NATURE_UE_16")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe17)
                    .HasColumnName("NATURE_UE_17")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe18)
                    .HasColumnName("NATURE_UE_18")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe19)
                    .HasColumnName("NATURE_UE_19")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe2)
                    .HasColumnName("NATURE_UE_2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe20)
                    .HasColumnName("NATURE_UE_20")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe21)
                    .HasColumnName("NATURE_UE_21")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe22)
                    .HasColumnName("NATURE_UE_22")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe23)
                    .HasColumnName("NATURE_UE_23")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe24)
                    .HasColumnName("NATURE_UE_24")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe25)
                    .HasColumnName("NATURE_UE_25")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe26)
                    .HasColumnName("NATURE_UE_26")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe27)
                    .HasColumnName("NATURE_UE_27")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe28)
                    .HasColumnName("NATURE_UE_28")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe29)
                    .HasColumnName("NATURE_UE_29")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe3)
                    .HasColumnName("NATURE_UE_3")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe30)
                    .HasColumnName("NATURE_UE_30")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe31)
                    .HasColumnName("NATURE_UE_31")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe32)
                    .HasColumnName("NATURE_UE_32")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe33)
                    .HasColumnName("NATURE_UE_33")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe34)
                    .HasColumnName("NATURE_UE_34")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe35)
                    .HasColumnName("NATURE_UE_35")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe36)
                    .HasColumnName("NATURE_UE_36")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe37)
                    .HasColumnName("NATURE_UE_37")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe38)
                    .HasColumnName("NATURE_UE_38")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe39)
                    .HasColumnName("NATURE_UE_39")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe4)
                    .HasColumnName("NATURE_UE_4")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe40)
                    .HasColumnName("NATURE_UE_40")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe41)
                    .HasColumnName("NATURE_UE_41")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe42)
                    .HasColumnName("NATURE_UE_42")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe43)
                    .HasColumnName("NATURE_UE_43")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe44)
                    .HasColumnName("NATURE_UE_44")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe45)
                    .HasColumnName("NATURE_UE_45")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe46)
                    .HasColumnName("NATURE_UE_46")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe47)
                    .HasColumnName("NATURE_UE_47")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe48)
                    .HasColumnName("NATURE_UE_48")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe49)
                    .HasColumnName("NATURE_UE_49")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe5)
                    .HasColumnName("NATURE_UE_5")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe50)
                    .HasColumnName("NATURE_UE_50")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe51)
                    .HasColumnName("NATURE_UE_51")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe52)
                    .HasColumnName("NATURE_UE_52")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe53)
                    .HasColumnName("NATURE_UE_53")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe54)
                    .HasColumnName("NATURE_UE_54")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe55)
                    .HasColumnName("NATURE_UE_55")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe56)
                    .HasColumnName("NATURE_UE_56")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe57)
                    .HasColumnName("NATURE_UE_57")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe58)
                    .HasColumnName("NATURE_UE_58")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe59)
                    .HasColumnName("NATURE_UE_59")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe6)
                    .HasColumnName("NATURE_UE_6")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe60)
                    .HasColumnName("NATURE_UE_60")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe7)
                    .HasColumnName("NATURE_UE_7")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe8)
                    .HasColumnName("NATURE_UE_8")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe9)
                    .HasColumnName("NATURE_UE_9")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NbHeureCol1).HasColumnName("NB_HEURE_COL_1");

                entity.Property(e => e.NbHeureCol10).HasColumnName("NB_HEURE_COL_10");

                entity.Property(e => e.NbHeureCol11).HasColumnName("NB_HEURE_COL_11");

                entity.Property(e => e.NbHeureCol12).HasColumnName("NB_HEURE_COL_12");

                entity.Property(e => e.NbHeureCol13).HasColumnName("NB_HEURE_COL_13");

                entity.Property(e => e.NbHeureCol14).HasColumnName("NB_HEURE_COL_14");

                entity.Property(e => e.NbHeureCol15).HasColumnName("NB_HEURE_COL_15");

                entity.Property(e => e.NbHeureCol16).HasColumnName("NB_HEURE_COL_16");

                entity.Property(e => e.NbHeureCol17).HasColumnName("NB_HEURE_COL_17");

                entity.Property(e => e.NbHeureCol18).HasColumnName("NB_HEURE_COL_18");

                entity.Property(e => e.NbHeureCol19).HasColumnName("NB_HEURE_COL_19");

                entity.Property(e => e.NbHeureCol2).HasColumnName("NB_HEURE_COL_2");

                entity.Property(e => e.NbHeureCol20).HasColumnName("NB_HEURE_COL_20");

                entity.Property(e => e.NbHeureCol21).HasColumnName("NB_HEURE_COL_21");

                entity.Property(e => e.NbHeureCol22).HasColumnName("NB_HEURE_COL_22");

                entity.Property(e => e.NbHeureCol23).HasColumnName("NB_HEURE_COL_23");

                entity.Property(e => e.NbHeureCol24).HasColumnName("NB_HEURE_COL_24");

                entity.Property(e => e.NbHeureCol25).HasColumnName("NB_HEURE_COL_25");

                entity.Property(e => e.NbHeureCol26).HasColumnName("NB_HEURE_COL_26");

                entity.Property(e => e.NbHeureCol27).HasColumnName("NB_HEURE_COL_27");

                entity.Property(e => e.NbHeureCol28).HasColumnName("NB_HEURE_COL_28");

                entity.Property(e => e.NbHeureCol29).HasColumnName("NB_HEURE_COL_29");

                entity.Property(e => e.NbHeureCol3).HasColumnName("NB_HEURE_COL_3");

                entity.Property(e => e.NbHeureCol30).HasColumnName("NB_HEURE_COL_30");

                entity.Property(e => e.NbHeureCol31).HasColumnName("NB_HEURE_COL_31");

                entity.Property(e => e.NbHeureCol32).HasColumnName("NB_HEURE_COL_32");

                entity.Property(e => e.NbHeureCol33).HasColumnName("NB_HEURE_COL_33");

                entity.Property(e => e.NbHeureCol34).HasColumnName("NB_HEURE_COL_34");

                entity.Property(e => e.NbHeureCol35).HasColumnName("NB_HEURE_COL_35");

                entity.Property(e => e.NbHeureCol36).HasColumnName("NB_HEURE_COL_36");

                entity.Property(e => e.NbHeureCol37).HasColumnName("NB_HEURE_COL_37");

                entity.Property(e => e.NbHeureCol38).HasColumnName("NB_HEURE_COL_38");

                entity.Property(e => e.NbHeureCol39).HasColumnName("NB_HEURE_COL_39");

                entity.Property(e => e.NbHeureCol4).HasColumnName("NB_HEURE_COL_4");

                entity.Property(e => e.NbHeureCol40).HasColumnName("NB_HEURE_COL_40");

                entity.Property(e => e.NbHeureCol41).HasColumnName("NB_HEURE_COL_41");

                entity.Property(e => e.NbHeureCol42).HasColumnName("NB_HEURE_COL_42");

                entity.Property(e => e.NbHeureCol43).HasColumnName("NB_HEURE_COL_43");

                entity.Property(e => e.NbHeureCol44).HasColumnName("NB_HEURE_COL_44");

                entity.Property(e => e.NbHeureCol45).HasColumnName("NB_HEURE_COL_45");

                entity.Property(e => e.NbHeureCol46).HasColumnName("NB_HEURE_COL_46");

                entity.Property(e => e.NbHeureCol47).HasColumnName("NB_HEURE_COL_47");

                entity.Property(e => e.NbHeureCol48).HasColumnName("NB_HEURE_COL_48");

                entity.Property(e => e.NbHeureCol49).HasColumnName("NB_HEURE_COL_49");

                entity.Property(e => e.NbHeureCol5).HasColumnName("NB_HEURE_COL_5");

                entity.Property(e => e.NbHeureCol50).HasColumnName("NB_HEURE_COL_50");

                entity.Property(e => e.NbHeureCol51).HasColumnName("NB_HEURE_COL_51");

                entity.Property(e => e.NbHeureCol52).HasColumnName("NB_HEURE_COL_52");

                entity.Property(e => e.NbHeureCol53).HasColumnName("NB_HEURE_COL_53");

                entity.Property(e => e.NbHeureCol54).HasColumnName("NB_HEURE_COL_54");

                entity.Property(e => e.NbHeureCol55).HasColumnName("NB_HEURE_COL_55");

                entity.Property(e => e.NbHeureCol56).HasColumnName("NB_HEURE_COL_56");

                entity.Property(e => e.NbHeureCol57).HasColumnName("NB_HEURE_COL_57");

                entity.Property(e => e.NbHeureCol58).HasColumnName("NB_HEURE_COL_58");

                entity.Property(e => e.NbHeureCol59).HasColumnName("NB_HEURE_COL_59");

                entity.Property(e => e.NbHeureCol6).HasColumnName("NB_HEURE_COL_6");

                entity.Property(e => e.NbHeureCol60).HasColumnName("NB_HEURE_COL_60");

                entity.Property(e => e.NbHeureCol7).HasColumnName("NB_HEURE_COL_7");

                entity.Property(e => e.NbHeureCol8).HasColumnName("NB_HEURE_COL_8");

                entity.Property(e => e.NbHeureCol9).HasColumnName("NB_HEURE_COL_9");

                entity.Property(e => e.NomCol1)
                    .HasColumnName("NOM_COL_1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol10)
                    .HasColumnName("NOM_COL_10")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol11)
                    .HasColumnName("NOM_COL_11")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol12)
                    .HasColumnName("NOM_COL_12")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol13)
                    .HasColumnName("NOM_COL_13")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol14)
                    .HasColumnName("NOM_COL_14")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol15)
                    .HasColumnName("NOM_COL_15")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol16)
                    .HasColumnName("NOM_COL_16")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol17)
                    .HasColumnName("NOM_COL_17")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol18)
                    .HasColumnName("NOM_COL_18")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol19)
                    .HasColumnName("NOM_COL_19")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol2)
                    .HasColumnName("NOM_COL_2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol20)
                    .HasColumnName("NOM_COL_20")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol21)
                    .HasColumnName("NOM_COL_21")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol22)
                    .HasColumnName("NOM_COL_22")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol23)
                    .HasColumnName("NOM_COL_23")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol24)
                    .HasColumnName("NOM_COL_24")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol25)
                    .HasColumnName("NOM_COL_25")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol26)
                    .HasColumnName("NOM_COL_26")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol27)
                    .HasColumnName("NOM_COL_27")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol28)
                    .HasColumnName("NOM_COL_28")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol29)
                    .HasColumnName("NOM_COL_29")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol3)
                    .HasColumnName("NOM_COL_3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol30)
                    .HasColumnName("NOM_COL_30")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol31)
                    .HasColumnName("NOM_COL_31")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol32)
                    .HasColumnName("NOM_COL_32")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol33)
                    .HasColumnName("NOM_COL_33")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol34)
                    .HasColumnName("NOM_COL_34")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol35)
                    .HasColumnName("NOM_COL_35")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol36)
                    .HasColumnName("NOM_COL_36")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol37)
                    .HasColumnName("NOM_COL_37")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol38)
                    .HasColumnName("NOM_COL_38")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol39)
                    .HasColumnName("NOM_COL_39")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol4)
                    .HasColumnName("NOM_COL_4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol40)
                    .HasColumnName("NOM_COL_40")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol41)
                    .HasColumnName("NOM_COL_41")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol42)
                    .HasColumnName("NOM_COL_42")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol43)
                    .HasColumnName("NOM_COL_43")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol44)
                    .HasColumnName("NOM_COL_44")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol45)
                    .HasColumnName("NOM_COL_45")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol46)
                    .HasColumnName("NOM_COL_46")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol47)
                    .HasColumnName("NOM_COL_47")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol48)
                    .HasColumnName("NOM_COL_48")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol49)
                    .HasColumnName("NOM_COL_49")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol5)
                    .HasColumnName("NOM_COL_5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol50)
                    .HasColumnName("NOM_COL_50")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol51)
                    .HasColumnName("NOM_COL_51")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol52)
                    .HasColumnName("NOM_COL_52")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol53)
                    .HasColumnName("NOM_COL_53")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol54)
                    .HasColumnName("NOM_COL_54")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol55)
                    .HasColumnName("NOM_COL_55")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol56)
                    .HasColumnName("NOM_COL_56")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol57)
                    .HasColumnName("NOM_COL_57")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol58)
                    .HasColumnName("NOM_COL_58")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol59)
                    .HasColumnName("NOM_COL_59")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol6)
                    .HasColumnName("NOM_COL_6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol60)
                    .HasColumnName("NOM_COL_60")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol7)
                    .HasColumnName("NOM_COL_7")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol8)
                    .HasColumnName("NOM_COL_8")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomCol9)
                    .HasColumnName("NOM_COL_9")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Numpromotioncs)
                    .HasColumnName("NUMPROMOTIONCS")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.TypeCol1)
                    .HasColumnName("TYPE_COL_1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol10)
                    .HasColumnName("TYPE_COL_10")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol11)
                    .HasColumnName("TYPE_COL_11")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol12)
                    .HasColumnName("TYPE_COL_12")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol13)
                    .HasColumnName("TYPE_COL_13")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol14)
                    .HasColumnName("TYPE_COL_14")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol15)
                    .HasColumnName("TYPE_COL_15")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol16)
                    .HasColumnName("TYPE_COL_16")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol17)
                    .HasColumnName("TYPE_COL_17")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol18)
                    .HasColumnName("TYPE_COL_18")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol19)
                    .HasColumnName("TYPE_COL_19")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol2)
                    .HasColumnName("TYPE_COL_2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol20)
                    .HasColumnName("TYPE_COL_20")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol21)
                    .HasColumnName("TYPE_COL_21")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol22)
                    .HasColumnName("TYPE_COL_22")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol23)
                    .HasColumnName("TYPE_COL_23")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol24)
                    .HasColumnName("TYPE_COL_24")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol25)
                    .HasColumnName("TYPE_COL_25")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol26)
                    .HasColumnName("TYPE_COL_26")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol27)
                    .HasColumnName("TYPE_COL_27")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol28)
                    .HasColumnName("TYPE_COL_28")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol29)
                    .HasColumnName("TYPE_COL_29")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol3)
                    .HasColumnName("TYPE_COL_3")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol30)
                    .HasColumnName("TYPE_COL_30")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol31)
                    .HasColumnName("TYPE_COL_31")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol32)
                    .HasColumnName("TYPE_COL_32")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol33)
                    .HasColumnName("TYPE_COL_33")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol34)
                    .HasColumnName("TYPE_COL_34")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol35)
                    .HasColumnName("TYPE_COL_35")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol36)
                    .HasColumnName("TYPE_COL_36")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol37)
                    .HasColumnName("TYPE_COL_37")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol38)
                    .HasColumnName("TYPE_COL_38")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol39)
                    .HasColumnName("TYPE_COL_39")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol4)
                    .HasColumnName("TYPE_COL_4")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol40)
                    .HasColumnName("TYPE_COL_40")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol41)
                    .HasColumnName("TYPE_COL_41")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol42)
                    .HasColumnName("TYPE_COL_42")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol43)
                    .HasColumnName("TYPE_COL_43")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol44)
                    .HasColumnName("TYPE_COL_44")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol45)
                    .HasColumnName("TYPE_COL_45")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol46)
                    .HasColumnName("TYPE_COL_46")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol47)
                    .HasColumnName("TYPE_COL_47")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol48)
                    .HasColumnName("TYPE_COL_48")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol49)
                    .HasColumnName("TYPE_COL_49")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol5)
                    .HasColumnName("TYPE_COL_5")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol50)
                    .HasColumnName("TYPE_COL_50")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol51)
                    .HasColumnName("TYPE_COL_51")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol52)
                    .HasColumnName("TYPE_COL_52")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol53)
                    .HasColumnName("TYPE_COL_53")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol54)
                    .HasColumnName("TYPE_COL_54")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol55)
                    .HasColumnName("TYPE_COL_55")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol56)
                    .HasColumnName("TYPE_COL_56")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol57)
                    .HasColumnName("TYPE_COL_57")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol58)
                    .HasColumnName("TYPE_COL_58")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol59)
                    .HasColumnName("TYPE_COL_59")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol6)
                    .HasColumnName("TYPE_COL_6")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol60)
                    .HasColumnName("TYPE_COL_60")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol7)
                    .HasColumnName("TYPE_COL_7")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol8)
                    .HasColumnName("TYPE_COL_8")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCol9)
                    .HasColumnName("TYPE_COL_9")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypePv)
                    .HasColumnName("TYPE_PV")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspRdi>(entity =>
            {
                entity.HasKey(e => e.IdRdi)
                    .HasName("ESP_RDI_PK");

                entity.ToTable("ESP_RDI");

                entity.Property(e => e.IdRdi)
                    .HasColumnName("ID_RDI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeH)
                    .HasColumnName("CHARGE_H")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeProduction)
                    .HasColumnName("CODE_PRODUCTION")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CodeRefProduction)
                    .HasColumnName("CODE_REF_PRODUCTION")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateProduction)
                    .HasColumnName("DATE_PRODUCTION")
                    .HasColumnType("DATE");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LibProduction)
                    .HasColumnName("LIB_PRODUCTION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LibRefProduction)
                    .HasColumnName("LIB_REF_PRODUCTION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomEns)
                    .HasColumnName("NOM_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PartiePrenente)
                    .HasColumnName("PARTIE_PRENENTE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspRealise>(entity =>
            {
                entity.HasKey(e => new { e.IdDr, e.Titre })
                    .HasName("PK_REALISE");

                entity.ToTable("ESP_REALISE");

                entity.Property(e => e.IdDr)
                    .HasColumnName("ID_DR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Titre)
                    .HasColumnName("TITRE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NbJours)
                    .HasColumnName("NB_JOURS")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.NomDr)
                    .IsRequired()
                    .HasColumnName("NOM_DR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Resultat)
                    .IsRequired()
                    .HasColumnName("RESULTAT")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspReclamation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_RECLAMATION");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateAbsence)
                    .HasColumnName("DATE_ABSENCE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateReclamation)
                    .HasColumnName("DATE_RECLAMATION")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumSeance).HasColumnName("NUM_SEANCE");

                entity.Property(e => e.TextReclamation)
                    .HasColumnName("TEXT_RECLAMATION")
                    .IsUnicode(false);

                entity.Property(e => e.TypeReclamation)
                    .HasColumnName("TYPE_RECLAMATION")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspReglementOnline>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.AnneeDeb, e.DateRglt })
                    .HasName("PK_REGLEMENT");

                entity.ToTable("ESP_REGLEMENT_ONLINE");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateRglt)
                    .HasColumnName("DATE_RGLT")
                    .HasColumnType("DATE");

                entity.Property(e => e.AnneeRglt)
                    .HasColumnName("ANNEE_RGLT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Comptabilise)
                    .HasColumnName("COMPTABILISE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.MotifRglt)
                    .HasColumnName("MOTIF_RGLT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RgltVeridfie)
                    .HasColumnName("RGLT_VERIDFIE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N' ");
            });

            modelBuilder.Entity<EspRemarqueAbsence>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.Semestre, e.IdEt, e.CodeCl, e.IdEns, e.DateRemarque })
                    .HasName("PK_ESP_REMARQUE");

                entity.ToTable("ESP_REMARQUE_ABSENCE");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateRemarque)
                    .HasColumnName("DATE_REMARQUE")
                    .HasColumnType("DATE");

                entity.Property(e => e.EtatConvocation)
                    .HasColumnName("ETAT_CONVOCATION")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LibelleRemarque)
                    .HasColumnName("LIBELLE_REMARQUE")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.EspSaisonClasse)
                    .WithMany(p => p.EspRemarqueAbsence)
                    .HasForeignKey(d => new { d.AnneeDeb, d.Semestre, d.CodeCl })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESP_REMARQUE_CODE_CL");
            });

            modelBuilder.Entity<EspRepassageExam>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.CodeModule, e.AnneeDeb })
                    .HasName("ESP_REPASSAGE_EXAM_PK");

                entity.ToTable("ESP_REPASSAGE_EXAM");

                entity.HasIndex(e => new { e.IdEt, e.CodeModule, e.DateSaisie, e.AnneeDeb })
                    .HasName("ESP_REPASSAGE_EXAM_PK")
                    .IsUnique();

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateExamen)
                    .HasColumnName("DATE_EXAMEN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.DescriptionAbs)
                    .HasColumnName("DESCRIPTION_ABS")
                    .IsUnicode(false);

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Heure)
                    .HasColumnName("HEURE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Motif)
                    .HasColumnName("MOTIF")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .IsUnicode(false);

                entity.Property(e => e.RepondreDemande)
                    .HasColumnName("REPONDRE_DEMANDE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'E'");

                entity.Property(e => e.Reponse1)
                    .HasColumnName("REPONSE1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'E'");

                entity.Property(e => e.Reponse2)
                    .HasColumnName("REPONSE2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'E'");

                entity.Property(e => e.Reponse3)
                    .HasColumnName("REPONSE3")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"'E'
   ");

                entity.Property(e => e.Salle)
                    .HasColumnName("SALLE")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspResponsableModule>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.CodeModule, e.IdEns, e.Etat })
                    .HasName("ESP_RESPONSABLE_UE_PK");

                entity.ToTable("ESP_RESPONSABLE_MODULE");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DateModif)
                    .HasColumnName("DATE_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.IdUserModif)
                    .HasColumnName("ID_USER_MODIF")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspReunionRdi>(entity =>
            {
                entity.HasKey(e => new { e.IdReunion, e.IdEns })
                    .HasName("ESP_REUNION_RDI_PK");

                entity.ToTable("ESP_REUNION_RDI");

                entity.Property(e => e.IdReunion)
                    .HasColumnName("ID_REUNION")
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateReunion)
                    .HasColumnName("DATE_REUNION")
                    .HasColumnType("DATE");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasColumnName("FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'R' ");

                entity.Property(e => e.HeureDeb)
                    .HasColumnName("HEURE_DEB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HeureFin)
                    .HasColumnName("HEURE_FIN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdGroupe)
                    .HasColumnName("ID_GROUPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Titre)
                    .IsRequired()
                    .HasColumnName("TITRE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspRubrique>(entity =>
            {
                entity.HasKey(e => e.CodeRub)
                    .HasName("PK_RUBRIQUE");

                entity.ToTable("ESP_RUBRIQUE");

                entity.Property(e => e.CodeRub)
                    .HasColumnName("CODE_RUB")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Signe)
                    .HasColumnName("SIGNE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Taux)
                    .HasColumnName("TAUX")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.Valeur)
                    .HasColumnName("VALEUR")
                    .HasColumnType("NUMBER(10,3)");
            });

            modelBuilder.Entity<EspSaisonClasse>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.Semestre, e.CodeCl });

                entity.ToTable("ESP_SAISON_CLASSE");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeFin)
                    .HasColumnName("ANNEE_FIN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ClAvecDispense)
                    .HasColumnName("CL_AVEC_DISPENSE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClEclate)
                    .HasColumnName("CL_ECLATE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ClasseEntreprise)
                    .HasColumnName("CLASSE_ENTREPRISE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClasseS2)
                    .HasColumnName("CLASSE_S2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCls1)
                    .HasColumnName("CODE_CLS1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateDemarrage)
                    .HasColumnName("DATE_DEMARRAGE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateEclatement)
                    .HasColumnName("DATE_ECLATEMENT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Filiere)
                    .HasColumnName("FILIERE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nature)
                    .HasColumnName("NATURE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NbEtudiant)
                    .HasColumnName("NB_ETUDIANT")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.NbSeance).HasColumnName("NB_SEANCE");

                entity.Property(e => e.NiveauAcces).HasColumnName("NIVEAU_ACCES");

                entity.Property(e => e.Numpromotioncs)
                    .HasColumnName("NUMPROMOTIONCS")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.PvSpSaved)
                    .HasColumnName("PV_SP_SAVED")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.PvSrSaved)
                    .HasColumnName("PV_SR_SAVED")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.SallePrincipale)
                    .HasColumnName("SALLE_PRINCIPALE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalleSecondaire1)
                    .HasColumnName("SALLE_SECONDAIRE_1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalleSecondaire2)
                    .HasColumnName("SALLE_SECONDAIRE_2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeClasse)
                    .HasColumnName("TYPE_CLASSE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TypePv)
                    .HasColumnName("TYPE_PV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'E'");

                entity.HasOne(d => d.AnneeDebNavigation)
                    .WithMany(p => p.EspSaisonClasse)
                    .HasForeignKey(d => d.AnneeDeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESP_SAIS_REFERENCE_ESP_SAIS");

                entity.HasOne(d => d.CodeClNavigation)
                    .WithMany(p => p.EspSaisonClasse)
                    .HasForeignKey(d => d.CodeCl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESP_SAIS_REFERENCE_CLASSE");
            });

            modelBuilder.Entity<EspSaisonUniversitaire>(entity =>
            {
                entity.HasKey(e => e.AnneeDeb);

                entity.ToTable("ESP_SAISON_UNIVERSITAIRE");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeFin)
                    .IsRequired()
                    .HasColumnName("ANNEE_FIN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspSalleClasse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_SALLE_CLASSE");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasColumnType("FLOAT");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("FLOAT");

                entity.Property(e => e.Salle)
                    .HasColumnName("SALLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspSalleDispo>(entity =>
            {
                entity.ToTable("ESP_SALLE_DISPO");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Salle)
                    .HasColumnName("SALLE")
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspSalleExamen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_SALLE_EXAMEN");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.DateSeance)
                    .HasColumnName("DATE_SEANCE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HeureDebut)
                    .HasColumnName("HEURE_DEBUT")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .HasColumnName("MODULE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumSeance)
                    .HasColumnName("NUM_SEANCE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Periode)
                    .HasColumnName("PERIODE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Salle1)
                    .HasColumnName("SALLE_1")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Salle2)
                    .HasColumnName("SALLE_2")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");
            });

            modelBuilder.Entity<EspSatisfaction>(entity =>
            {
                entity.HasKey(e => new { e.Codecrt, e.CodeModule, e.CodeNom, e.IdEt, e.NonSatisfait, e.Ordinaire, e.PriorityEns, e.Satisfait })
                    .HasName("SYS_C0011810");

                entity.ToTable("ESP_SATISFACTION");

                entity.Property(e => e.Codecrt).HasColumnName("CODECRT");

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CodeNom).HasColumnName("CODE_NOM");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NonSatisfait)
                    .HasColumnName("NON_SATISFAIT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinaire)
                    .HasColumnName("ORDINAIRE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PriorityEns)
                    .HasColumnName("PRIORITY_ENS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Satisfait)
                    .HasColumnName("SATISFAIT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AmeliorateStudy)
                    .HasColumnName("AMELIORATE_STUDY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateSurvey)
                    .HasColumnName("DATE_SURVEY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressOpinion)
                    .HasColumnName("EXPRESS_OPINION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PriorityCoach)
                    .HasColumnName("PRIORITY_COACH")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Unity)
                    .HasColumnName("UNITY")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspScoreSpecialite>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.CodeSpec, e.NiveauAcces })
                    .HasName("PK_SCORE_SPEC");

                entity.ToTable("ESP_SCORE_SPECIALITE");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeSpec)
                    .HasColumnName("CODE_SPEC")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NiveauAcces).HasColumnName("NIVEAU_ACCES");

                entity.Property(e => e.CapaciteAccueuil)
                    .HasColumnName("CAPACITE_ACCUEUIL")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.ScoreMin)
                    .HasColumnName("SCORE_MIN")
                    .HasColumnType("NUMBER(10,3)");
            });

            modelBuilder.Entity<EspSeanceEns>(entity =>
            {
                entity.HasKey(e => new { e.IdEns, e.CodeModule, e.AnneeDeb, e.CodeCl, e.DateSeance, e.Semestre })
                    .HasName("PK_ABSENCE_ENS_1");

                entity.ToTable("ESP_SEANCE_ENS");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateSeance)
                    .HasColumnName("DATE_SEANCE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.CodeMotif)
                    .HasColumnName("CODE_MOTIF")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HeureEntree)
                    .HasColumnName("HEURE_ENTREE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.HeureSortie).HasColumnName("HEURE_SORTIE");

                entity.Property(e => e.MinuteEntree).HasColumnName("MINUTE_ENTREE");

                entity.Property(e => e.MinuteSortie).HasColumnName("MINUTE_SORTIE");

                entity.Property(e => e.NbMinPause).HasColumnName("NB_MIN_PAUSE");

                entity.Property(e => e.NbSeance)
                    .HasColumnName("NB_SEANCE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.NumSeance).HasColumnName("NUM_SEANCE");

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Realisation)
                    .HasColumnName("REALISATION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeModuleNavigation)
                    .WithMany(p => p.EspSeanceEns)
                    .HasForeignKey(d => d.CodeModule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEANCE_ENS_MODULE_1");
            });

            modelBuilder.Entity<EspSeanceExamen>(entity =>
            {
                entity.HasKey(e => new { e.NumSeance, e.AnneeDeb, e.Site })
                    .HasName("ESP_SEANCE_EXAMEN2_PK");

                entity.ToTable("ESP_SEANCE_EXAMEN");

                entity.Property(e => e.NumSeance)
                    .HasColumnName("NUM_SEANCE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql(@"sysdate
   ");

                entity.Property(e => e.DateSeance)
                    .HasColumnName("DATE_SEANCE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Duree)
                    .HasColumnName("DUREE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.HeureDebut)
                    .HasColumnName("HEURE_DEBUT")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Jours)
                    .HasColumnName("JOURS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NivEtude)
                    .HasColumnName("NIV_ETUDE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumJours)
                    .HasColumnName("NUM_JOURS")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Periode)
                    .HasColumnName("PERIODE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");
            });

            modelBuilder.Entity<EspServEtdNavMirror>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_SERV_ETD_NAV_MIRROR");

                entity.Property(e => e.Actif)
                    .HasColumnName("ACTIF")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AnneePremInscription)
                    .HasColumnName("ANNEE_PREM_INSCRIPTION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDevise)
                    .HasColumnName("CODE_DEVISE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodeService)
                    .HasColumnName("CODE_SERVICE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateDebut)
                    .HasColumnName("DATE_DEBUT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateFin)
                    .HasColumnName("DATE_FIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Laureat)
                    .HasColumnName("LAUREAT")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspServNavMirror>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_SERV_NAV_MIRROR");

                entity.Property(e => e.Actif)
                    .HasColumnName("ACTIF")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AnneePremInscription)
                    .HasColumnName("ANNEE_PREM_INSCRIPTION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDevise)
                    .HasColumnName("CODE_DEVISE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodeService)
                    .HasColumnName("CODE_SERVICE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateDebut)
                    .HasColumnName("DATE_DEBUT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateFin)
                    .HasColumnName("DATE_FIN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Laureat)
                    .HasColumnName("LAUREAT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Numcompte)
                    .HasColumnName("NUMCOMPTE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspServiceEtudiantNav>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.AnneeDeb, e.CodeService })
                    .HasName("PK_SERVICE_ETUDIANT_NAV");

                entity.ToTable("ESP_SERVICE_ETUDIANT_NAV");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeService)
                    .HasColumnName("CODE_SERVICE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Actif)
                    .HasColumnName("ACTIF")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneePremInscription)
                    .HasColumnName("ANNEE_PREM_INSCRIPTION")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDevise)
                    .HasColumnName("CODE_DEVISE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DateDebut)
                    .HasColumnName("DATE_DEBUT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateFin)
                    .HasColumnName("DATE_FIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.Etab)
                    .HasColumnName("ETAB")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Laureat)
                    .HasColumnName("LAUREAT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Numcompte)
                    .HasColumnName("NUMCOMPTE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspSession>(entity =>
            {
                entity.HasKey(e => e.IdAdmin)
                    .HasName("SYS_C0011830");

                entity.ToTable("ESP_SESSION");

                entity.Property(e => e.IdAdmin)
                    .HasColumnName("ID_ADMIN")
                    .ValueGeneratedNever();

                entity.Property(e => e.EspensIdEns)
                    .HasColumnName("ESPENS_ID_ENS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Lgn)
                    .HasColumnName("LGN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasColumnName("PWD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnName("TYPE");
            });

            modelBuilder.Entity<EspStage5eme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_STAGE_5EME");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nomprenom)
                    .HasColumnName("NOMPRENOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspStageEte02>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_STAGE_ETE_02");

                entity.Property(e => e.Etudiant)
                    .HasColumnName("ETUDIANT")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.Identifiant)
                    .HasColumnName("IDENTIFIANT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Valide)
                    .HasColumnName("VALIDE")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspStageEteEm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_STAGE_ETE_EM");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasColumnName("PRENOM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Validation)
                    .HasColumnName("VALIDATION")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspStageEteGc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_STAGE_ETE_GC");

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasColumnName("PRENOM")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.Validation)
                    .HasColumnName("VALIDATION")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspStageEteLc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_STAGE_ETE_LC");

                entity.Property(e => e.Identifiant)
                    .HasColumnName("IDENTIFIANT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasColumnName("PRENOM")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Valide)
                    .HasColumnName("VALIDE")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspSuiviProjetIndiv>(entity =>
            {
                entity.HasKey(e => new { e.IdGroupe, e.AnneeDeb, e.IdEt, e.DateSuivi })
                    .HasName("PK_SUIVI_ET");

                entity.ToTable("ESP_SUIVI_PROJET_INDIV");

                entity.Property(e => e.IdGroupe)
                    .HasColumnName("ID_GROUPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateSuivi)
                    .HasColumnName("DATE_SUIVI")
                    .HasColumnType("DATE");

                entity.Property(e => e.Absent)
                    .HasColumnName("ABSENT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HeureDeb)
                    .HasColumnName("HEURE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.HeureFin)
                    .HasColumnName("HEURE_FIN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NoteComm)
                    .HasColumnName("NOTE_COMM")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NoteMotivation)
                    .HasColumnName("NOTE_MOTIVATION")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NoteRedaction)
                    .HasColumnName("NOTE_REDACTION")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NoteTechnique)
                    .HasColumnName("NOTE_TECHNIQUE")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.Observation)
                    .HasColumnName("OBSERVATION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.EspAffGroupEtudiant)
                    .WithMany(p => p.EspSuiviProjetIndiv)
                    .HasForeignKey(d => new { d.IdGroupe, d.AnneeDeb, d.IdEt })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SUIVI_ET");
            });

            modelBuilder.Entity<EspSurveillantDispo>(entity =>
            {
                entity.HasKey(e => e.IdEns)
                    .HasName("TABLE1_PK");

                entity.ToTable("ESP_SURVEILLANT_DISPO");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomEns)
                    .IsRequired()
                    .HasColumnName("NOM_ENS")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspSurveillantExamen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_SURVEILLANT_EXAMEN");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.DateSeance)
                    .HasColumnName("DATE_SEANCE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HeureDebut)
                    .HasColumnName("HEURE_DEBUT")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .HasColumnName("MODULE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumSeance)
                    .HasColumnName("NUM_SEANCE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Periode)
                    .HasColumnName("PERIODE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.Surveillant1)
                    .HasColumnName("SURVEILLANT_1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Surveillant2)
                    .HasColumnName("SURVEILLANT_2")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTabPlanSalle>(entity =>
            {
                entity.HasKey(e => e.CritereTri);

                entity.ToTable("ESP_TAB_PLAN_SALLE");

                entity.Property(e => e.CritereTri)
                    .HasColumnName("CRITERE_TRI")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeFin)
                    .HasColumnName("ANNEE_FIN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Groupe).HasColumnName("GROUPE");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTarifRubrique>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_TARIF_RUBRIQUE");

                entity.HasIndex(e => new { e.AnneeDeb, e.CodeRub })
                    .HasName("ESP_TARIF_RUBRIQUE_X")
                    .IsUnique();

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeRub)
                    .IsRequired()
                    .HasColumnName("CODE_RUB")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DeviseRub)
                    .HasColumnName("DEVISE_RUB")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LibelleRub)
                    .HasColumnName("LIBELLE_RUB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MontantRub)
                    .HasColumnName("MONTANT_RUB")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.MontantTtc)
                    .HasColumnName("MONTANT_TTC")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.MontantTva)
                    .HasColumnName("MONTANT_TVA")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.Tranche1Rub)
                    .HasColumnName("TRANCHE1_RUB")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.Tranche2Rub)
                    .HasColumnName("TRANCHE2_RUB")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.TvaRub)
                    .HasColumnName("TVA_RUB")
                    .HasColumnType("NUMBER(5,2)");
            });

            modelBuilder.Entity<EspTeacherClassroom>(entity =>
            {
                entity.HasKey(e => e.IdTeacher)
                    .HasName("ESP_TEACHER_CLASSROOM_PK");

                entity.ToTable("ESP_TEACHER_CLASSROOM");

                entity.Property(e => e.IdTeacher)
                    .HasColumnName("ID_TEACHER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NameTeacher)
                    .HasColumnName("NAME_TEACHER")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTempEtudiantEnreg>(entity =>
            {
                entity.HasKey(e => e.IdEt)
                    .HasName("CONSTRAINT17");

                entity.ToTable("ESP_TEMP_ETUDIANT_ENREG");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasColumnType("CHAR(16)");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEnsEntretien)
                    .HasColumnName("ID_ENS_ENTRETIEN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScoreEntretien)
                    .HasColumnName("SCORE_ENTRETIEN")
                    .HasColumnType("NUMBER(10,6)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<EspTempEx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_TEMP_EX");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cours)
                    .HasColumnName("COURS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateEx)
                    .HasColumnName("DATE_EX")
                    .HasColumnType("DATE");

                entity.Property(e => e.Heure)
                    .HasColumnName("HEURE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Jour)
                    .HasColumnName("JOUR")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTempEx2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_TEMP_EX2");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cours)
                    .HasColumnName("COURS")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DateEx)
                    .HasColumnName("DATE_EX")
                    .HasColumnType("DATE");

                entity.Property(e => e.Heure)
                    .HasColumnName("HEURE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Jour)
                    .HasColumnName("JOUR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTempEx3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_TEMP_EX3");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cours)
                    .HasColumnName("COURS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateEx)
                    .HasColumnName("DATE_EX")
                    .HasColumnType("DATE");

                entity.Property(e => e.Heure)
                    .HasColumnName("HEURE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Jour)
                    .HasColumnName("JOUR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTempEx4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_TEMP_EX4");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cours)
                    .HasColumnName("COURS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateEx)
                    .HasColumnName("DATE_EX")
                    .HasColumnType("DATE");

                entity.Property(e => e.Heure)
                    .HasColumnName("HEURE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Jour)
                    .HasColumnName("JOUR")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTempEx5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_TEMP_EX5");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cours)
                    .HasColumnName("COURS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateEx)
                    .HasColumnName("DATE_EX")
                    .HasColumnType("DATE");

                entity.Property(e => e.Heure)
                    .HasColumnName("HEURE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Jour)
                    .HasColumnName("JOUR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTempEx6>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_TEMP_EX6");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cours)
                    .HasColumnName("COURS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateEx)
                    .HasColumnName("DATE_EX")
                    .HasColumnType("DATE");

                entity.Property(e => e.Heure)
                    .HasColumnName("HEURE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Jour)
                    .HasColumnName("JOUR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTempModifClasse>(entity =>
            {
                entity.HasKey(e => e.IdEt)
                    .HasName("ESP_TEMP_MODIF_CLASSE_PK");

                entity.ToTable("ESP_TEMP_MODIF_CLASSE");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeClDemander)
                    .HasColumnName("CODE_CL_DEMANDER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql(@"SYSDATE
   ");

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");
            });

            modelBuilder.Entity<EspTempOrien>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_TEMP_ORIEN");

                entity.Property(e => e.Chfinal)
                    .HasColumnName("CHFINAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numchoix)
                    .HasColumnName("NUMCHOIX")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Scorchfinal)
                    .HasColumnName("SCORCHFINAL")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTempOrientation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_TEMP_ORIENTATION");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ch1)
                    .HasColumnName("CH1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ch10)
                    .HasColumnName("CH10")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ch11)
                    .HasColumnName("CH11")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ch2)
                    .HasColumnName("CH2")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ch3)
                    .HasColumnName("CH3")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ch4)
                    .HasColumnName("CH4")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ch5)
                    .HasColumnName("CH5")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ch6)
                    .HasColumnName("CH6")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ch7)
                    .HasColumnName("CH7")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ch8)
                    .HasColumnName("CH8")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ch9)
                    .HasColumnName("CH9")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ChoixFinal)
                    .HasColumnName("CHOIX_FINAL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numchoix)
                    .HasColumnName("NUMCHOIX")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Scorchfinal)
                    .HasColumnName("SCORCHFINAL")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTempScore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_TEMP_SCORE");

                entity.Property(e => e.CScoreDossier)
                    .HasColumnName("C_SCORE_DOSSIER")
                    .HasColumnType("NUMBER(10,6)");

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasColumnType("CHAR(16)");
            });

            modelBuilder.Entity<EspTestEns>(entity =>
            {
                entity.HasKey(e => new { e.IdEns, e.DateChoix })
                    .HasName("ESP_TEST_ENS_PK");

                entity.ToTable("ESP_TEST_ENS");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateChoix)
                    .HasColumnName("DATE_CHOIX")
                    .HasColumnType("DATE");

                entity.Property(e => e.TypeChoix)
                    .HasColumnName("TYPE_CHOIX")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeTest)
                    .IsRequired()
                    .HasColumnName("TYPE_TEST")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'T' ");
            });

            modelBuilder.Entity<EspTestEtud>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.TypeChoix, e.DateChoix, e.TypeTest })
                    .HasName("ESP_TEST_ETUD_PK");

                entity.ToTable("ESP_TEST_ETUD");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeChoix)
                    .HasColumnName("TYPE_CHOIX")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateChoix)
                    .HasColumnName("DATE_CHOIX")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.TypeTest)
                    .HasColumnName("TYPE_TEST")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'T' ");
            });

            modelBuilder.Entity<EspTicketInscription>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_TICKET_INSCRIPTION");

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .IsRequired()
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<EspTmpApp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_TMP_APP");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeClDemander)
                    .HasColumnName("CODE_CL_DEMANDER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Traitement)
                    .HasColumnName("TRAITEMENT")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTmpOrientation2018>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_TMP_ORIENTATION_2018");

                entity.Property(e => e.Ch)
                    .HasColumnName("CH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Chfinal)
                    .HasColumnName("CHFINAL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Chifina)
                    .HasColumnName("CHIFINA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Numchoix)
                    .HasColumnName("NUMCHOIX")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Scorchfinal)
                    .HasColumnName("SCORCHFINAL")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Score)
                    .HasColumnName("SCORE")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTmpSimulRachat>(entity =>
            {
                entity.HasKey(e => e.IdEt)
                    .HasName("SYS_C0011864");

                entity.ToTable("ESP_TMP_SIMUL_RACHAT");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MgSpApRach)
                    .HasColumnName("MG_SP_AP_RACH")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MgSpAvRach)
                    .HasColumnName("MG_SP_AV_RACH")
                    .HasColumnType("NUMBER(5,2)");
            });

            modelBuilder.Entity<EspToeicNb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_TOEIC_NB");

                entity.Property(e => e.Datetest)
                    .HasColumnName("DATETEST")
                    .HasColumnType("DATE");

                entity.Property(e => e.NbCondidatsAng)
                    .HasColumnName("NB_CONDIDATS_ANG")
                    .HasColumnType("NUMBER(25)");

                entity.Property(e => e.NbCondidatsFr)
                    .HasColumnName("NB_CONDIDATS_FR")
                    .HasColumnType("NUMBER(25)");

                entity.Property(e => e.Nbmax)
                    .HasColumnName("NBMAX")
                    .HasColumnType("NUMBER(25)");
            });

            modelBuilder.Entity<EspTraceCorrectNumcpt>(entity =>
            {
                entity.HasKey(e => new { e.IdEt, e.DateCorrect, e.TypeCorrect })
                    .HasName("PK_TRACEè_CORRECT_NUMCPT");

                entity.ToTable("ESP_TRACE_CORRECT_NUMCPT");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateCorrect)
                    .HasColumnName("DATE_CORRECT")
                    .HasColumnType("DATE");

                entity.Property(e => e.TypeCorrect)
                    .HasColumnName("TYPE_CORRECT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'SN'");

                entity.Property(e => e.NewNumcpt)
                    .HasColumnName("NEW_NUMCPT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OldNumcpt)
                    .HasColumnName("OLD_NUMCPT")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTraceImpPiece>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.NumImp })
                    .HasName("PK_TRACE_IMP");

                entity.ToTable("ESP_TRACE_IMP_PIECE");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NumImp).HasColumnName("NUM_IMP");

                entity.Property(e => e.DateImp)
                    .HasColumnName("DATE_IMP")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IpImp)
                    .HasColumnName("IP_IMP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineImp)
                    .HasColumnName("MACHINE_IMP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypePiece)
                    .HasColumnName("TYPE_PIECE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UserImp)
                    .HasColumnName("USER_IMP")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTransportEt>(entity =>
            {
                entity.HasKey(e => e.IdEt)
                    .HasName("ESP_TRANSPORT_ET_PK");

                entity.ToTable("ESP_TRANSPORT_ET");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ligne)
                    .HasColumnName("LIGNE")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTrvCours>(entity =>
            {
                entity.HasKey(e => new { e.IdDr, e.Titre })
                    .HasName("PK_COURS");

                entity.ToTable("ESP_TRV_COURS");

                entity.Property(e => e.IdDr)
                    .HasColumnName("ID_DR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Titre)
                    .HasColumnName("TITRE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DateDeb)
                    .HasColumnName("DATE_DEB")
                    .HasColumnType("DATE");

                entity.Property(e => e.NbrJoursPrsv)
                    .HasColumnName("NBR_JOURS_PRSV")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.NomDr)
                    .IsRequired()
                    .HasColumnName("NOM_DR")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspTrvQuot>(entity =>
            {
                entity.HasKey(e => new { e.IdDr, e.Titre })
                    .HasName("PK_QUOT");

                entity.ToTable("ESP_TRV_QUOT");

                entity.Property(e => e.IdDr)
                    .HasColumnName("ID_DR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Titre)
                    .HasColumnName("TITRE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DateDebAffec)
                    .HasColumnName("DATE_DEB_AFFEC")
                    .HasColumnType("DATE");

                entity.Property(e => e.NomDr)
                    .IsRequired()
                    .HasColumnName("NOM_DR")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspUe>(entity =>
            {
                entity.HasKey(e => new { e.CodeUe, e.AnneeDeb })
                    .HasName("PK_UE");

                entity.ToTable("ESP_UE");

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeH).HasColumnName("CHARGE_H");

                entity.Property(e => e.CodeFiliere)
                    .HasColumnName("CODE_FILIERE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LibUe)
                    .HasColumnName("LIB_UE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NatureUe)
                    .HasColumnName("NATURE_UE")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'O'");

                entity.Property(e => e.NbEcts)
                    .HasColumnName("NB_ECTS")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TypeUe)
                    .HasColumnName("TYPE_UE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.HasOne(d => d.CodeFiliereNavigation)
                    .WithMany(p => p.EspUe)
                    .HasForeignKey(d => d.CodeFiliere)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UE_FILIERE");
            });

            modelBuilder.Entity<EspUe5emetelinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESP_UE_5EMETELINFO");

                entity.Property(e => e.ChargeH).HasColumnName("CHARGE_H");

                entity.Property(e => e.CodeFiliere)
                    .HasColumnName("CODE_FILIERE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.LibUe)
                    .HasColumnName("LIB_UE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NbEcts).HasColumnName("NB_ECTS");
            });

            modelBuilder.Entity<EspUp>(entity =>
            {
                entity.HasKey(e => e.Up)
                    .HasName("PK_UP");

                entity.ToTable("ESP_UP");

                entity.Property(e => e.Up)
                    .HasColumnName("UP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDept)
                    .HasColumnName("CODE_DEPT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Designantion)
                    .HasColumnName("DESIGNANTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspWhiteList>(entity =>
            {
                entity.HasKey(e => e.IdEt)
                    .HasName("PK_WHITE_ET");

                entity.ToTable("ESP_WHITE_LIST");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateLimite)
                    .HasColumnName("DATE_LIMITE")
                    .HasColumnType("DATE");

                entity.Property(e => e.MontFrais)
                    .HasColumnName("MONT_FRAIS")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.MontRegle)
                    .HasColumnName("MONT_REGLE")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumCpt)
                    .HasColumnName("NUM_CPT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspritNavcustomersco>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESPRIT$NAVCUSTOMERSCO");

                entity.HasIndex(e => e.IdEt)
                    .HasName("KEY_CUSTOMER")
                    .IsUnique();

                entity.Property(e => e.GroupeTarif)
                    .HasColumnName("GROUPE_TARIF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasColumnName("NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspritNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESPRIT$NEW");

                entity.Property(e => e.Compte)
                    .HasColumnName("COMPTE")
                    .HasColumnType("NUMBER(15)");

                entity.Property(e => e.Matricule)
                    .HasColumnName("MATRICULE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nomprenom)
                    .HasColumnName("NOMPRENOM")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EtDiplomeNew>(entity =>
            {
                entity.HasKey(e => e.N)
                    .HasName("PK_DIPLOME_NEW");

                entity.ToTable("ET_DIPLOME_NEW");

                entity.Property(e => e.N)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EtatPaiement>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.IdEt, e.Ordernumber })
                    .HasName("ETATPAIEMENT_PK");

                entity.ToTable("ETAT_PAIEMENT");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ordernumber)
                    .HasColumnName("ORDERNUMBER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Authcode)
                    .HasColumnName("AUTHCODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cardholdername)
                    .HasColumnName("CARDHOLDERNAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.Depositamount)
                    .HasColumnName("DEPOSITAMOUNT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Errorcode)
                    .HasColumnName("ERRORCODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Errormessage)
                    .IsRequired()
                    .HasColumnName("ERRORMESSAGE")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Expiration)
                    .HasColumnName("EXPIRATION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Orderstatus)
                    .HasColumnName("ORDERSTATUS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Etud>(entity =>
            {
                entity.HasKey(e => e.IdEt)
                    .HasName("CONSTRAINT5");

                entity.ToTable("ETUD");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("MAIL")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EtudiantRatt2016>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ETUDIANT_RATT_2016");

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasColumnName("DESIGNATION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fichepfe>(entity =>
            {
                entity.HasKey(e => e.IdFiche)
                    .HasName("SYS_C0011910");

                entity.ToTable("FICHEPFE");

                entity.Property(e => e.IdFiche).HasColumnName("ID_FICHE");

                entity.Property(e => e.Acorrigerstage).HasColumnName("ACORRIGERSTAGE");

                entity.Property(e => e.AdressEntreprise)
                    .HasColumnName("ADRESS_ENTREPRISE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Avis)
                    .HasColumnName("AVIS")
                    .IsUnicode(false);

                entity.Property(e => e.Dateenvoie)
                    .HasColumnName("DATEENVOIE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Descriptionsujet)
                    .HasColumnName("DESCRIPTIONSUJET")
                    .IsUnicode(false);

                entity.Property(e => e.EtIdEt)
                    .HasColumnName("ET_ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fonctionnalitesujet)
                    .HasColumnName("FONCTIONNALITESUJET")
                    .IsUnicode(false);

                entity.Property(e => e.MailEntreprise)
                    .HasColumnName("MAIL_ENTREPRISE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NomEncad)
                    .HasColumnName("NOM_ENCAD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NomEncadEsprit)
                    .HasColumnName("NOM_ENCAD_ESPRIT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NomEntreprise)
                    .HasColumnName("NOM_ENTREPRISE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Prerequisujet)
                    .HasColumnName("PREREQUISUJET")
                    .IsUnicode(false);

                entity.Property(e => e.Probelematiquesujet)
                    .HasColumnName("PROBELEMATIQUESUJET")
                    .IsUnicode(false);

                entity.Property(e => e.Regectedinfo).HasColumnName("REGECTEDINFO");

                entity.Property(e => e.Regis).HasColumnName("REGIS");

                entity.Property(e => e.Rehectedstage).HasColumnName("REHECTEDSTAGE");

                entity.Property(e => e.TelephoneEntreprise).HasColumnName("TELEPHONE_ENTREPRISE");

                entity.Property(e => e.Valid).HasColumnName("VALID");

                entity.Property(e => e.Validateinfo).HasColumnName("VALIDATEINFO");
            });

            modelBuilder.Entity<FormRate>(entity =>
            {
                entity.HasKey(e => new { e.Idformation, e.IdEns, e.IdQuestion })
                    .HasName("FORM_RATE_PK");

                entity.ToTable("FORM_RATE");

                entity.Property(e => e.Idformation)
                    .HasColumnName("IDFORMATION")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdQuestion)
                    .HasColumnName("ID_QUESTION")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Rate)
                    .HasColumnName("RATE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Ratetext)
                    .HasColumnName("RATETEXT")
                    .IsUnicode(false);

                entity.HasOne(d => d.IdQuestionNavigation)
                    .WithMany(p => p.FormRate)
                    .HasForeignKey(d => d.IdQuestion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FORM_RATE_FK2");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.FormRate)
                    .HasForeignKey(d => new { d.Idformation, d.IdEns })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FORM_RATE_FK1");
            });

            modelBuilder.Entity<FormaEval>(entity =>
            {
                entity.ToTable("FORMA_EVAL");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Critere)
                    .IsRequired()
                    .HasColumnName("CRITERE")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Indicateur)
                    .IsRequired()
                    .HasColumnName("INDICATEUR")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Typeeval)
                    .HasColumnName("TYPEEVAL")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Visible)
                    .HasColumnName("VISIBLE")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<FrCursus>(entity =>
            {
                entity.HasKey(e => e.IdCursus)
                    .HasName("SYS_C0011924");

                entity.ToTable("FR_CURSUS");

                entity.Property(e => e.IdCursus)
                    .HasColumnName("ID_CURSUS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AnneeCursus)
                    .HasColumnName("ANNEE_CURSUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FinCursus)
                    .HasColumnName("FIN_CURSUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LibelleCursus)
                    .HasColumnName("LIBELLE_CURSUS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCursus)
                    .HasColumnName("TYPE_CURSUS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Groupe>(entity =>
            {
                entity.HasKey(e => e.IdGroupe)
                    .HasName("GROUPE_PK");

                entity.ToTable("GROUPE");

                entity.Property(e => e.IdGroupe)
                    .HasColumnName("ID_GROUPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .IsRequired()
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .IsRequired()
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasColumnName("DESIGNATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdProjet)
                    .HasColumnName("ID_PROJET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("MODULE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumSemestre)
                    .HasColumnName("NUM_SEMESTRE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Utilisateur)
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleNavigation)
                    .WithMany(p => p.Groupe)
                    .HasForeignKey(d => d.Module)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GROUPE_FK2");

                entity.HasOne(d => d.Projet)
                    .WithMany(p => p.Groupe)
                    .HasForeignKey(d => new { d.IdProjet, d.CodeCl })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("GROUPE_FK1");
            });

            modelBuilder.Entity<GroupeInscription>(entity =>
            {
                entity.HasKey(e => new { e.IdGroupe, e.IdEt, e.AnneeDeb })
                    .HasName("GROUPE_INSCRIPTION_PK");

                entity.ToTable("GROUPE_INSCRIPTION");

                entity.Property(e => e.IdGroupe)
                    .HasColumnName("ID_GROUPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.EspInscription)
                    .WithMany(p => p.GroupeInscription)
                    .HasForeignKey(d => new { d.AnneeDeb, d.IdEt })
                    .HasConstraintName("GROUPE_INSCRIPTION_FK1");
            });

            modelBuilder.Entity<Groupuser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GROUPUSER");

                entity.Property(e => e.Groupname)
                    .HasColumnName("GROUPNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoriquePaiement>(entity =>
            {
                entity.HasKey(e => e.Ordernumber)
                    .HasName("HISTORIQUE_PAIEMENT_PK");

                entity.ToTable("HISTORIQUE_PAIEMENT");

                entity.Property(e => e.Ordernumber)
                    .HasColumnName("ORDERNUMBER")
                    .HasColumnType("NUMBER(25)");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DatePaiement)
                    .HasColumnName("DATE_PAIEMENT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Orderid)
                    .HasColumnName("ORDERID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Returnurl)
                    .HasColumnName("RETURNURL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IdApprec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ID_APPREC");

                entity.Property(e => e.ApprecName)
                    .HasColumnName("APPREC_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ApprecVal).HasColumnName("APPREC_VAL");
            });

            modelBuilder.Entity<IdChoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ID_CHOICE");

                entity.Property(e => e.ChoiceName)
                    .HasColumnName("CHOICE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChoiceVal).HasColumnName("CHOICE_VAL");
            });

            modelBuilder.Entity<IdMeet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ID_MEET");

                entity.Property(e => e.MeetName)
                    .HasColumnName("MEET_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeetVal).HasColumnName("MEET_VAL");
            });

            modelBuilder.Entity<IdResume>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ID_RESUME");

                entity.Property(e => e.ResumeName)
                    .HasColumnName("RESUME_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResumeVal).HasColumnName("RESUME_VAL");
            });

            modelBuilder.Entity<IdStuden>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ID_STUDEN");

                entity.Property(e => e.StudenName)
                    .HasColumnName("STUDEN_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StudenVal).HasColumnName("STUDEN_VAL");
            });

            modelBuilder.Entity<IdUtilis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ID_UTILIS");

                entity.Property(e => e.UtilisName)
                    .HasColumnName("UTILIS_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UtilisVal).HasColumnName("UTILIS_VAL");
            });

            modelBuilder.Entity<Jeton>(entity =>
            {
                entity.HasKey(e => e.IdJeton);

                entity.ToTable("JETON");

                entity.Property(e => e.IdJeton)
                    .HasColumnName("ID_JETON")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.NomJeton)
                    .IsRequired()
                    .HasColumnName("NOM_JETON")
                    .HasMaxLength(20);

                entity.Property(e => e.TypeCcna)
                    .HasColumnName("TYPE_CCNA")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mapdsex161711Ghazala>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MAPDSEX_1617_11_GHAZALA");

                entity.Property(e => e.DateSeance)
                    .HasColumnName("DATE_SEANCE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HeureDebut)
                    .HasColumnName("HEURE_DEBUT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Jours)
                    .HasColumnName("JOURS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.No)
                    .HasColumnName("NO")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e._1a1)
                    .HasColumnName("1A1")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a10)
                    .HasColumnName("1A10")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a11)
                    .HasColumnName("1A11")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a12)
                    .HasColumnName("1A12")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a2)
                    .HasColumnName("1A2")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a3)
                    .HasColumnName("1A3")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a4)
                    .HasColumnName("1A4")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a5)
                    .HasColumnName("1A5")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a6)
                    .HasColumnName("1A6")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a7)
                    .HasColumnName("1A7")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a8)
                    .HasColumnName("1A8")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a9)
                    .HasColumnName("1A9")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Mapx161711Ghazala>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MAPX_1617_11_GHAZALA");

                entity.Property(e => e.DateSeance)
                    .HasColumnName("DATE_SEANCE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HeureDebut)
                    .HasColumnName("HEURE_DEBUT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Jours)
                    .HasColumnName("JOURS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.No)
                    .HasColumnName("NO")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e._1a1)
                    .HasColumnName("1A1")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a10)
                    .HasColumnName("1A10")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a11)
                    .HasColumnName("1A11")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a12)
                    .HasColumnName("1A12")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a2)
                    .HasColumnName("1A2")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a3)
                    .HasColumnName("1A3")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a4)
                    .HasColumnName("1A4")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a5)
                    .HasColumnName("1A5")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a6)
                    .HasColumnName("1A6")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a7)
                    .HasColumnName("1A7")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a8)
                    .HasColumnName("1A8")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e._1a9)
                    .HasColumnName("1A9")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MESSAGES");

                entity.HasIndex(e => e.Msgid)
                    .HasName("MESSAGES_X")
                    .IsUnique();

                entity.Property(e => e.Msgbutton)
                    .IsRequired()
                    .HasColumnName("MSGBUTTON")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Msgdefaultbutton)
                    .HasColumnName("MSGDEFAULTBUTTON")
                    .HasColumnType("FLOAT");

                entity.Property(e => e.Msgicon)
                    .IsRequired()
                    .HasColumnName("MSGICON")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Msgid)
                    .IsRequired()
                    .HasColumnName("MSGID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Msgprint)
                    .IsRequired()
                    .HasColumnName("MSGPRINT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Msgseverity)
                    .HasColumnName("MSGSEVERITY")
                    .HasColumnType("FLOAT");

                entity.Property(e => e.Msgtext)
                    .IsRequired()
                    .HasColumnName("MSGTEXT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Msgtitle)
                    .IsRequired()
                    .HasColumnName("MSGTITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Msguserinput)
                    .IsRequired()
                    .HasColumnName("MSGUSERINPUT")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Miseajour>(entity =>
            {
                entity.HasKey(e => new { e.Annee, e.Identifiant })
                    .HasName("MISEAJOUR_PK");

                entity.ToTable("MISEAJOUR");

                entity.Property(e => e.Annee)
                    .HasColumnName("ANNEE")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Identifiant)
                    .HasColumnName("IDENTIFIANT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Decision)
                    .HasColumnName("DECISION")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SessionPrincipale)
                    .HasColumnName("SESSION_PRINCIPALE")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.SessionRattrapage)
                    .HasColumnName("SESSION_RATTRAPAGE")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Noteseminaire>(entity =>
            {
                entity.HasKey(e => e.Idnote)
                    .HasName("SYS_C0011960");

                entity.ToTable("NOTESEMINAIRE");

                entity.Property(e => e.Idnote)
                    .HasColumnName("IDNOTE")
                    .ValueGeneratedNever();

                entity.Property(e => e.EtudiantIdEt)
                    .HasColumnName("ETUDIANT_ID_ET")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasColumnType("FLOAT");

                entity.Property(e => e.Notecontrole)
                    .HasColumnName("NOTECONTROLE")
                    .HasColumnType("FLOAT");

                entity.Property(e => e.SeminaireIdseminaire).HasColumnName("SEMINAIRE_IDSEMINAIRE");

                entity.HasOne(d => d.SeminaireIdseminaireNavigation)
                    .WithMany(p => p.Noteseminaire)
                    .HasForeignKey(d => d.SeminaireIdseminaire)
                    .HasConstraintName("FK2803DF294E3C526");
            });

            modelBuilder.Entity<Pbcatcol>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PBCATCOL");

                entity.HasIndex(e => new { e.PbcTnam, e.PbcOwnr, e.PbcCnam })
                    .HasName("PBSYSCATCOLDICT_IDX")
                    .IsUnique();

                entity.Property(e => e.PbcBmap)
                    .HasColumnName("PBC_BMAP")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.PbcCase)
                    .HasColumnName("PBC_CASE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbcCid)
                    .HasColumnName("PBC_CID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbcCmnt)
                    .HasColumnName("PBC_CMNT")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.PbcCnam)
                    .IsRequired()
                    .HasColumnName("PBC_CNAM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PbcEdit)
                    .HasColumnName("PBC_EDIT")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.PbcHdr)
                    .HasColumnName("PBC_HDR")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.PbcHght)
                    .HasColumnName("PBC_HGHT")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbcHpos)
                    .HasColumnName("PBC_HPOS")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbcInit)
                    .HasColumnName("PBC_INIT")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.PbcJtfy)
                    .HasColumnName("PBC_JTFY")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbcLabl)
                    .HasColumnName("PBC_LABL")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.PbcLpos)
                    .HasColumnName("PBC_LPOS")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbcMask)
                    .HasColumnName("PBC_MASK")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.PbcOwnr)
                    .IsRequired()
                    .HasColumnName("PBC_OWNR")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PbcPtrn)
                    .HasColumnName("PBC_PTRN")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.PbcTag)
                    .HasColumnName("PBC_TAG")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.PbcTid)
                    .HasColumnName("PBC_TID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbcTnam)
                    .IsRequired()
                    .HasColumnName("PBC_TNAM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PbcWdth)
                    .HasColumnName("PBC_WDTH")
                    .HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<Pbcatedt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PBCATEDT");

                entity.HasIndex(e => new { e.PbeName, e.PbeSeqn })
                    .HasName("PBSYSPBE_IDX")
                    .IsUnique();

                entity.Property(e => e.PbeCntr)
                    .HasColumnName("PBE_CNTR")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbeEdit)
                    .HasColumnName("PBE_EDIT")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.PbeFlag)
                    .HasColumnName("PBE_FLAG")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbeName)
                    .HasColumnName("PBE_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PbeSeqn)
                    .HasColumnName("PBE_SEQN")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbeType)
                    .HasColumnName("PBE_TYPE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbeWork)
                    .HasColumnName("PBE_WORK")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pbcatfmt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PBCATFMT");

                entity.HasIndex(e => e.PbfName)
                    .HasName("PBSYSCATFRMTS_IDX")
                    .IsUnique();

                entity.Property(e => e.PbfCntr)
                    .HasColumnName("PBF_CNTR")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbfFrmt)
                    .HasColumnName("PBF_FRMT")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.PbfName)
                    .HasColumnName("PBF_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PbfType)
                    .HasColumnName("PBF_TYPE")
                    .HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<Pbcattbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PBCATTBL");

                entity.HasIndex(e => new { e.PbtTnam, e.PbtOwnr })
                    .HasName("PBSYSCATPBT_IDX")
                    .IsUnique();

                entity.Property(e => e.PbdFchr)
                    .HasColumnName("PBD_FCHR")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbdFfce)
                    .HasColumnName("PBD_FFCE")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PbdFhgt)
                    .HasColumnName("PBD_FHGT")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbdFitl)
                    .HasColumnName("PBD_FITL")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.PbdFptc)
                    .HasColumnName("PBD_FPTC")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbdFunl)
                    .HasColumnName("PBD_FUNL")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.PbdFwgt)
                    .HasColumnName("PBD_FWGT")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbhFchr)
                    .HasColumnName("PBH_FCHR")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbhFfce)
                    .HasColumnName("PBH_FFCE")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PbhFhgt)
                    .HasColumnName("PBH_FHGT")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbhFitl)
                    .HasColumnName("PBH_FITL")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.PbhFptc)
                    .HasColumnName("PBH_FPTC")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbhFunl)
                    .HasColumnName("PBH_FUNL")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.PbhFwgt)
                    .HasColumnName("PBH_FWGT")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PblFchr)
                    .HasColumnName("PBL_FCHR")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PblFfce)
                    .HasColumnName("PBL_FFCE")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PblFhgt)
                    .HasColumnName("PBL_FHGT")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PblFitl)
                    .HasColumnName("PBL_FITL")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.PblFptc)
                    .HasColumnName("PBL_FPTC")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PblFunl)
                    .HasColumnName("PBL_FUNL")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.PblFwgt)
                    .HasColumnName("PBL_FWGT")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbtCmnt)
                    .HasColumnName("PBT_CMNT")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.PbtOwnr)
                    .IsRequired()
                    .HasColumnName("PBT_OWNR")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PbtTid)
                    .HasColumnName("PBT_TID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbtTnam)
                    .IsRequired()
                    .HasColumnName("PBT_TNAM")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pbcatvld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PBCATVLD");

                entity.HasIndex(e => e.PbvName)
                    .HasName("PBSYSCATVLDS_IDX")
                    .IsUnique();

                entity.Property(e => e.PbvCntr)
                    .HasColumnName("PBV_CNTR")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbvMsg)
                    .HasColumnName("PBV_MSG")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.PbvName)
                    .HasColumnName("PBV_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PbvType)
                    .HasColumnName("PBV_TYPE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PbvVald)
                    .HasColumnName("PBV_VALD")
                    .HasMaxLength(254)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Phase>(entity =>
            {
                entity.HasKey(e => e.IdPhase)
                    .HasName("PHASE_PK");

                entity.ToTable("PHASE");

                entity.Property(e => e.IdPhase)
                    .HasColumnName("ID_PHASE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateDeb)
                    .HasColumnName("DATE_DEB")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateFin)
                    .HasColumnName("DATE_FIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.Designation)
                    .HasColumnName("DESIGNATION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NbreSeance)
                    .HasColumnName("NBRE_SEANCE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Objectif)
                    .HasColumnName("OBJECTIF")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeModuleNavigation)
                    .WithMany(p => p.Phase)
                    .HasForeignKey(d => d.CodeModule)
                    .HasConstraintName("PHASE_FK1");
            });

            modelBuilder.Entity<PlanTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PLAN_TABLE");

                entity.Property(e => e.Bytes)
                    .HasColumnName("BYTES")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Cardinality)
                    .HasColumnName("CARDINALITY")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Cost)
                    .HasColumnName("COST")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.CpuCost)
                    .HasColumnName("CPU_COST")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Distribution)
                    .HasColumnName("DISTRIBUTION")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.IoCost)
                    .HasColumnName("IO_COST")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ObjectInstance)
                    .HasColumnName("OBJECT_INSTANCE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ObjectName)
                    .HasColumnName("OBJECT_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectNode)
                    .HasColumnName("OBJECT_NODE")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectOwner)
                    .HasColumnName("OBJECT_OWNER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("OBJECT_TYPE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Operation)
                    .HasColumnName("OPERATION")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Optimizer)
                    .HasColumnName("OPTIMIZER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Options)
                    .HasColumnName("OPTIONS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Other)
                    .HasColumnName("OTHER")
                    .HasColumnType("LONG");

                entity.Property(e => e.OtherTag)
                    .HasColumnName("OTHER_TAG")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnName("PARENT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PartitionId)
                    .HasColumnName("PARTITION_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PartitionStart)
                    .HasColumnName("PARTITION_START")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PartitionStop)
                    .HasColumnName("PARTITION_STOP")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasColumnName("POSITION")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SearchColumns)
                    .HasColumnName("SEARCH_COLUMNS")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.StatementId)
                    .HasColumnName("STATEMENT_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempSpace)
                    .HasColumnName("TEMP_SPACE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasColumnType("DATE");
            });

            modelBuilder.Entity<Presidentjury>(entity =>
            {
                entity.ToTable("PRESIDENTJURY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fonction)
                    .HasColumnName("FONCTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Juryref).HasColumnName("JURYREF");

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasColumnName("PRENOM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Societe)
                    .HasColumnName("SOCIETE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("TEL")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Presoutenance>(entity =>
            {
                entity.HasKey(e => e.IdPresoutenance)
                    .HasName("SYS_C0011975");

                entity.ToTable("PRESOUTENANCE");

                entity.Property(e => e.IdPresoutenance)
                    .HasColumnName("ID_PRESOUTENANCE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dte)
                    .HasColumnName("DTE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EtIdEt)
                    .HasColumnName("ET_ID_ET")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Etat).HasColumnName("ETAT");

                entity.Property(e => e.Heure)
                    .HasColumnName("HEURE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SessionpsoutIdsoutenance).HasColumnName("SESSIONPSOUT_IDSOUTENANCE");

                entity.HasOne(d => d.SessionpsoutIdsoutenanceNavigation)
                    .WithMany(p => p.Presoutenance)
                    .HasForeignKey(d => d.SessionpsoutIdsoutenance)
                    .HasConstraintName("FK5695AE16E573C3E9");
            });

            modelBuilder.Entity<Projet>(entity =>
            {
                entity.HasKey(e => new { e.IdProjet, e.CodeCl })
                    .HasName("PROJETS_PK1");

                entity.ToTable("PROJET");

                entity.Property(e => e.IdProjet)
                    .HasColumnName("ID_PROJET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateModif)
                    .HasColumnName("DATE_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Methodologie)
                    .HasColumnName("METHODOLOGIE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumSemestre)
                    .HasColumnName("NUM_SEMESTRE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Technologies)
                    .HasColumnName("TECHNOLOGIES")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TitreProjet)
                    .IsRequired()
                    .HasColumnName("TITRE_PROJET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeModuleNavigation)
                    .WithMany(p => p.Projet)
                    .HasForeignKey(d => d.CodeModule)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("PROJET_FK1");
            });

            modelBuilder.Entity<PvDiplome201805>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PV_DIPLOME_2018_05");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.DateDEdition)
                    .HasColumnName("DATE_D_EDITION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateDelivrance)
                    .HasColumnName("DATE_DELIVRANCE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateNaisEt)
                    .HasColumnName("DATE_NAIS_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InscritInscrite)
                    .HasColumnName("INSCRIT_INSCRITE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LibSpecialiteEspEt)
                    .HasColumnName("LIB_SPECIALITE_ESP_ET")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.LieuDelivrance)
                    .HasColumnName("LIEU_DELIVRANCE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LieuNaisEt)
                    .HasColumnName("LIEU_NAIS_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasColumnName("MAIL")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Mmelle)
                    .HasColumnName("MMELLE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nationalite)
                    .HasColumnName("NATIONALITE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nenee)
                    .HasColumnName("NENEE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.NumCinPasseport)
                    .HasColumnName("NUM_CIN_PASSEPORT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumDip)
                    .HasColumnName("NUM_DIP")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Session)
                    .HasColumnName("SESSION_")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Sexe)
                    .HasColumnName("SEXE")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PvDiplome201901>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PV_DIPLOME_2019_01");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Colonne21)
                    .HasColumnName("COLONNE21")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateDEdition)
                    .HasColumnName("DATE_D_EDITION")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DateDelivrance)
                    .HasColumnName("DATE_DELIVRANCE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateNaisEt)
                    .HasColumnName("DATE_NAIS_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InscritInscrite)
                    .HasColumnName("INSCRIT_INSCRITE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LibSpecialiteEspEt)
                    .HasColumnName("LIB_SPECIALITE_ESP_ET")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.LieuDelivrance)
                    .HasColumnName("LIEU_DELIVRANCE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LieuNaisEt)
                    .HasColumnName("LIEU_NAIS_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasColumnName("MAIL")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Mmelle)
                    .HasColumnName("MMELLE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Nationalite)
                    .HasColumnName("NATIONALITE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nenee)
                    .HasColumnName("NENEE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.NumCinPasseport)
                    .HasColumnName("NUM_CIN_PASSEPORT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumDip)
                    .HasColumnName("NUM_DIP")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Session)
                    .HasColumnName("SESSION_")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Sexe)
                    .HasColumnName("SEXE")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Quitus>(entity =>
            {
                entity.HasKey(e => e.Idquitus)
                    .HasName("SYS_C0011983");

                entity.ToTable("QUITUS");

                entity.Property(e => e.Idquitus)
                    .HasColumnName("IDQUITUS")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comite)
                    .HasColumnName("COMITE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Credit)
                    .HasColumnName("CREDIT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Depotrapport)
                    .HasColumnName("DEPOTRAPPORT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Encadeur)
                    .HasColumnName("ENCADEUR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Etatfinancier)
                    .HasColumnName("ETATFINANCIER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EtdIdEt)
                    .HasColumnName("ETD_ID_ET")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reclamationn>(entity =>
            {
                entity.HasKey(e => e.IdReclamtion)
                    .HasName("PK_RECLAMATION");

                entity.ToTable("RECLAMATIONN");

                entity.Property(e => e.IdReclamtion)
                    .HasColumnName("ID_RECLAMTION")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateTraitement)
                    .HasColumnName("DATE_TRAITEMENT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdEnteteReclamation)
                    .HasColumnName("ID_ENTETE_RECLAMATION")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.NomEns)
                    .IsRequired()
                    .HasColumnName("NOM_ENS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Traiter)
                    .IsRequired()
                    .HasColumnName("TRAITER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Utilisateur)
                    .IsRequired()
                    .HasColumnName("UTILISATEUR")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Resume>(entity =>
            {
                entity.ToTable("RESUME");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CriterionCodecrt).HasColumnName("CRITERION_CODECRT");

                entity.Property(e => e.DateParticipation)
                    .HasColumnName("DATE_PARTICIPATION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FinalValidation).HasColumnName("FINAL_VALIDATION");

                entity.Property(e => e.Result)
                    .HasColumnName("RESULT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StudentIdEt)
                    .HasColumnName("STUDENT_ID_ET")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Unity)
                    .HasColumnName("UNITY")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Salle>(entity =>
            {
                entity.HasKey(e => e.CodeSalle);

                entity.ToTable("SALLE");

                entity.Property(e => e.CodeSalle)
                    .HasColumnName("CODE_SALLE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SansPhoto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SANS_PHOTO");

                entity.Property(e => e.Identifiant)
                    .HasColumnName("IDENTIFIANT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Niv)
                    .HasColumnName("NIV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Niveau)
                    .HasColumnName("NIVEAU")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Photos)
                    .HasColumnName("PHOTOS")
                    .HasColumnType("FLOAT");

                entity.Property(e => e.Prenom)
                    .HasColumnName("PRENOM")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Seance>(entity =>
            {
                entity.HasKey(e => e.IdSeance)
                    .HasName("SEANCE_PK");

                entity.ToTable("SEANCE");

                entity.Property(e => e.IdSeance)
                    .HasColumnName("ID_SEANCE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateSeance)
                    .HasColumnName("DATE_SEANCE")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdPhase)
                    .HasColumnName("ID_PHASE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSeance)
                    .HasColumnName("NUMERO_SEANCE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TypeSeance)
                    .HasColumnName("TYPE_SEANCE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeClNavigation)
                    .WithMany(p => p.Seance)
                    .HasForeignKey(d => d.CodeCl)
                    .HasConstraintName("SEANCE_FK2");
            });

            modelBuilder.Entity<Semestre>(entity =>
            {
                entity.ToTable("SEMESTRE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Anneuniversitaire)
                    .HasColumnName("ANNEUNIVERSITAIRE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Datedeb)
                    .HasColumnName("DATEDEB")
                    .HasColumnType("DATE");

                entity.Property(e => e.Datfin)
                    .HasColumnName("DATFIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.Idsem).HasColumnName("IDSEM");
            });

            modelBuilder.Entity<Seminaire>(entity =>
            {
                entity.HasKey(e => e.Idseminaire)
                    .HasName("SYS_C0012007");

                entity.ToTable("SEMINAIRE");

                entity.Property(e => e.Idseminaire)
                    .HasColumnName("IDSEMINAIRE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dateexamen)
                    .HasColumnName("DATEEXAMEN")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.Datefin)
                    .HasColumnName("DATEFIN")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.Dateseminaire)
                    .HasColumnName("DATESEMINAIRE")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.Enseignant)
                    .HasColumnName("ENSEIGNANT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Heuredebut)
                    .HasColumnName("HEUREDEBUT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Heurefin)
                    .HasColumnName("HEUREFIN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Salle)
                    .HasColumnName("SALLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sequence>(entity =>
            {
                entity.HasKey(e => e.SeqName)
                    .HasName("SYS_C0012010");

                entity.ToTable("SEQUENCE");

                entity.Property(e => e.SeqName)
                    .HasColumnName("SEQ_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeqCount)
                    .HasColumnName("SEQ_COUNT")
                    .HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<ServiceEnseignant>(entity =>
            {
                entity.HasKey(e => e.IdSerEn)
                    .HasName("SERVICE_ENSEIGNANT_PK");

                entity.ToTable("SERVICE_ENSEIGNANT");

                entity.Property(e => e.IdSerEn)
                    .HasColumnName("ID_SER_EN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmerChef)
                    .HasColumnName("CONFIRMER_CHEF")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.ConfirmerCup)
                    .HasColumnName("CONFIRMER_CUP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.DateFinSer)
                    .HasColumnName("DATE_FIN_SER")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateSer)
                    .HasColumnName("DATE_SER")
                    .HasColumnType("DATE");

                entity.Property(e => e.HeureDebut)
                    .HasColumnName("HEURE_DEBUT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HeureFin)
                    .HasColumnName("HEURE_FIN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NatureSer)
                    .HasColumnName("NATURE_SER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomSer)
                    .HasColumnName("NOM_SER")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sessionetudiant>(entity =>
            {
                entity.HasKey(e => e.Idsessionet)
                    .HasName("SYS_C0012016");

                entity.ToTable("SESSIONETUDIANT");

                entity.Property(e => e.Idsessionet)
                    .HasColumnName("IDSESSIONET")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Matricule)
                    .HasColumnName("MATRICULE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sessionpresoutenance>(entity =>
            {
                entity.HasKey(e => e.Idsoutenance)
                    .HasName("SYS_C0012019");

                entity.ToTable("SESSIONPRESOUTENANCE");

                entity.Property(e => e.Idsoutenance)
                    .HasColumnName("IDSOUTENANCE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Datedebut)
                    .HasColumnName("DATEDEBUT")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.Datefin)
                    .HasColumnName("DATEFIN")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sessionsoutenance>(entity =>
            {
                entity.HasKey(e => e.Idsoutenance)
                    .HasName("SYS_C0012023");

                entity.ToTable("SESSIONSOUTENANCE");

                entity.Property(e => e.Idsoutenance)
                    .HasColumnName("IDSOUTENANCE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Datedebut)
                    .HasColumnName("DATEDEBUT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Datefin)
                    .HasColumnName("DATEFIN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Etat).HasColumnName("ETAT");

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Societe>(entity =>
            {
                entity.HasKey(e => e.CodeSoc);

                entity.ToTable("SOCIETE");

                entity.Property(e => e.CodeSoc)
                    .HasColumnName("CODE_SOC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActiveDispenseAuto)
                    .HasColumnName("ACTIVE_DISPENSE_AUTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActiveModuleOpt)
                    .HasColumnName("ACTIVE_MODULE_OPT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActiveMpEns)
                    .HasColumnName("ACTIVE_MP_ENS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActiverTauxAbsence)
                    .HasColumnName("ACTIVER_TAUX_ABSENCE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AdrSoc)
                    .HasColumnName("ADR_SOC")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AffichNote)
                    .HasColumnName("AFFICH_NOTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.AnneeAdmission)
                    .HasColumnName("ANNEE_ADMISSION")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AnneeFin)
                    .HasColumnName("ANNEE_FIN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Banque)
                    .HasColumnName("BANQUE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BiRachat)
                    .HasColumnName("BI_RACHAT")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.BlockOtherRat)
                    .HasColumnName("BLOCK_OTHER_RAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.BsRachat)
                    .HasColumnName("BS_RACHAT")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.CheminFichierDonnee)
                    .HasColumnName("CHEMIN_FICHIER_DONNEE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodePostal)
                    .HasColumnName("CODE_POSTAL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeRgltComptant)
                    .HasColumnName("CODE_RGLT_COMPTANT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodeRgltEspece)
                    .HasColumnName("CODE_RGLT_ESPECE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodeTva)
                    .HasColumnName("CODE_TVA")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ControlBalckliste)
                    .HasColumnName("CONTROL_BALCKLISTE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreditMax)
                    .HasColumnName("CREDIT_MAX")
                    .HasColumnType("NUMBER(18,6)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CtrlConformEcts)
                    .HasColumnName("CTRL_CONFORM_ECTS")
                    .HasColumnType("NUMBER(38)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CtrlFinStat)
                    .HasColumnName("CTRL_FIN_STAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DateCr)
                    .HasColumnName("DATE_CR")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateDebutSaison)
                    .HasColumnName("DATE_DEBUT_SAISON")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateMaj)
                    .HasColumnName("DATE_MAJ")
                    .HasColumnType("DATE");

                entity.Property(e => e.Datedemarragecs)
                    .HasColumnName("DATEDEMARRAGECS")
                    .HasColumnType("DATE");

                entity.Property(e => e.DelibResultats)
                    .HasColumnName("DELIB_RESULTATS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.EMail)
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FaxSoc)
                    .HasColumnName("FAX_SOC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FrScolariteCj)
                    .HasColumnName("FR_SCOLARITE_CJ")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.FrScolariteCs)
                    .HasColumnName("FR_SCOLARITE_CS")
                    .HasColumnType("NUMBER(18,6)");

                entity.Property(e => e.GererSemestre)
                    .HasColumnName("GERER_SEMESTRE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdDiret)
                    .HasColumnName("ID_DIRET")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IdServScolaire)
                    .HasColumnName("ID_SERV_SCOLAIRE")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IdVacataire)
                    .HasColumnName("ID_VACATAIRE")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.LiaisonFinancier)
                    .HasColumnName("LIAISON_FINANCIER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LiaisonSite)
                    .HasColumnName("LIAISON_SITE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaxTauxCreditAccepte)
                    .HasColumnName("MAX_TAUX_CREDIT_ACCEPTE")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MaxValCreditAccepte)
                    .HasColumnName("MAX_VAL_CREDIT_ACCEPTE")
                    .HasColumnType("NUMBER(18,6)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MinMoyResussite)
                    .HasColumnName("MIN_MOY_RESUSSITE")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.MinPanier)
                    .HasColumnName("MIN_PANIER")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.NbMaxAbsModule)
                    .HasColumnName("NB_MAX_ABS_MODULE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.NbSceanceJour)
                    .HasColumnName("NB_SCEANCE_JOUR")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.NbhSemaine)
                    .HasColumnName("NBH_SEMAINE")
                    .HasColumnType("NUMBER(4,1)");

                entity.Property(e => e.NomSoc)
                    .HasColumnName("NOM_SOC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumSemestreActuel).HasColumnName("NUM_SEMESTRE_ACTUEL");

                entity.Property(e => e.Numpromotioncs)
                    .HasColumnName("NUMPROMOTIONCS")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.QuotaEctsNv)
                    .HasColumnName("QUOTA_ECTS_NV")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.Rc)
                    .HasColumnName("RC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Rib)
                    .HasColumnName("RIB")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sigle)
                    .HasColumnName("SIGLE")
                    .HasColumnType("BFILE");

                entity.Property(e => e.Symbole)
                    .HasColumnName("SYMBOLE")
                    .HasColumnType("CHAR(10)");

                entity.Property(e => e.TauxDs)
                    .HasColumnName("TAUX_DS")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TauxExam)
                    .HasColumnName("TAUX_EXAM")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TauxExamWithCc)
                    .HasColumnName("TAUX_EXAM_WITH_CC")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TauxExamWithTpCc)
                    .HasColumnName("TAUX_EXAM_WITH_TP_CC")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TauxMaxAbsence)
                    .HasColumnName("TAUX_MAX_ABSENCE")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TauxOrale)
                    .HasColumnName("TAUX_ORALE")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TauxRglt)
                    .HasColumnName("TAUX_RGLT")
                    .HasColumnType("NUMBER(10,3)");

                entity.Property(e => e.TauxTp)
                    .HasColumnName("TAUX_TP")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.TelSoc)
                    .HasColumnName("TEL_SOC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimbFiscal)
                    .HasColumnName("TIMB_FISCAL")
                    .HasColumnType("NUMBER(6,3)");

                entity.Property(e => e.TimbreFiscal)
                    .HasColumnName("TIMBRE_FISCAL")
                    .HasColumnType("NUMBER(6,3)");

                entity.Property(e => e.TotEctsAdmis)
                    .HasColumnName("TOT_ECTS_ADMIS")
                    .HasColumnType("NUMBER(5,2)");

                entity.Property(e => e.VerrouPlEtude)
                    .HasColumnName("VERROU_PL_ETUDE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VerrouResul)
                    .HasColumnName("VERROU_RESUL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Ville)
                    .HasColumnName("VILLE")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Soutenance>(entity =>
            {
                entity.ToTable("SOUTENANCE");

                entity.Property(e => e.Soutenanceid)
                    .HasColumnName("SOUTENANCEID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dte)
                    .HasColumnName("DTE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EtIdEt)
                    .HasColumnName("ET_ID_ET")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Etat).HasColumnName("ETAT");

                entity.Property(e => e.Heure)
                    .HasColumnName("HEURE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idrapporteur)
                    .HasColumnName("IDRAPPORTEUR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Jury).HasColumnName("JURY");

                entity.Property(e => e.PrId).HasColumnName("PR_ID");

                entity.Property(e => e.Repporteur)
                    .HasColumnName("REPPORTEUR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SessionsoutenanceIdsoutenance).HasColumnName("SESSIONSOUTENANCE_IDSOUTENANCE");

                entity.HasOne(d => d.Pr)
                    .WithMany(p => p.Soutenance)
                    .HasForeignKey(d => d.PrId)
                    .HasConstraintName("FKA24D7B531D585C79");

                entity.HasOne(d => d.SessionsoutenanceIdsoutenanceNavigation)
                    .WithMany(p => p.Soutenance)
                    .HasForeignKey(d => d.SessionsoutenanceIdsoutenance)
                    .HasConstraintName("FKA24D7B53FADDF4FC");
            });

            modelBuilder.Entity<Specialite>(entity =>
            {
                entity.ToTable("SPECIALITE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NomSpec)
                    .HasColumnName("NOM_SPEC")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StrNome>(entity =>
            {
                entity.HasKey(e => e.CodeStr);

                entity.ToTable("STR_NOME");

                entity.Property(e => e.CodeStr)
                    .HasColumnName("CODE_STR")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NomStr)
                    .HasColumnName("NOM_STR")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TableImport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TABLE_IMPORT");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NivAcquisAnglais)
                    .HasColumnName("NIV_ACQUIS_ANGLAIS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NivAcquisFrancais)
                    .HasColumnName("NIV_ACQUIS_FRANCAIS")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempAli>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_ALI");

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateRat)
                    .HasColumnName("DATE_RAT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Heure)
                    .HasColumnName("HEURE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Jour)
                    .HasColumnName("JOUR")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .HasColumnName("MODULE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Seance)
                    .HasColumnName("SEANCE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasColumnName("SITE")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempCreditTic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_CREDIT_TIC");

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DateRat)
                    .HasColumnName("DATE_RAT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Designation)
                    .HasColumnName("DESIGNATION")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.HeureRat)
                    .HasColumnName("HEURE_RAT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Jour)
                    .HasColumnName("JOUR")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Pole)
                    .HasColumnName("POLE")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TES");

                entity.Property(e => e.ChoixActuel)
                    .HasColumnName("CHOIX_ACTUEL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MinScorePourReorientation)
                    .HasColumnName("MIN_SCORE_POUR_REORIENTATION")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NumChoixActuel)
                    .HasColumnName("NUM_CHOIX_ACTUEL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumChoixReorientation)
                    .HasColumnName("NUM_CHOIX_REORIENTATION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Reorientation)
                    .HasColumnName("REORIENTATION")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ScorChActuel)
                    .HasColumnName("SCOR_CH_ACTUEL")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ScoreReorientation)
                    .HasColumnName("SCORE_REORIENTATION")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpCorrectionCl>(entity =>
            {
                entity.HasKey(e => e.IdEt)
                    .HasName("SYS_C0012040");

                entity.ToTable("TMP_CORRECTION_CL");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .IsRequired()
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpDiplome17anx2>(entity =>
            {
                entity.HasKey(e => e.N)
                    .HasName("SYS_C0012050");

                entity.ToTable("TMP_DIPLOME17ANX2");

                entity.Property(e => e.N).HasColumnType("NUMBER(38)");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.CodeCl)
                    .IsRequired()
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DateEdition)
                    .IsRequired()
                    .HasColumnName("DATE_EDITION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateEditionNew)
                    .HasColumnName("DATE_EDITION_NEW")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdEt)
                    .IsRequired()
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomEt)
                    .IsRequired()
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumAnnexe)
                    .HasColumnName("NUM_ANNEXE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PnomEt)
                    .IsRequired()
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpEcoleOrigine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_ECOLE_ORIGINE");

                entity.Property(e => e.CodeNome)
                    .HasColumnName("CODE_NOME")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LibNome)
                    .HasColumnName("LIB_NOME")
                    .HasMaxLength(93)
                    .IsUnicode(false);

                entity.Property(e => e.NomCourt)
                    .HasColumnName("NOM_COURT")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpEns>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_ENS");

                entity.Property(e => e.DateEchelle)
                    .HasColumnName("DATE_ECHELLE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DateEchelon)
                    .HasColumnName("DATE_ECHELON")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DeptCode)
                    .HasColumnName("DEPT_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EchCode)
                    .HasColumnName("ECH_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EchlCode)
                    .HasColumnName("ECHL_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EmpCivilite)
                    .HasColumnName("EMP_CIVILITE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmpDateNaiss)
                    .HasColumnName("EMP_DATE_NAISS")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EmpDateP)
                    .HasColumnName("EMP_DATE_P")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNom)
                    .HasColumnName("EMP_NOM")
                    .HasMaxLength(39)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNumP)
                    .HasColumnName("EMP_NUM_P")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpPrenom)
                    .HasColumnName("EMP_PRENOM")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.EmpRecrutDate)
                    .HasColumnName("EMP_RECRUT_DATE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EmpSituation)
                    .HasColumnName("EMP_SITUATION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEns)
                    .HasColumnName("TYPE_ENS")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpOreintation2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_OREINTATION_2");

                entity.Property(e => e.Ch)
                    .HasColumnName("CH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Chifina)
                    .HasColumnName("CHIFINA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Numchois)
                    .HasColumnName("NUMCHOIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Scorchfinal)
                    .HasColumnName("SCORCHFINAL")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Score)
                    .HasColumnName("SCORE")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpOrientation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_ORIENTATION");

                entity.Property(e => e.Ch)
                    .HasColumnName("CH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Chifina)
                    .HasColumnName("CHIFINA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodeCl)
                    .HasColumnName("CODE_CL")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Etat)
                    .HasColumnName("ETAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Numchois)
                    .HasColumnName("NUMCHOIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Scorchfinal)
                    .HasColumnName("SCORCHFINAL")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Score)
                    .HasColumnName("SCORE")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpResultatEtud>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_RESULTAT_ETUD");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnName("ANNEE_DEB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeModule)
                    .HasColumnName("CODE_MODULE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodeUe)
                    .HasColumnName("CODE_UE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CoefModule)
                    .HasColumnName("COEF_MODULE")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationModule)
                    .HasColumnName("DESIGNATION_MODULE")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LibDecisionSessionP)
                    .HasColumnName("LIB_DECISION_SESSION_P")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.LibSpecialite)
                    .HasColumnName("LIB_SPECIALITE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LibUe)
                    .HasColumnName("LIB_UE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MoyGeneral)
                    .HasColumnName("MOY_GENERAL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Moyenne)
                    .HasColumnName("MOYENNE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MoyenneUe)
                    .HasColumnName("MOYENNE_UE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NbEcts)
                    .HasColumnName("NB_ECTS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NbEctsSp)
                    .HasColumnName("NB_ECTS_SP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomEt)
                    .HasColumnName("NOM_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PnomEt)
                    .HasColumnName("PNOM_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeMoy)
                    .HasColumnName("TYPE_MOY")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpSoldeEtud2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_SOLDE_ETUD2");

                entity.Property(e => e.GroupeComptaMarche)
                    .HasColumnName("GROUPE_COMPTA_MARCHE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdentifiantEtudiant)
                    .HasColumnName("IDENTIFIANT_ETUDIANT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.N)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoldeDs)
                    .HasColumnName("SOLDE_DS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpTelephone>(entity =>
            {
                entity.HasKey(e => e.IdEt)
                    .HasName("TMP_TELEPHONE_PK");

                entity.ToTable("TMP_TELEPHONE");

                entity.Property(e => e.IdEt)
                    .HasColumnName("ID_ET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelParentEt)
                    .HasColumnName("TEL_PARENT_ET")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TypeMvt>(entity =>
            {
                entity.HasKey(e => e.TypeMvt1)
                    .HasName("SYS_C002804");

                entity.ToTable("TYPE_MVT");

                entity.Property(e => e.TypeMvt1)
                    .HasColumnName("TYPE_MVT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodePrix)
                    .HasColumnName("CODE_PRIX")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.CompteurAuto)
                    .HasColumnName("COMPTEUR_AUTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastMvt)
                    .HasColumnName("DATE_LAST_MVT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Designation)
                    .HasColumnName("DESIGNATION")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LibelleType)
                    .HasColumnName("LIBELLE_TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumAuto).HasColumnName("NUM_AUTO");

                entity.Property(e => e.Signe)
                    .HasColumnName("SIGNE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TailleCompteur)
                    .HasColumnName("TAILLE_COMPTEUR")
                    .HasColumnType("NUMBER(2)");
            });

            modelBuilder.Entity<Up>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UP");

                entity.Property(e => e.IdEns)
                    .HasColumnName("ID_ENS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NomEns)
                    .HasColumnName("NOM_ENS")
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.Up1)
                    .HasColumnName("UP")
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("SYS_C0012058");

                entity.ToTable("UTILISATEUR");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adresse)
                    .HasColumnName("ADRESSE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChefDep)
                    .HasColumnName("CHEF_DEP")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasColumnName("LOGIN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasColumnName("TELEPHONE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
