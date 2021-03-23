﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspAdmission
    {
        public string AnneeDeb { get; set; }
        public int? NumLot { get; set; }
        public int Id { get; set; }
        public string IdEt { get; set; }
        public string NomEt { get; set; }
        public string PnomEt { get; set; }
        public string DateNaisEt { get; set; }
        public long? CycleEt { get; set; }
        public long? NatureBac { get; set; }
        public string DateBac { get; set; }
        public string EtabBac { get; set; }
        public long? NiveauDiplomeSupEt { get; set; }
        public string EtabOrigine { get; set; }
        public long? SpecialiteEspEt { get; set; }
        public long? NiveauAcces { get; set; }
        public string CodeSpecOrigine { get; set; }
        public string LibSpecOrigine { get; set; }
        public long? MoyBacEt { get; set; }
        public long? AnneeBac { get; set; }
        public string IdEt2 { get; set; }
        public long? Entretien { get; set; }
        public long? Anglais { get; set; }
        public long? Francais { get; set; }
        public long? Qi { get; set; }
        public long? Colonne1 { get; set; }
        public long? Scoreagebac { get; set; }
        public long? Scoremoybac { get; set; }
        public long? Colonne2 { get; set; }
        public long? Scorebac { get; set; }
        public decimal? FrScore { get; set; }
        public decimal? AngScore { get; set; }
        public decimal? QiScore { get; set; }
        public decimal? Scoreexam { get; set; }
        public decimal? Scoreentretien { get; set; }
        public decimal? Scorefinalentretien { get; set; }
        public string Champ33 { get; set; }
        public decimal? ScoreFinal { get; set; }
    }
}
