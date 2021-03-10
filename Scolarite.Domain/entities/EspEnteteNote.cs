﻿using System;
using System.Collections.Generic;

namespace Scolarite.Domain.entities
{
    public partial class EspEnteteNote
    {
        public EspEnteteNote()
        {
            EspNote = new HashSet<EspNote>();
        }

        public string CodeModule { get; set; }
        public string NumPanier { get; set; }
        public string CodeCl { get; set; }
        public string AnneeDeb { get; set; }
        public string AnneeFin { get; set; }
        public string IdEns { get; set; }
        public string TypeSession { get; set; }
        public string NatureNote { get; set; }
        public string Observation { get; set; }
        public DateTime DateDeroulement { get; set; }
        public bool Semestre { get; set; }
        public byte? NbHeure { get; set; }
        public string Confirmation { get; set; }
        public DateTime? DateSaisie { get; set; }
        public DateTime? DateConfirmation { get; set; }
        public decimal? TauxExam { get; set; }
        public decimal? TauxCc { get; set; }
        public decimal? TauxTp { get; set; }
        public string ExisteNoteCc { get; set; }
        public string ExisteNoteTp { get; set; }
        public decimal? Coef { get; set; }
        public DateTime? DateRatrap { get; set; }
        public string UserName { get; set; }
        public string ConfRattrapage { get; set; }
        public DateTime? DateConfRatt { get; set; }
        public string UserConfirm { get; set; }
        public DateTime? DateLastModif { get; set; }
        public string UserLastModif { get; set; }
        public string UserConfirmRatt { get; set; }
        public string TatouageEns { get; set; }
        public string ConfirmNew { get; set; }
        public byte? Numpromotioncs { get; set; }
        public decimal? TauxEcritLang { get; set; }
        public decimal? TauxOralLang { get; set; }
        public decimal? TauxCcLang { get; set; }
        public string ModuleFantome { get; set; }

        public virtual ICollection<EspNote> EspNote { get; set; }
    }
}
