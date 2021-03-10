﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspNote
    {
        public string CodeModule { get; set; }
        public string NumPanier { get; set; }
        public string CodeCl { get; set; }
        public string AnneeDeb { get; set; }
        public string AnneeFin { get; set; }
        public string IdEt { get; set; }
        public string TypeNote { get; set; }
        public string NatureNote { get; set; }
        public decimal? TauxNote { get; set; }
        public string Observation { get; set; }
        public DateTime? DateDeroulement { get; set; }
        public bool Semestre { get; set; }
        public string IdEns { get; set; }
        public byte? NbHeure { get; set; }
        public string TypeSession { get; set; }
        public decimal? NoteExam { get; set; }
        public decimal? NoteCc { get; set; }
        public decimal? NoteTp { get; set; }
        public decimal? NoteRatrap { get; set; }
        public string Absent { get; set; }
        public string Justif { get; set; }
        public string AbsentTp { get; set; }
        public string AbsentCc { get; set; }
        public string AbsentExam { get; set; }
        public string Utilisateur { get; set; }
        public byte? Numpromotioncs { get; set; }
        public string NivAcquisAnglais { get; set; }
        public string NiveauAcquis { get; set; }
        public decimal? NoteOrale { get; set; }
        public decimal? NoteEcrit { get; set; }
        public string Dispense { get; set; }
        public string AbsentOrale { get; set; }
        public string AbsentEcrit { get; set; }
        public string NiveauActuel { get; set; }
        public decimal? NoteCcLang { get; set; }
        public decimal? NoteOraleLang { get; set; }
        public decimal? NoteEcritLang { get; set; }
        public decimal? TauxCcLang { get; set; }
        public decimal? TauxOraleLang { get; set; }
        public decimal? TauxEcritLang { get; set; }
        public DateTime? DateSaisie { get; set; }
        public DateTime? DateLastModif { get; set; }
        public decimal? NoteEsb01 { get; set; }
        public decimal? NoteEsb02 { get; set; }
        public string AdresseIp { get; set; }
        public string NomMachine { get; set; }

        public virtual EspEnteteNote EspEnteteNote { get; set; }
    }
}
