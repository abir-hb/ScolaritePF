﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspModulePanierClasseSaiso
    {
        public string CodeModule { get; set; }
        public string NumPanier { get; set; }
        public string CodeCl { get; set; }
        public string AnneeDeb { get; set; }
        public string AnneeFin { get; set; }
        public string Description { get; set; }
        public decimal? NbHeures { get; set; }
        public decimal? Coef { get; set; }
        public decimal NumSemestre { get; set; }
        public decimal? NumPeriodfe { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public DateTime? DateExamen { get; set; }
        public decimal? NbHoraireRealises { get; set; }
        public string Acomptabiliser { get; set; }
        public string IdEns { get; set; }
        public string IdEns2 { get; set; }
        public decimal? NbHeuresEns { get; set; }
        public decimal? NbHeuresEns2 { get; set; }
        public string Surveillant { get; set; }
        public string HeureExam { get; set; }
        public string SalleExam { get; set; }
        public string Surveillant2 { get; set; }
        public string SalleExam2 { get; set; }
        public decimal? Periode { get; set; }
        public byte? Numpromotioncs { get; set; }
        public bool? ApCs { get; set; }
        public decimal? ChargeP1 { get; set; }
        public decimal? ChargeP2 { get; set; }
        public decimal? ChargeEns1P1 { get; set; }
        public decimal? ChargeEns1P2 { get; set; }
        public decimal? ChargeEns2P1 { get; set; }
        public decimal? ChargeEns2P2 { get; set; }
        public string SeanceUnique { get; set; }
        public string IdEns3 { get; set; }
        public string IdEns4 { get; set; }
        public string IdEns5 { get; set; }
        public decimal? ChargeEns3P1 { get; set; }
        public decimal? ChargeEns3P2 { get; set; }
        public decimal? ChargeEns4P1 { get; set; }
        public decimal? ChargeEns4P2 { get; set; }
        public decimal? ChargeEns5P1 { get; set; }
        public decimal? ChargeEns5P2 { get; set; }
        public string CodeUe { get; set; }
        public byte? NbEcts { get; set; }
        public string TypeEpreuve { get; set; }
        public string Salle { get; set; }
        public string TypeEns { get; set; }
        public string TypeEpreuveSr { get; set; }
        public DateTime? DateRattrapage { get; set; }
        public string HeureRat { get; set; }
        public string Salle1Rat { get; set; }
        public string Salle2Rat { get; set; }
        public DateTime? DateRat { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? DaterLastMaj { get; set; }
        public string DesignationNew { get; set; }
        public decimal? Chargep1add { get; set; }
        public decimal? Chargep2add { get; set; }
        public long? CodePlan { get; set; }
        public decimal? Nbheuradd { get; set; }
        public string CalculRat { get; set; }
        public string ExisteCc { get; set; }
        public string ExisteTp { get; set; }
        public string HeureFinSp { get; set; }
        public string HeureFinSr { get; set; }
        public string UeFantome { get; set; }
        public string Utilisateur { get; set; }

        public virtual Classe CodeClNavigation { get; set; }
        public virtual EspModule CodeModuleNavigation { get; set; }
        public virtual EspEnseignant IdEnsNavigation { get; set; }
    }
}
